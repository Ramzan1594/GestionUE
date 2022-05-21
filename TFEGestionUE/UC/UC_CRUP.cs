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
using UC;

namespace TFEGestionUE.UC
{
    // délégués -------------------------------------------------------
    public delegate void ModifAjoutTermine(int idEtudiant, int idSection);

    public partial class UC_CRUP : UserControl
    {
        // déclarations -----------------------------------------------
        public Personne etudiantAvantModif;
        private List<Nationalite> nationalites;
        private List<Localite> listeCP;
        private List<Section> sections;
        private Localite description;
        private bool modeModification;
        private string messageValidation;

        // évenements -------------------------------------------------
        public event ModifAjoutTermine OnModifAjoutTermine;

        public UC_CRUP()
        {
            InitializeComponent();
        }


        //OBSERVATEUR DE MODIFICATIONMethode qui affiche un etudiant
        public void afficheEtuModifAjout(Personne etudiantChoisi, Personne backupEtudiant, bool modification)  
        {
            modeModification = modification;
            bsPersonne.Clear();
            tbNaissance.CustomFormat = "dd/MM/yyyy";
                        

            if (modification)
            {
                // Backup des données de l'étudiant sélectionné
                this.etudiantAvantModif = backupEtudiant; //pointe vers le bckup créé
                bsPersonne.Add(etudiantChoisi);
            }
            else
            {
                cbSecEtu();
            }
            cbCpEtu(etudiantChoisi, modification);
            cbSexEtu(etudiantChoisi, modification);
            cbNatEtu(etudiantChoisi, modification);
        }

        //Méthode pour récolter un étudiant
        public Personne recolteNouvelEtudiant()
        {
            Personne retval = new Personne();
            if (this.tbBoite.Text == null) { }
            else
            { retval.PersonneBoîte = tbBoite.Text.Trim(); }

            retval.PersonneDateNaissance = tbNaissance.Value.Date;
            retval.PersonneGSM = tbGsm.Text.Trim();
            retval.PersonneidLocalite = Convert.ToInt32(cbLocalite.SelectedValue.ToString());
            retval.PersonneidNationalite = Convert.ToInt32(cbNationalite.SelectedValue.ToString());
            retval.PersonneidSection = Convert.ToInt32(cbSection.SelectedValue.ToString());
            retval.PersonneMail = tbMail.Text.Trim();
            retval.PersonneNom = tbNom.Text.Trim();
            retval.PersonneNumImm = tbImm.Text.Trim();
            retval.PersonnePrenom = tbPrenom.Text.Trim();
            retval.PersonneRue = tbRue.Text.Trim();
            retval.PersonneSexe = cbSexe.Text;
            retval.PersonneTel = tbTel.Text.Trim();
            retval.PersonneAdmin = (cbAdmin.Checked == true ? 1 : 0);

            return retval;
        }
        //Méthode qui récolte l'étudiant affiché
        public Personne recolteEtudiantAffiche()
        {
            Personne retval = (Personne)bsPersonne.Current; //récolte depuis le binding source
            int idNationailte = Convert.ToInt32(cbNationalite.SelectedValue.ToString());
            int idLocalite = Convert.ToInt32(cbLocalite.SelectedValue.ToString());
            retval.PersonneidNationalite = idNationailte;
            retval.PersonneidLocalite = idLocalite;
            return retval;
        }


