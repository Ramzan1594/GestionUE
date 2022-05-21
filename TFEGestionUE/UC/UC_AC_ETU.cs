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
using DAL;
using BL;

namespace TFEGestionUE.UC
{
    // délégués *********************************************************************************

    public partial class UC_AC_ETU : UserControl
    {
        //déclarations *************************************************************************** 
        private Personne etudiantCourant;
        private List<Ue> listUe, listUeEnCour;
        private Ue dgvAccessibleUeSelected, dgvUeEnCourCourante;
        private int sectionCourant;
        private int NbrReussite = 0,
                    NbrRestante = 0,
                    ligneDgvAcces, ligneDgvUeEnCour;
        private decimal PourcentageDet = 0.0m,
                        Pourcentage = 0.0m;

        public UC_AC_ETU()
        {
            InitializeComponent();
            etudiantCourant = null;
        }



        //***************************************************************************OBSERVATEUR
        //observateur qui vérifie si un étudiant a été séléctionné
        public void etuChoisis(Personne etudiant, int sectionCourante)
        {
            // récupérer l'étudiant pour le btInscrire
            this.etudiantCourant = etudiant;

            // indexe de la dgv des UE ACCESSIBLE
            this.ligneDgvAcces = -1;
            this.sectionCourant = etudiant.PersonneidSection;

            //Liste pour charger les UE selon les différentes characteristique  avec les UE REUSSIS RESTANT ENCOUR
            this.listUe = BL.ChargerTrierUe.chargerUE_TOTAL(etudiant.PersonneId,  etudiant.PersonneidSection, ref NbrReussite, ref NbrRestante, ref PourcentageDet, ref Pourcentage);

            //remplir les TextBox en dessous
            this.tbReussies.Clear();
            this.tbRestantes.Clear(); // (listUe.Count - ueReussis.Count).ToString();
            this.tbPourcentageDet.Clear();
            this.tbPourcentage.Clear();

            this.tbReussies.Text = this.NbrReussite.ToString();
            this.tbRestantes.Text = this.NbrRestante.ToString(); // (listUe.Count - ueReussis.Count).ToString();
            this.tbPourcentageDet.Text = this.PourcentageDet.ToString("00.00");
            this.tbPourcentage.Text = this.Pourcentage.ToString("00.00");

            //Remplire les Data Grid View
            if (this.listUe.Count > 0)
            {
                this.dgvUe.Visible = true;
                this.dgvUe.DataSource = listUe;
                this.listUeEnCour = BL.ChargerTrierUe.chargerSessionEnCours(listUe);
                this.dgvSesCour.DataSource = BL.ChargerTrierUe.chargerSessionEnCours(listUe);     //  SESSIONS en cours cad auquel l 'etudiant participe
                this.dgvSesAcc.DataSource = BL.ChargerTrierUe.chargerSessionAccessible(etudiantCourant.PersonneId, sectionCourant);
            }
        }

        // Event quand on clique sur une session dans la dgvSession
        private void dgvSesCour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bSupSes.Enabled = true;
            bInscrire.Enabled = false;
            dgvUeEnCourCourante = (Ue)dgvSesCour.CurrentRow.DataBoundItem;
            ligneDgvUeEnCour = dgvSesCour.CurrentRow.Index;
        }

        // Quand on clique sur le boutton SUPPRIMER une session
        private void bSupSes_Click(object sender, EventArgs e)
        {
            if (etudiantCourant == null)
                MessageBox.Show("Veuillez Selectionner un étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (ligneDgvUeEnCour == -1)  // s'il n'y a aucune ue en cour
            {
                DialogResult result = MessageBox.Show(this, "Vous n'avez aucune ue en cour", "Attention",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
            }
            else
            {
                if (ligneDgvUeEnCour >= 0)
                {
                    DAL.AccesUe.DesinscrireDuneUe(this.etudiantCourant, this.dgvUeEnCourCourante.SES_ID);
                    this.etuChoisis(etudiantCourant, this.sectionCourant);
                }
            }
        }


        //Méthode qui récupère l'index selectionne dans la dgv des sessions accessible
        private void dgvSessAccesCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bInscrire.Enabled = true;
            bSupSes.Enabled = false;
            if (e.RowIndex >= 0 && e.RowIndex < dgvSesAcc.RowCount)// limite de sélection
            {
                DataGridViewRow indexSelected = this.dgvSesAcc.Rows[e.RowIndex];
                ligneDgvAcces = indexSelected.Index;
                this.dgvAccessibleUeSelected = (Ue)indexSelected.DataBoundItem;
            }
        }

        // Quand on clique sur INSCRIRE
        private void bInscrireClick(object sender, EventArgs e)
        {
            if(etudiantCourant == null)
                MessageBox.Show("Veuillez Selectionner un étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if(ligneDgvAcces == -1)  // s'il n'y a aucun session accessible
            {
                DialogResult result = MessageBox.Show(this, "Vous n'avez aucune session accessible", "Message d'erreur", 
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
            }
            else
            {
                if (ligneDgvAcces >= 0)
                {
                    if(BL.SessionsSeancesTri.etuDajaSeanceACettePeriode(this.etudiantCourant, this.dgvAccessibleUeSelected, listUeEnCour) != "")
                    {
                        string seanceChevauchement = BL.SessionsSeancesTri.etuDajaSeanceACettePeriode(this.etudiantCourant, this.dgvAccessibleUeSelected, listUeEnCour);
                        DialogResult dialogResult = MessageBox.Show("Cette etudiant participe a des session qui se déroule a la même période que \n"+ dgvAccessibleUeSelected.Intitule + "\n\n" + seanceChevauchement
                                                    + "\nVoulez vous quant même l'inscrire ?" , "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if(dialogResult == DialogResult.Yes)
                        {
                            DAL.AccesUe.InscrireALaSession(this.etudiantCourant, this.dgvAccessibleUeSelected.SES_ID);
                            this.etuChoisis(etudiantCourant, this.sectionCourant);
                        }
                    }
                    else
                    {
                        DAL.AccesUe.InscrireALaSession(this.etudiantCourant, this.dgvAccessibleUeSelected.SES_ID);
                        this.etuChoisis(etudiantCourant, this.sectionCourant);
                    }
                }
            }
        }


        public void emptyUcAc()
        {
            bsUe.Clear();
            etudiantCourant = null;
        }


    }
}
