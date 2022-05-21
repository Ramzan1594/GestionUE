using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    //classe qui sert a trie et verifie les données concernant les sessions et seances
    public static class SessionsSeancesTri
    {
        //Verifie si la session courante est deja enregistre en DB cad s'il y a deja une sessions pour la UE a cette date
        public static bool sessionDejaPresante(Session sessionCourante, List<Session> sessions)
        {
            bool ret = false;

            foreach(Session s in sessions)
            {
                if ((sessionCourante.SesDeb > s.SesDeb && sessionCourante.SesDeb < s.SesFin
                    || sessionCourante.SesFin > s.SesDeb && sessionCourante.SesFin > s.SesFin) && s.SesFkUe == sessionCourante.SesFkUe )
                    ret = true;
            }
            
            return ret;
        }

        //Verifie si la seanceCourante est deja en DB dans les seancesDB
        public static string seanceDejaPresante(Seance seanceCourante, List<Seance> seancesDB)
        {
            string ret = "";

            foreach (Seance s in seancesDB)
            {
                if(s.SeaJour == seanceCourante.SeaJour)
                {
                    if (seanceCourante.SeaDateDeb >= s.SeaDateDeb && seanceCourante.SeaDateDeb <= s.SeaDateFin
                    || seanceCourante.SeaDateFin >= s.SeaDateDeb && seanceCourante.SeaDateFin <= s.SeaDateFin)
                    {
                        ret = s.Intitule + " a déjà des séances durant cette période ( le "+seanceCourante.SeaJour+" se chevauche entre "+seanceCourante.SeaDateDeb.ToShortDateString()+
                            " et "+seanceCourante.SeaDateFin.ToShortDateString()+ ").\n\n";
                    }
                }               
            }

            return ret;
        }

        //verifie si les date de la seance sont comprises entre les date de la session
        public static string seanceDansSession(Seance sea, Session ses)
        {
            string ret = "Les dates encodées sont en dehors des date de la session.\n\n";

            if (sea.SeaDateDeb >= ses.SesDeb && sea.SeaDateDeb < ses.SesFin
                && sea.SeaDateFin >= ses.SesDeb && sea.SeaDateFin <= ses.SesFin)
            {
                ret = "";
            }                  

            return ret;
        }


        //Verifie si l'etudiant a deja des seances a la meme periode qu'a laquell il veut s'inscrire
        // donc on test si la sessionAccessible a des seance qui se déroule en meme temps qu'une des séances des sessions enCours
        public static string etuDajaSeanceACettePeriode(Personne etu, Ue sesIdAccessible, List<Ue> ueEnCour)
        {
            string ret = "";
            //bool ret = false;
            // liste des seance de la session de la ue accessible
            List<Seance> listSEAccessible = AccesSeances.Charger_SEA(sesIdAccessible.SES_ID);


            foreach (Seance s in listSEAccessible)
            {
                foreach(Ue u in ueEnCour)
                {
                    List<Seance> listSEAEnCour = AccesSeances.Charger_SEA(u.SES_ID);
                    if (seanceDejaPresante(s, listSEAEnCour) != "")
                    {
                        //ret = true;
                        ret = seanceDejaPresante(s, listSEAEnCour);
                    }
                }
            }
            /*
            foreach (Ue u in ueEnCour)
            {
                //liste des seance des session des ue en cours
                List<Seance> listSEAEnCour = AccesSeances.Charger_SEA(u.SES_ID);

                foreach(Seance s in listSEAccessible)
                {
                    if(seanceDejaPresante(s, listSEAEnCour) != "")
                    {
                        ret = true;
                    }
                }
            }
            */
            return ret;                
        }


        //Vérifie si la seance que je veux enregistrer est deja prise par une seance de toutes les session
        //public static bool seanceDejaDansAutreSession
    }
}
