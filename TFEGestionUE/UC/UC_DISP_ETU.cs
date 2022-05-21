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
    // délégués
    public delegate void ModifierEtudiant(Personne etudiantCourant);    //   DELEGATE POUR  PASSAGE DE L OBJET ETUDIANT
    public delegate void SuppressionTerminee();

    public partial class UC_DISP_ETU : UserControl
    {
        // déclarations ***************************************************************************
        private Personne etudiantCourant;
        private bool suppressionValidee = false;

        // évenements -------------------------------------------------
        public event ModifierEtudiant OnAttestationClicked;         //   EVENT POUR LE PASSAGE DE L OBJET ETU
        public event ModifierEtudiant OnModifierEtudiantClicked;                
        public event SuppressionTerminee OnSupprimerEtuClicked;

        public UC_DISP_ETU()
        {
            InitializeComponent();
            emptyPicker();
        }

        // OBSERVATEUR pour obtenir l'étudiant courant quand on clique sur un ETUDIANT dans SRCH_ETU
        public void etuchoisis(Personne etudiant) // étudiant choisit dans UC_SRCH  
        {
            bModifier.Enabled  = true;
            bSupprimer.Enabled = true;
            bAttestation.Enabled = true;
            if (etudiant.PersonneAdmin == 1)
                cbAdminDisp.Checked = true;
            tbNai.CustomFormat = "dd/MM/yyyy";
            // rempli les textBoxs -> binding
            bsPersonne.Clear();
            bsPersonne.Add(etudiant);
            // backup de l'étudiant avant modif pour test accès concurrents
            etudiantCourant = etudiant;
        }

        //OBSERVATEUR pour actualise l'étudiant affiché
        public void actualiseAffichage(int idEtudiant) // étudiant choisit dans UC_SRCH
        {
            Personne etudiant = DAL.AccesPersonnes.ChargerEtudiant(idEtudiant);
            tbNai.CustomFormat = "dd/MM/yyyy";
            // rempli les textBoxs -> binding
            bsPersonne.Clear();
            bsPersonne.Add(etudiant);
            // backup de l'étudiant avant modif pour test accès concurrents
            etudiantCourant = etudiant;
        }

        //Boutton ATTESTATION
        private void bAttestationClick(object sender, EventArgs e)
        {
            try
            {
                if (etudiantCourant == null)
                {
                    MessageBox.Show("Veuillez sélectionner un étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (this.OnAttestationClicked != null)
                    {
                        this.OnAttestationClicked(etudiantCourant);            // DECLENCHEUR de ATTESTATION
                    }
                }
            }
            catch (Exception ex)
            {
                string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                MessageBox.Show(exMsg);
            }
        }

        //Boutton MODIFIER
        private void bModifierClick(object sender, EventArgs e)
        {
            try
            {
                if (etudiantCourant == null)
                {
                    MessageBox.Show("Veuillez sélectionner un étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (this.OnModifierEtudiantClicked != null)
                    {
                        this.OnModifierEtudiantClicked(etudiantCourant);            // DECLENCHEUR de MODIFICATION
                    }
                }
            }
            catch(Exception ex)
            {
                string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                MessageBox.Show(exMsg);
            }            
        }


        //Boutton SUPPRIMER
        private void bSupprimerClick(object sender, EventArgs e)
        {
            if (etudiantCourant == null) //si pas d'étudiant sélectionné
            {
                MessageBox.Show("Veuillez sélectionner un étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int sId = etudiantCourant.PersonneId;
                try
                {
                    // L'étudiant sélectionné est-il inscrit a des sessions en cours? si oui combien?
                    int sessionEnCour = DAL.AccesSessions.EstInscritASessionEnCour(sId);
                    // L'étudiant a-t-il ds attestations vieilles de moins de 5 ans? si oui combien?
                    int attesRecentes = DAL.AccesAttestations.AttDeMoinsDe5AnsPossedees(sId);

                    // Si c'est le cas, On demande confiramtion à l'utilisateur !
                    if (sessionEnCour > 0 || attesRecentes > 0)
                    {
                        string message = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair("PPHY_SES_ATT");
                        DialogResult dialogResult = MessageBox.Show(message, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            suppressionValidee = true;
                        }
                        else //(dialogResult == DialogResult.No)
                        {
                            suppressionValidee = false; //annulation de la suppression
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir continuer ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            suppressionValidee = true;
                        }
                        else //(dialogResult == DialogResult.No)
                        {
                            suppressionValidee = false; //annulation de la suppression
                        }

                        //suppressionValidee = true;
                    }
                }
                catch(Exception ex)
                {
                    string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                    MessageBox.Show(exMsg);
                }
                

                // Suppression de l'étudiant
                if (suppressionValidee) //suppression validée par l'utilisateur
                {
                    if (DAL.AccesPersonnes.SupressionEtudiant(sId))
                    {
                        MessageBox.Show("Suppression éffectuée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Echec de la suppression.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (this.OnSupprimerEtuClicked != null)
                { this.OnSupprimerEtuClicked(); }
            }
        }

        public void emptyUcDisp()
        {
            bsPersonne.Clear();
            emptyPicker();
            etudiantCourant = null;

        }
        
        public void emptyPicker()
        {
            tbNai.Format = DateTimePickerFormat.Custom;
            tbNai.CustomFormat = "    ";
        }
    }
}
