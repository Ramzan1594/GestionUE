using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace TFEGestionUE.UC
{
    // délégués ***********************************************************************
    //public delegate void Finir(Personne etuCourant, int secCourante, int possedeAtt);                 //DELEGATE A

    public partial class UC_CRUP_SESS : UserControl
    {
        // déclarations ***************************************************************************
        private List<Ue> listeUe;
        private List<Session> sesQuiVenDetrePrise;
        private Section sectionCourante;
        private Ue ueCourante;
        private int sectionCouranteId, enregistrerSes;
        

        // EVENT ***************************************************************************
        public event Selection OnAnnulerClicked;
        public event EnvoieUnParam OnEnregistrerClicked;


        public UC_CRUP_SESS()
        {
            InitializeComponent();
            
        }

        //OBSERVATEUR pour obtenir la section courante quand on appuie le boutton AJOUTER SESSION
        //recupere la section courante selectionnee dans UC_SRCH_SES avant d appuiyer sur le boutton ajouter session
        public void recupereSection(Section sec)  //observateur du boutton ajouter session dans SRCH SES
        {
            sectionCourante = sec;
            sectionCouranteId = sec.SecId;

            rempliComboUe();            
        }

        // ComboBox UE
        public void rempliComboUe()
        {
            listeUe = DAL.AccesUe.Charger_UE(sectionCouranteId);

            if (this.listeUe.Count > 0 )
            {
                this.cbUe.DataSource = listeUe;
            }
        }

        //Recupere la uecourante
        private void cbUe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ueCourante = (Ue)cbUe.SelectedItem;
        }

        //Boutton ENREGISTRER
        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (validation())
            { 
                try
                {
                    Session ses = recolterSession();
                    //il y a deja une session pour cette ue a cette date
                    Ue ueCourante = (Ue)cbUe.SelectedItem;
                    
                    List<Session> sessionDB = DAL.AccesSessions.Charger_SESDuneUe(ueCourante.UeId);
                    bool dejaLa = BL.SessionsSeancesTri.sessionDejaPresante(ses, sessionDB);

                    if (dejaLa)
                    {
                        MessageBox.Show(this, "Cette ue a déjà une session durant cette période", "Information ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                    }
                    else
                    {
                        enregistrerSes = DAL.AccesSessions.AjouterSession(ses);
                        MessageBox.Show(this, "Enregistrement réussis", "Enregistrement ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);

                        //utilisé pour recupere la ses id de la session enregistrer - on a recolte une 2eme fois avec sesId
                        sesQuiVenDetrePrise = DAL.AccesSessions.Charger_SESDuneUe(ueCourante.UeId);
                        ses = recolterSession();

                        if (OnEnregistrerClicked != null)     // DECLENCHEUR
                        {
                            OnEnregistrerClicked(ses);
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, ex.GetType().ToString());
                    string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                    MessageBox.Show(exMsg);
                }
            }
            else
            {
                MessageBox.Show(this, "Erreur ! Vérifier les données encodées dans les dates. \n\n", "Attention",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
            }      
        }

        //Boutton ANNULER
        private void bAnnuler_Click(object sender, EventArgs e)
        {
            dtpDeb.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            if (OnAnnulerClicked != null)
            {
                OnAnnulerClicked();
            }

        }

        //Récolte la session affichée
        public Session recolterSession()
        {
            Session ret = new Session();

            //Nouvelle session / une fois que la session a ete prise 
            //on recupere son id en db
            if (enregistrerSes > 0)
                ret.SesId = sesQuiVenDetrePrise[0].SesId;

            ret.SesDeb  = dtpDeb.Value.Date;
            ret.SesFin  = dtpFin.Value.Date;

            Ue ueCourante = (Ue)cbUe.SelectedItem;
            ret.SesFkUe = ueCourante.UeId;

            ret.Intitule = cbUe.Text;
            
            return ret;
        }


        //A chaque modification de dtpDeb ca met +1 jour a dtpFin
        private void dtpDeb_ValueChanged(object sender, EventArgs e)
        {
            dtpFin.Value = dtpDeb.Value.AddDays(1);
        }

        //Vérification avant de valider une session
        public bool validation()
        {
            bool ret = true;

            if(dtpDeb.Value > dtpFin.Value || dtpDeb.Value == dtpFin.Value)
            {
                ret = false;
            }

            return ret;
        }
        public void resetUc()
        {
            dtpDeb.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cbUe.SelectedIndex = 0;
        }

    }
}