        //Boutton ENREGISTRER    
        private void bEnregistrerClicked(object sender, EventArgs e)
        {
            if (this.validationEtudiant()) // vérification des données
            {
                if (this.modeModification)
                {
                    try
                    {
                        int etuId = etudiantAvantModif.PersonneId;
                        Personne etudiantEncode = recolteEtudiantAffiche();
                        Personne etudiantEnDB = DAL.AccesPersonnes.ChargerEtudiant(etuId);
                        if (DTO.Personne.sontEgaux(etudiantEnDB, etudiantAvantModif)) //acces concurrents?
                        {   //update de l'etudiant en db
                            MessageBox.Show(this, DAL.AccesPersonnes.ModifierPersonne(etudiantEncode), "Modification ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                        }
                        else
                        {
                            MessageBox.Show("Acces concurrent détecté!");
                        }
                        if (this.OnModifAjoutTermine != null)
                        { this.OnModifAjoutTermine(etudiantEncode.PersonneId, etudiantEncode.PersonneidSection); }
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
                    try
                    {
                        Personne nouvelEtudiant = recolteNouvelEtudiant();
                        string password = BL.Hashage.HashageMdp(newPassword());
                        nouvelEtudiant.PersonnePwd = password;
                        int idEtuEncode = DAL.AccesPersonnes.AjouterUnePersonne(nouvelEtudiant);

                        MessageBox.Show(this, "Enregistrement réussis", "Enregistrement ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);

                        if (this.OnModifAjoutTermine != null)
                        { this.OnModifAjoutTermine(idEtuEncode, nouvelEtudiant.PersonneidSection);}
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, ex.GetType().ToString());
                        string exMsg = EXCP.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                        MessageBox.Show(exMsg);
                    }
                }                
            }
            else //problème de validation
            {
                //MessageBox.Show("Erreur! vérifier les données encodées");

                //MessageBox.Show("Erreur ! Vérifier les données encodées", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                MessageBox.Show(this, "Erreur ! Vérifier les données encodées. \n\n" + messageValidation , "Attention",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
            }
        }
        //Création de MDP
        public string newPassword()
        {
            Guid g = new Guid();
            g = Guid.NewGuid();
            string retval = g.ToString();
            return retval;
        }

        //Boutton ANNULER
        private void bAnnulerClicked(object sender, EventArgs e)            
        {
            if (modeModification)
            {
                if (this.OnModifAjoutTermine != null)
                { this.OnModifAjoutTermine(etudiantAvantModif.PersonneId, etudiantAvantModif.PersonneidSection); }
            }
            else
            {
                if (this.OnModifAjoutTermine != null)
                { this.OnModifAjoutTermine(0, 0); }
            }

        }
        //reaction au changement de LOCALITE
        private void cbLocaliteChanged(object sender, EventArgs e)
        {
            string localite = cbLocalite.Text;
            description = DAL.AccesLocalite.ChargerCp(localite);
            tbCp.Text = description.LocaliteCodePostal;

        }

        // ComboBox Section
        public void cbSecEtu()
        {
            sections = DAL.AccesSections.ChargerSection();
            cbSection.DataSource = sections;
            cbSection.DisplayMember = "SecDescription";
            cbSection.ValueMember = "SecId";
            cbSection.SelectedValue = 0;
        }

        // ComboBox Sexe
        public void cbSexEtu(Personne etudiant, bool modification)
        {
            if(cbSexe.Items.Count < 2)
            {
                cbSexe.Items.Insert(0, "M");
                cbSexe.Items.Insert(1, "F");
            }
            if(modification) 
            {
                if (etudiant.PersonneSexe == "M")
                {
                    cbSexe.SelectedIndex = 0;
                }
                else
                {
                    cbSexe.SelectedIndex = 1;
                }
            }
        }

        // ComboBox Nationalité
        public void cbNatEtu(Personne etudiant, bool modification)
        {
            nationalites = DAL.AccesNationalite.ChargerNationalite();
            cbNationalite.DataSource = nationalites;
            cbNationalite.DisplayMember = "NAT_NOM";
            cbNationalite.ValueMember = "NAT_ID";

            if (modification)
            {
                int natId = etudiant.PersonneidNationalite;
                cbNationalite.SelectedValue = natId;
            }
            else
            { cbNationalite.SelectedValue = 0; } // a mofidfier pour BE une fois Pays encodé
        }


        // ComboBox CP
        public void cbCpEtu(Personne etudiant, bool modification)
        {
            listeCP = DAL.AccesLocalite.ChargerLocalites();
            cbLocalite.DataSource = listeCP;
            cbLocalite.DisplayMember = "LocaliteDescription";
            cbLocalite.ValueMember = "LocaliteId";
            cbLocalite.SelectedValue = 0;

            // remplissage du comboBox des codes postaux
            /*listeCP = DAL.AccesLocalite.ChargerLocalites();
            cbCp.DataSource = listeCP;
            cbCp.DisplayMember = "LocaliteCodePostal";
            cbCp.ValueMember = "LocaliteId";*/

            /*cbLocalite.DataSource = listeCP;     //*************************************************************
            cbLocalite.DisplayMember = "LocaliteDescription";
            cbLocalite.ValueMember = "LocaliteId";*/

            if (modification)
            {
                int cpId = etudiant.PersonneidLocalite;
                // affichage du code postal de l'étudiant choisi dans le comboBox
                cbLocalite.SelectedValue = cpId;
                // remplissage du textBox avec la localité correspondant au code postal de l'étudiant
                description = DAL.AccesLocalite.ChargerLocaliteTb(cpId);
                //tbLocalite.Text = description.LocaliteDescription;
                cbLocalite.Text = description.LocaliteDescription;

                /*cbLocalite.SelectedValue = cpId;              //*************************************************************
                loc = DAL.AccesLocalite.ChargerCp(cbLocalite.Text);
                tbCp.Text = loc.LocaliteCodePostal;*/
            }
            else
            {
                cbLocalite.SelectedValue = 0;
                tbCp.Text = " ";
            }
        }




        public void emptyUcCrup()
        {
            bsPersonne.Clear();
            tbNaissance.Value = DateTime.Now;
            //etudiantAvantModif = null;
        }


        //Vérification avant de valider un étudiant
        private bool validationEtudiant()
        {
            bool ret = true;
            messageValidation = "";           
            
            if (   Validateur.EstRempli(this.tbNom) != "" || Validateur.EstRempli(this.tbPrenom) != ""
                || Validateur.EstRempli(this.cbSexe) != "" || Validateur.EstRempli(this.cbNationalite) != ""
                || Validateur.EstRempli(this.tbRue) != "" || Validateur.EstRempli(this.tbImm) != ""
                || Validateur.EstRempli(this.tbBoite) != "" || Validateur.EstRempli(this.tbCp) != ""
                || Validateur.EstRempli(this.tbTel) != "" && Validateur.EstRempli(this.tbGsm) != "" 
                || Validateur.EstRempli(this.tbTel) != "" && Validateur.EstRempli(this.tbGsm) == "" && Validateur.EstUnNumeroDeTelephone(this.tbGsm) != ""
                || Validateur.EstRempli(this.tbTel) == "" && Validateur.EstRempli(this.tbGsm) != "" && Validateur.EstUnNumeroDeTelephone(this.tbTel) != ""
                || Validateur.EstRempli(this.tbMail) != "" || Validateur.EstRempli(this.tbNaissance) != ""
                || (!modeModification) && Validateur.EstRempli(cbSection) != ""
                || Validateur.EstAssezLong(this.tbNom, 2) != "" || Validateur.EstAssezLong(this.tbPrenom, 2) != ""
                || Validateur.EstUnEntier(this.tbImm) != ""
                || Validateur.EstunMail(this.tbMail) != "" || Validateur.EstUnedateDeNaissance(this.tbNaissance) != "")
            {
                messageValidation = messageValidation + Validateur.EstRempli(this.tbNom) + Validateur.EstAssezLong(this.tbNom, 2) 
                                    + Validateur.EstUnEntier(this.tbImm) 
                                    + (Validateur.EstRempli(this.tbGsm) == "" ? Validateur.EstUnNumeroDeTelephone(this.tbGsm) : Validateur.EstUnNumeroDeTelephone(this.tbTel))
                                    + Validateur.EstunMail(this.tbMail)  + Validateur.EstUnedateDeNaissance(this.tbNaissance);
                ret = false;
            }            

            return ret ;
        }

    }
}
