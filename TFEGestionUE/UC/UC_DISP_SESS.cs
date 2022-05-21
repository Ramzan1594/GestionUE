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

    public partial class UC_DISP_SS : UserControl
    {
        // déclarations ****************************************************************
        private List<Session> listeSessions;
        private List<Seance> listeSeances;
        private Session sesCourante;
        private Seance seanceCourante;
        private Section sectionCourante;
        private int selectedSesId, selectedSeaId;

        //EVENT ******************************************************************************* 
        public event EnvoieUnParam OnSessionCellClicked;
        public event Selection OnSupprimerClicked; //pas de param


        public UC_DISP_SS()
        {
            InitializeComponent();
        }

        //OBSERVATEUR de cbSection dans SRCH_SESS  
        public void sectionSelectionne(Section sec)                  
        {
            sectionCourante = sec;
            listeSessions = null;
            listeSessions = DAL.AccesSessions.Charger_SES(sec.SecId);

            if(listeSessions.Count > 0)
                listeSeances = DAL.AccesSeances.Charger_SEA(listeSessions[0].SesId);
            if (listeSessions.Count == 0)
                listeSeances = null;


            dgvSesCour.DataSource   = listeSessions;
            dgvSea.DataSource       = listeSeances;
        }

        //Selection de session dans dgvSes
        private void DgvSessionCellClick(object sender, DataGridViewCellEventArgs e)
        {
            bSupSes.Enabled = true;
            sesCourante = (Session)dgvSesCour.CurrentRow.DataBoundItem;
            selectedSesId = sesCourante.SesId;

            listeSeances = DAL.AccesSeances.Charger_SEA(selectedSesId);
            dgvSea.DataSource = listeSeances;

            if (OnSessionCellClicked != null)
            {
                OnSessionCellClicked(sesCourante);
            }
        }

        //Boutton SUPPRMIER SESSION
        private void bSupSes_Click(object sender, EventArgs e)
        {
            bool suppressionValidee;

            if (sesCourante == null)
            {
                MessageBox.Show("Veuillez sélectionner une session", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int sesPAR = DAL.AccesPar.ChargerSESPAR(selectedSesId);
                int sesSEA = DAL.AccesSeances.Charger_SEA(selectedSesId).Count;
                string message = "";
                if(sesPAR > 0)
                    message += "\n\nATTENTION : DES ELEVES PARTICIPENT A CETTE SESSION\n\n";
                if (sesSEA > 0)
                    message += "\n\nAttention les séances relatives à cette session vont aussi être supprimées\n\n";

                DialogResult dialogResult = MessageBox.Show("Vous allez supprimer la session : \n" + sesCourante.Intitule + " du \n" + sesCourante.SesDeb.ToShortDateString()
                                            + message +"\nÊtes-vous sûr de vouloir continuer ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    suppressionValidee = true;
                }
                else //(dialogResult == DialogResult.No)
                {
                    suppressionValidee = false; //annulation de la suppression
                }

                // Suppression de la seance

                if (suppressionValidee) //suppression validée par l'utilisateur
                {
                    if (DAL.AccesSessions.SupressimerSES(selectedSesId))
                    {
                        MessageBox.Show("Suppression éffectuée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listeSessions = DAL.AccesSessions.Charger_SES(sectionCourante.SecId);
                        dgvSesCour.DataSource = listeSessions;
                    }
                    else
                    {
                        MessageBox.Show("Echec de la suppression.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if(listeSessions.Count == 0)
                        mettreAJourDgvSea(-1);
                    if (listeSessions.Count > 0)
                        mettreAJourDgvSea(listeSessions[0].SesId);
                }
            }
            if (OnSupprimerClicked != null)
            {
                OnSupprimerClicked();
            }
        }

        //OBSERVATEUR des boutton AJOUTER SEANCE SESSION dans SRCH_SES
        public void mettreAJourDgvSea(int sesId)
        {
            listeSeances = DAL.AccesSeances.Charger_SEA(sesId);
            dgvSea.DataSource = listeSeances;
        }

        //Selection de séance dans dgvSea
        private void dgvSea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bSupSea.Enabled = true;
            seanceCourante = (Seance)dgvSea.CurrentRow.DataBoundItem;
            selectedSeaId = seanceCourante.SeaId;
        }


        //Boutton SUPPRMIER SEANCE
        private void bSupSea_Click(object sender, EventArgs e)
        {
            bool suppressionValidee;

            if (seanceCourante == null)
            {
                MessageBox.Show("Veuillez Selectionner une séance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Vous allez supprimer la séance du "+ seanceCourante.SeaJour + " " + seanceCourante.SeaCreneau + " de  : "
                    + seanceCourante.Intitule + ". \n\nÊtes-vous sur de vouloir continuer ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    suppressionValidee = true;
                }
                else //(dialogResult == DialogResult.No)
                {
                    suppressionValidee = false; //annulation de la suppression
                }

                // Suppression de la seance

                if (suppressionValidee) //suppression validée par l'utilisateur
                {
                    if (DAL.AccesSeances.SupressimerSEA(selectedSeaId) > 0)
                    {
                        MessageBox.Show("Suppression éffectuée","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Echec de la suppression","Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    mettreAJourDgvSea(selectedSesId);
                }
            }
            if (OnSupprimerClicked != null)
            {
                OnSupprimerClicked();
            }
        }

        //function qui active ou desactive les Button supprimer 
        public void onoffButtonSupprimer(bool onoff)
        {
            bSupSes.Enabled = onoff;
            bSupSea.Enabled = onoff;
        }
    }
}
