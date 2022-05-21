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
using UC;

namespace TFEGestionUE.UC
{
    // délégués ***********************************************************************
    public delegate void SelectionSectionATT();   // cree le delegate pour qu on puissent reference une methode dans la meme/autres classe
    public delegate void Finir(Personne etuCourant, int secCourante, int possedeAtt);                 //DELEGATE A

    public partial class UC_CRUP_ATT : UserControl
    {
        // déclarations ***************************************************************************
        Personne personneCourante;
        private List<Section> listeSections;
        private List<Ue> listeUe;
        private Ue ueCourante;
        private Attestation attestation;
        private int idSectionCourante, idPersonneCourante;
        private string messageValidation;



        //EVENT *******************************************************************************
        public event SelectionSectionATT OnSelectedSection;      //on cree l EVENT pour que la classe soit OBSEVABLE
        public event Finir OnClicked;        //EVENT A

        public UC_CRUP_ATT()
        {            
            InitializeComponent();
            rempliComboSection();
            //rempliComboUe();
        }

        //  CREATION DE L OBSERVATEUR pour recupérer l'étudiant quand on clique sur AJOUTER ATTEST
        public void recupereIdPersonne(Personne etu)      
        {
            personneCourante = etu;
            idPersonneCourante = personneCourante.PersonneId;
        }

        // ComboBox Section
        public void rempliComboSection() // Rempli le combobox avec les sections de la DB
        {
            this.listeSections = DAL.AccesSections.ChargerSection();            
            if (this.listeSections.Count > 0)
            {
                this.cbSection.DataSource = listeSections;                
            }
        }

        // ComboBox Ue
        public void rempliComboUe() // Rempli le combobox avec les sections de la DB
        {
            if (this.listeSections.Count > 0)
            {
                this.listeUe = DAL.AccesUe.Charger_UE(listeSections[0].SecId);
                bsUe.DataSource = this.listeUe;
            }
            
        }

        // Selection ComboBox Section
        private void cbSectionOnSelectedIndexChange(object sender, EventArgs e)   
        {
            Section sec = (Section)cbSection.SelectedItem;

            this.bsUe.DataSource = null;          // reinitialise la cbUe

            idSectionCourante = sec.SecId;
            this.listeUe = BL.ChargerTrierUe.chargerUePourAttestation(idPersonneCourante, idSectionCourante);
            

            if (this.listeUe.Count > 0)
            {                
                this.bsUe.DataSource = listeUe;     //DECLENCHEUR 
            }
            if (this.OnSelectedSection != null)     //DECLENCHEUR               
            {
                this.OnSelectedSection();
            }
            
        }




        // Boutton ENREGISTRER
        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.validation())
            {
                try
                {
                    attestation = recolterAttestation();
                    int possedeAtt = DAL.AccesAttestations.AttPossedeesPourUe(idPersonneCourante, ueCourante.UeId);
                    if(possedeAtt > 0)
                    {
                        MessageBox.Show(this, "Cette étudiant possède déjà une attestation pour la ue : " + ueCourante.Intitule + ". ","Information ",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                    }
                    else
                    {                        
                        int idAttestEncode = DAL.AccesAttestations.AjouterAttestation(attestation);
                        MessageBox.Show(this, "Enregistrement réussis", "Enregistrement ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                    }
                   
                    if (this.OnClicked != null)
                    { this.OnClicked(personneCourante, idSectionCourante, possedeAtt); }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, ex.GetType().ToString());
                    string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                    MessageBox.Show(exMsg);
                }                
            }
            else //problème de validation
            {
                //MessageBox.Show("Erreur! vérifier les données encodées");

                //MessageBox.Show("Erreur ! Vérifier les données encodées", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                MessageBox.Show(this, "Erreur ! Vérifier les données encodées. \n\n" + messageValidation, "Attention",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
            }
        }

        // Boutton ANNULER
        private void bAnnuler_Click(object sender, EventArgs e)
        {
            if (this.OnClicked != null)     //   DECLENCHEUR A
            { this.OnClicked(null, 0, 0); }
        }



        // Recolte l'attestation affichée
        public Attestation recolterAttestation()
        {
            Attestation ret = new Attestation();

            ret.Point = float.Parse(tbResultat.Text.Trim());
            ret.Description = tbDescription.Text.Trim();
            ret.AttestationDate = dtpDate.Value.Date;
            ret.ObtentionNormale = (cbNormale.Checked == true ? 1 : 0);

            Ue ue = new Ue();
            ue = (Ue)cbUe.SelectedItem;

            ret.attFkIdUe = ue.UeId;
            ueCourante = ue;
            ret.attFkIdPersonne = idPersonneCourante;

            return ret;
        }

        //Vérification avant de valider une attestation
        private bool validation()
        {
            bool ret = true;
            messageValidation = "";

            if(     Validateur.EstRempli(this.tbResultat) != "" ||  Validateur.EstRempli(this.cbSection) != ""
                ||  Validateur.EstRempli(this.cbUe) != ""       ||  Validateur.EstUnDecimal(this.tbResultat) != "" 
                ||  Validateur.EstRempli(this.tbDescription) != "" ||  Validateur.EstRempli(this.dtpDate) != ""
                ||  Validateur.EstUneDateAttestation(this.dtpDate) != "")
            {                
                ret = false;
                messageValidation = messageValidation 
                                + Validateur.EstRempli(this.tbResultat) 
                                + Validateur.EstUnDecimal(this.tbResultat) 
                                + Validateur.EstUneDateAttestation(this.dtpDate);
            }

            return ret;
        }

        public void emptyUC_CRUP_ATT()
        {
            bsSection.Clear();
            bsUe.Clear();            
            dtpDate.Value = DateTime.Now;
            tbResultat.Clear();
            tbDescription.Clear();

            cbSection.SelectedIndex = personneCourante.PersonneidSection - 1;
        }




       



    }
}
