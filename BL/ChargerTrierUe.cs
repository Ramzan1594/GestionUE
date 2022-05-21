using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class ChargerTrierUe
    {
        //***************************************************************************
        //Charger la liste des UE (dgvUe) en prenant en compte les ATT et PAR
        public static List<Ue> chargerUE_TOTAL(int ETU_ID, int SEC_ID, ref int NbrRéussite, ref int NbrRestante, ref decimal PourcentageDet, ref decimal Pourcentage)
        {
            NbrRéussite = 0;
            NbrRestante = 0;

            PourcentageDet = 0.0m;
            Pourcentage = 0.0m;
            int Periode = 0;
            int PeriodeTot = 0;
            int PeriodeDet = 0;
            decimal Pts = 0;
            List<Ue> listUE = new List<Ue>();
            List<Ue> listUEquiOntATTestation = new List<Ue>();
            List<Ue> listInscription = new List<Ue>();

            listUE = DAL.AccesUe.Charger_UE(SEC_ID);                        // la liste de tous les UE avec situation  RESTANT
            listUEquiOntATTestation = DAL.AccesAttestations.Charger_UE_ATT(ETU_ID);  // la liste de tous les REUSSIS
            listInscription = DAL.AccesPar.Charger_UE_INS(ETU_ID);          // la liste des UE ou l'etudiant PARTICIPE

            if (listUEquiOntATTestation.Count > 0)
            {
                int nbDet = 0;
                foreach (Ue ue in listUEquiOntATTestation)
                {
                    Pts = ue.Prctg;
                    Pourcentage = Pourcentage + Pts;

                    if (ue.Determinante)
                    {
                        PourcentageDet += Pts;
                        nbDet++;
                    }
                }
                Pourcentage = Pourcentage; 
                PourcentageDet = PourcentageDet;

                Pourcentage /= listUEquiOntATTestation.Count;
                if(nbDet != 0)
                    PourcentageDet /= nbDet;

                NbrRéussite = listUEquiOntATTestation.Count;                
            }
            NbrRestante = listUE.Count - NbrRéussite;
            bool attTrouve;
            for (int i = 0; i < listUE.Count; i++)
            {
                attTrouve = false;
                for (int j = 0; j < listUEquiOntATTestation.Count; j++)  // on boucle dans ATT et PAR
                {
                    if (listUE[i].UeId == listUEquiOntATTestation[j].UeId)   // on selectionne ceux qui ont des attestation UE - ATT
                    {
                        listUE[i] = listUEquiOntATTestation[j];
                        attTrouve = true;
                    }
                }
                for (int j = 0; j < listInscription.Count; j++)  // on boucle dans PAT - les ueEnCour
                {
                    if (listUE[i].UeId == listInscription[j].UeId && attTrouve == false)
                        listUE[i] = listInscription[j];
                }
            }
            listUE.Sort();
            return listUE;
        }
        //***************************************************************************
        //Session qui sont en cours , qui ont deja commencée ( ou l etudiant est  inscrit)
        public static List<Ue> chargerSessionEnCours(List<Ue> list)
        {
            List<Ue> retval = new List<Ue>();
            foreach (Ue ue in list)
                if (ue.Situation == "En Cours")
                    retval.Add(ue);
            retval.Sort();
            return retval;
        }

        //***************************************************************************
        //Session qui sont accessible a l'etudiant
        public static List<Ue> chargerSessionAccessible(int ETU_ID, int SEC_ID)
        {
            List<Ue> retval = new List<Ue>();

            List<Ue> listUEenCours = new List<Ue>();
            List<Ue> listUEquiOntSES = new List<Ue>();
            List<Requis> listREQ = new List<Requis>();
            List<Ue> listUEquiOntATT = new List<Ue>();

            listUEenCours = DAL.AccesPar.Charger_UE_INS(ETU_ID);
            listUEquiOntSES = DAL.AccesSessions.Charger_UEavecSES(SEC_ID);
            listREQ = DAL.AccesReq.Charger_Req(SEC_ID);
            listUEquiOntATT = DAL.AccesAttestations.Charger_UE_ATT(ETU_ID);

            bool trouvé = false;

            // on test si les ue sont en cours ou l'etudiant a des attest
            for (int cptrSES = 0; cptrSES < listUEquiOntSES.Count; cptrSES++)
            {
                trouvé = false;

                for (int cpAtt = 0; cpAtt < listUEquiOntATT.Count; cpAtt++)
                {
                    if (listUEquiOntSES[cptrSES].UeId == listUEquiOntATT[cpAtt].UeId)
                    {
                        trouvé = true;
                        break;
                    }
                }
                for (int cptrEnCours = 0; cptrEnCours < listUEenCours.Count; cptrEnCours++)
                {
                    if (listUEquiOntSES[cptrSES].UeId == listUEenCours[cptrEnCours].UeId)
                    {
                        trouvé = true;
                        break;
                    }
                }
                if (trouvé == false)
                    retval.Add(listUEquiOntSES[cptrSES]);
            }

            // on test si les ue on des pre requis
            for (int cptrSES = 0; cptrSES < retval.Count; cptrSES++)
            {
                for (int cptrREQ = 0; cptrREQ < listREQ.Count; cptrREQ++)
                {
                    if (retval[cptrSES].UeId == listREQ[cptrREQ].REQ_FK_SUI_UE)
                    {
                        trouvé = false;
                        for (int cptrATT = 0; cptrATT < listUEquiOntATT.Count; cptrATT++)
                        {
                            if (listREQ[cptrREQ].REQ_FK_PRE_UE == listUEquiOntATT[cptrATT].UeId)
                            {
                                trouvé = true;
                                break;
                            }
                        }
                        if (trouvé == false)
                        {
                            retval.Remove(retval[cptrSES]);
                            cptrSES--;
                            break;
                        }
                    }
                }
            }
            retval.Sort();
            return retval;
        }

        //***************************************************************************
        //UE qui sont disponible pour obtenir une attestation
        public static List<Ue> chargerUePourAttestation(int ETU_ID, int SEC_ID)
        {
            List<Ue> retval = new List<Ue>();

            List<Ue> listeUe = new List<Ue>();
            List<Ue> listUEenCours = new List<Ue>();            
            List<Requis> listREQ = new List<Requis>();
            List<Ue> listUEquiOntATT = new List<Ue>();

            listeUe = DAL.AccesUe.Charger_UE(SEC_ID);
            listUEenCours = DAL.AccesPar.Charger_UE_INS(ETU_ID);
            listREQ = DAL.AccesReq.Charger_Req(SEC_ID);
            listUEquiOntATT = DAL.AccesAttestations.Charger_UE_ATT(ETU_ID);

            bool trouvé = false;
            
            // on selectionne tous les ue dont l etudiant na pas d attestaion , et ne participe pas
            for (int cptrUe = 0; cptrUe < listeUe.Count; cptrUe++)
            {
                trouvé = false;
                if (listeUe[cptrUe].EPI == false)
                {
                    //checker s il a reussis toutes les UE pour avoir acces a TFE
                    //check les ATTESTATION
                    for (int cpAtt = 0; cpAtt < listUEquiOntATT.Count; cpAtt++)
                    {
                        if (listeUe[cptrUe].UeId == listUEquiOntATT[cpAtt].UeId)
                        {
                            trouvé = true;
                            break;
                        }
                    }
                    //UE en cours
                    for (int cptrEnCours = 0; cptrEnCours < listUEenCours.Count; cptrEnCours++)
                    {
                        if (listeUe[cptrUe].UeId == listUEenCours[cptrEnCours].UeId)
                        {
                            trouvé = true;
                            break;
                        }
                    }
                    if (trouvé == false)
                        retval.Add(listeUe[cptrUe]);
                }
                else
                {
                    int tousLesUeNoEPI = listeUe.Count - 1;
                    //boucle sur tous les ue et on check s il sont tous dans les attestation 
                    for (int cptr = 0; cptr < listeUe.Count; cptr++)
                    {
                        //on check donc si la ue est dans attest 
                        for (int cpAtt = 0; cpAtt < listUEquiOntATT.Count; cpAtt++)
                        {
                            //et on soustrai tousLesUeNoEPI a chque fois qu a un attest UE
                            if (listeUe[cptr].EPI == false && listeUe[cptr].UeId == listUEquiOntATT[cpAtt].UeId)
                            {
                                tousLesUeNoEPI--;
                                break;
                            }
                        }                        
                    }
                    if (tousLesUeNoEPI == 0)
                        retval.Add(listeUe[cptrUe]);
                }
            }

            // on test si les ue on des pre requis
            for (int cptrSES = 0; cptrSES < retval.Count; cptrSES++)
            {
                for (int cptrREQ = 0; cptrREQ < listREQ.Count; cptrREQ++)
                {
                    if (retval[cptrSES].UeId == listREQ[cptrREQ].REQ_FK_SUI_UE)
                    {
                        trouvé = false;
                        for (int cptrATT = 0; cptrATT < listUEquiOntATT.Count; cptrATT++)
                        {
                            if (listREQ[cptrREQ].REQ_FK_PRE_UE == listUEquiOntATT[cptrATT].UeId)
                            {
                                trouvé = true;
                                break;
                            }
                        }
                        if (trouvé == false)
                        {
                            retval.Remove(retval[cptrSES]);
                            cptrSES--;
                            break;
                        }
                    }
                }
            }
            retval.Sort();
            return retval;
        }
    }
}
