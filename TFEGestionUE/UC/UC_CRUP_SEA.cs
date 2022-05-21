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
    public partial class UC_CRUP_SEA : UserControl
    {
        // déclarations ***************************************************************************
        private Session sessionCourante;
        private Section sectionCourante;
        private int suprimSes = 0;

        // EVENT ***************************************************************************
        public event Selection OnAnnulerClicked;
        public event Selection OnEnregistrerClicked;

        public UC_CRUP_SEA()
        {
            InitializeComponent();
            jourSemaineCreneau();
        }


        // Remplir les ComboBox Jour et Créneau
        public void jourSemaineCreneau()
        {
            if (cbJour.SelectedIndex.Equals(-1))
            {
                cbJour.Items.Insert(0, "Lundi");
                cbJour.Items.Insert(1, "Mardi");
                cbJour.Items.Insert(2, "Mercredi");
                cbJour.Items.Insert(3, "Jeudi");
                cbJour.Items.Insert(4, "Vendredi");
                cbJour.Items.Insert(5, "Samedi");
                cbJour.Items.Insert(6, "Dimanche");

                cbJour.SelectedIndex = 0;

                cbCreneau.Items.Insert(0, "Matin");
                cbCreneau.Items.Insert(1, "Après-midi");
                cbCreneau.Items.Insert(2, "Soir");

                cbCreneau.SelectedIndex = 0;
            }
        }

        // OBSERVATEUR pour obtenir la session courante quand on appuie AJOUTER SEANCE
        public void obtenirSessionCourant(Session ses, Section secCourante)
        {
            sessionCourante = ses;
            sectionCourante = secCourante;

            //pre-rempli les date avec celle de la session
            dtpDeb.Value = sessionCourante.SesDeb;
            dtpFin.Value = sessionCourante.SesFin;
        }

        public void desactiverAnnuler(int onOff)
        {
            //bAnnuler.Enabled = true;
            if (onOff == 1)
                bAnnuler.Enabled = false;
        }

        //cette function met le param a 1 pour dire que que dans ce cas quand on appuie sur Annuler dans CRUP_SEA il va supprimer la SES aussi
        public void supprimerSesSea(int suprimSes)
        {
            this.suprimSes = suprimSes;
        }

        //evenement qui change la cbJour a chaque modification de la date de debut
        private void dateDebutChanged(object sender, EventArgs e)
        {
            switch(dtpDeb.Value.DayOfWeek)
            {
                case DayOfWeek.Monday :     cbJour.SelectedIndex = 0; break;
                case DayOfWeek.Tuesday:     cbJour.SelectedIndex = 1; break;
                case DayOfWeek.Wednesday:   cbJour.SelectedIndex = 2; break;
                case DayOfWeek.Thursday:    cbJour.SelectedIndex = 3; break;
                case DayOfWeek.Friday:      cbJour.SelectedIndex = 4; break;
                case DayOfWeek.Saturday:    cbJour.SelectedIndex = 5; break;
                case DayOfWeek.Sunday:      cbJour.SelectedIndex = 6; break;
            }
        }

        // Boutton ENREGISTRER        
        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                try
                {
                    string message = "";
                    Seance sea = recolterSeance();
                    List<Seance> seanceSes = DAL.AccesSeances.Charger_SEA(sessionCourante.SesId); // liste de TOUTES les seances d'une session   

                    //verifie s'il y a deja une seance orgnisé a cette période
                    string dejaLa = BL.SessionsSeancesTri.seanceDejaPresante(sea, seanceSes);


                    //verifie s'il les date de la seance sont comrises dans la session
                    string dateDansSession = BL.SessionsSeancesTri.seanceDansSession(sea, sessionCourante);
                    message =  dejaLa + dateDansSession;

                    if (message != "" )
                    {                        
                        MessageBox.Show(this, message, "Information ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                        //resetUc();
                    }
                    else
                    {
                        int enregistrerSes = DAL.AccesSeances.AjouterSeance(sea);
                        MessageBox.Show(this, "Enregistrement réussis", "Enregistrement", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                        //sea = recolterSeance();
                        if (OnEnregistrerClicked != null)
                        {
                            OnEnregistrerClicked();
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

        // Récolte une séance
        private Seance recolterSeance()
        {
            Seance ret = new Seance();

            ret.SeaDateDeb  = dtpDeb.Value.Date;
            ret.SeaDateFin  = dtpFin.Value.Date;
            ret.SeaJour     = cbJour.Text;
            ret.SeaCreneau  = cbCreneau.Text;
            ret.seaFKSes    = sessionCourante.SesId;

            return ret;
        }

        //Boutton ANNULER
        private void bAnnuler_Click(object sender, EventArgs e)
        {
            if (this.suprimSes == 1)
            {
                if (DAL.AccesSessions.SupressimerSES(sessionCourante.SesId))
                {
                    MessageBox.Show("La session complete va être supprimé, une séance est obligatoire pour la création d'une session.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Echec de la suppression de la session crée, vous avez une session sans séance.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            if (OnAnnulerClicked != null)
            {
                OnAnnulerClicked();
            }
        }       
        

        //Vérification avant de valider une séance
        public bool validation()
        {
            bool ret = true;

            if (dtpDeb.Value > dtpFin.Value)
            {
                ret = false;
            }

            return ret;
        }
        public void resetUc()
        {
            dtpDeb.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cbJour.SelectedIndex = 0;
            cbCreneau.SelectedIndex = 0;
        }

        
    }
}
