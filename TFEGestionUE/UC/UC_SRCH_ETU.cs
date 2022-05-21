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


namespace TFEGestionUE.UC
{
    // délégués ***********************************************************************
    public delegate void SelectionSection(); // cree le deleguer pour pouvoir referencer une methode d'une autre classe (si on a un autre observateur)
    public delegate void SelectionEtudiant(Personne etudiant);
    public delegate void AjouterEtudiant();

    public partial class UC_SRCH_ETU : UserControl
    {
        // déclarations ****************************************************************
        private List<Section> listeSections;
        private List<Personne> listeEtudiant;
        private Personne EtudiantCourant;
        public int EtuId;
        String SectionCourante;

        // évènements
        public event SelectionSection OnSelectedSection;      
        public event SelectionEtudiant OnSelectedEtudiant;
        public event AjouterEtudiant OnAjoutEtudiantClicked;

        public UC_SRCH_ETU()
        {
            InitializeComponent();
            rempliComboSection();    //remplir le combobox au lancement
        }

        //ComboBox Section
        public void rempliComboSection() // Rempli le combobox avec les sections de la DB
        {
            this.listeSections = DAL.AccesSections.ChargerSection();
            if (this.listeSections.Count > 0)
            {
                this.cbSection.DataSource = listeSections;
            }
        }

        //OBSERVATEUR pour actualise dgvEtu et cbSection apres avoir Modifier un ETU
        public void actualiseCbSectionDgvEtu(int idEtu, int idSection) // étudiant choisit dans UC_SRCH
        {
            this.cbSection.SelectedValue = idSection;

            this.dgvPersonne.DataSource = null;
            Section SecSelect = (Section)cbSection.SelectedItem;
            String Stemp = SecSelect.SecId.ToString();
            this.listeEtudiant = DAL.AccesPersonnes.ChargerListeEtuSection(Stemp);
            if (this.listeEtudiant.Count > 0)
            {
                this.dgvPersonne.Visible = true;
                this.dgvPersonne.DataSource = listeEtudiant;
            }
            if (this.OnSelectedSection != null)
            {
                this.OnSelectedSection();
            }
            this.EtudiantCourant = DAL.AccesPersonnes.ChargerEtudiant(idEtu);
            if (this.OnSelectedEtudiant != null)
            {
                this.OnSelectedEtudiant(this.EtudiantCourant);
            }
        }

        //Bouton Recherche pour recherche un etudiant specifique
        private void bTrouver_Click(object sender, EventArgs e)
        {
            if(tbNom.Text != "" || tbPrenom.Text != "")
            {
                string nom = "", prenom = "";
                if (tbNom.Text != "")
                    nom = tbNom.Text.Substring(0, 1).ToUpper() + tbNom.Text.Substring(1).ToLower();
                if(tbPrenom.Text != "")
                    prenom = tbPrenom.Text.Substring(0, 1).ToUpper() + tbPrenom.Text.Substring(1).ToLower();

                this.listeEtudiant = null;
                this.listeEtudiant = DAL.AccesPersonnes.ChargerPersonneNomPrenom(nom, prenom);

                if (this.listeEtudiant.Count > 0)
                {
                    this.dgvPersonne.Visible = true;
                    this.dgvPersonne.DataSource = listeEtudiant;
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé sous : " + nom + " " + prenom +".", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                    tbNom.Text = "";  tbPrenom.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les deux cases Nom/Prénom pour faire une recherche.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                if (tbNom.Text == "")
                    tbNom.Focus();
                else
                    tbPrenom.Focus();
            }
        }

        //DECLENCHEUR   ET  OBSERVATEUR car il s observe lui meme ( la dgv observateur de la combobox 
        //Selection de la section dans cbSection
        private void cbSectionSelectedIndexChanged(object sender, EventArgs e)
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            this.dgvPersonne.DataSource = null;
            Section SecSelect = (Section)cbSection.SelectedItem;
            SectionCourante = SecSelect.SecId.ToString();
            this.listeEtudiant = DAL.AccesPersonnes.ChargerListeEtuSection(SectionCourante);
            if (this.listeEtudiant.Count > 0)
            {
                this.dgvPersonne.Visible = true;
                this.dgvPersonne.DataSource = listeEtudiant;
            }
            if (this.OnSelectedSection != null)                    //DECLENCHEUR
            {
                this.OnSelectedSection();
            }
        }

        
        //Selection etu dans dgvPersonne
        private void dgvListePersonneCellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            int currentRow = dgvPersonne.CurrentRow.Index;       // on a la ligne selectionné
            EtuId = Convert.ToInt32(dgvPersonne[0, currentRow].Value); // on a l id de la personne

            this.EtudiantCourant = DAL.AccesPersonnes.ChargerEtudiant(EtuId);

            if (this.OnSelectedEtudiant != null)                                //  DECLENCHEUR   
            {
                this.OnSelectedEtudiant(this.EtudiantCourant);
            }
        }


        //OBSERVATEUR pour obtenir la sectionSelectionnée
        public int sectionSelectionne()
        {
            int retval = Convert.ToInt32(SectionCourante);
            return retval;
        }
        //Function qui retourne la premiere personne de la liste etu d'une section
        public Personne getFirstEtuListe()
        {
            Personne personne = DAL.AccesPersonnes.ChargerEtudiant(listeEtudiant[0].PersonneId);
            return personne;
        }

        //OBSERVATEUR de tabControl.Page0et1 pour desactiver/activer BAJOUTER 
        public void desactiverBAjouter(int active)
        {
            if(active == 1)
                bAjouter.Enabled = false;
            else
                bAjouter.Enabled = true;
        }

        //Boutton AJOUTER
        private void bAjouterClick(object sender, EventArgs e)
        {
            if (OnAjoutEtudiantClicked != null)
            {
                this.OnAjoutEtudiantClicked();
            }
        }
        

        public void resetUc()
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            cbSection.SelectedIndex = 0;
            dgvPersonne.DataSource = DAL.AccesPersonnes.ChargerListeEtuSection(SectionCourante);  
        }

    }
}
