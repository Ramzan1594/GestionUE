using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace TFEGestionUE
{
    public partial class F_GestionEtudiant : Form
    {
        // Déclarations ***************************************************************************
        private Personne etuCourant;
        private TabPage tabControl2Copy;
        private Section sectionCourante;
        private Session sessionCourante;

        public F_GestionEtudiant()
        {
            InitializeComponent();
            tabControl2Copy = tabControl.TabPages[1];
        }

        //EVENT crée dans UC_SRCH  qui fait le lien entre UC_DRCH    DISP ET AC   pour remplir un etudiant et vérifié s'il y en a un séléctionné
        private void UC_SRCH_ETU_OnSelectedEtudiant(Personne etudiant)     //utilisation EVENT cree dans UC_SRCH
        {
            tabControl.Enabled = true;
            UC_DISP_ETU.etuchoisis(etudiant);               //on utilise l OBSERVATEUR de DISP vers SRCH
            UC_AC_ETU.etuChoisis(etudiant, UC_SRCH_ETU.sectionSelectionne());
            etuCourant = etudiant;
        }

        private void tabContolIndexChangeS(object sender, TabControlEventArgs e)
        {
            if (UC_CRUP_ETU.Visible == true || UC_CRUP_ATT.Visible == true || UC_CRUP_SESS.Visible == true || UC_CRUP_SEA.Visible == true || UC_DISP_SES.Visible == true)                
            {
                tabControl.TabPages.Remove(tabPage2);
            }
            if (tabControl.TabPages.Count < 2)
            {
                tabControl.TabPages.Add(tabControl2Copy);
            }   
            UC_SRCH_ETU.desactiverBAjouter(tabControl.SelectedIndex);

        }

        // Appuie sur le boutton AJOUTER dans UC_SRCH_ETU
        private void UC_SRCH_ETU_ONAJOUTER()
        {
            tabControl.Enabled  = true;
            toolStrip2.Enabled = false;
            bool Modification   = false;
            UC_SRCH_ETU.Enabled = false;
            UC_DISP_ETU.Visible = false;
            UC_CRUP_ETU.Visible = true;
            Personne etudiant   = null;           

            UC_CRUP_ETU.afficheEtuModifAjout(etudiant, etudiant, Modification);
        }

        // Appuie sur le boutton SUPPRIMER dans UC_DISP_ETU
        private void UC_DISP_ETU_ONSUPPRIMER_CLICK()   // OBSERVATEUR DE SUPPRESSION
        {
            UC_SRCH_ETU.Enabled = true;
            UC_SRCH_ETU.Visible = true;
            UC_CRUP_ETU.Visible = false;
            UC_DISP_ETU.emptyUcDisp();
            UC_CRUP_ETU.emptyUcCrup();
            UC_AC_ETU.emptyUcAc();
            UC_SRCH_ETU.rempliComboSection();
        }

        // Appuie sur le boutton MODIFIER dans UC_DISP_ETU
        private void UC_DISP_ETU_ONMODIFIER_CLICK(Personne etudiantCourant) 
        {
            bool Modification = true;
            UC_SRCH_ETU.Enabled = false;
            UC_DISP_ETU.Visible = false;
            UC_CRUP_ETU.Visible = true;
            toolStrip2.Enabled = false;
            Personne backupEtudiant = new Personne(etudiantCourant);
            UC_CRUP_ETU.afficheEtuModifAjout(etudiantCourant, backupEtudiant, Modification);  // OBSERVATEUR DE MODIFICATION
        }

        // Appuie sur le boutton ENREGISTRER/ANNULER dans UC_CRUP_ETU et cette methode MAJ DISP_ETU
        private void UC_CRUP_ETU_OnAjoutModif_CLICK(int idEtudiant, int idSection)
        {            
            UC_CRUP_ETU.emptyUcCrup();
            UC_DISP_ETU.emptyUcDisp();
            UC_AC_ETU.emptyUcAc();
            UC_SRCH_ETU.Enabled = true;
            UC_DISP_ETU.Visible = true;
            UC_CRUP_ETU.Visible = false;
            toolStrip2.Enabled = true;
            if (idEtudiant > 0)
            {
                UC_DISP_ETU.actualiseAffichage(idEtudiant);
                UC_SRCH_ETU.actualiseCbSectionDgvEtu(idEtudiant, idSection);
            }
        }

        // Appuie sur le boutton AJOUTER ATTESTE dans UC_DISP_ETU
        private void UC_DISP_ETU_ONATTEST_CLICK(Personne etudiantCourant)    
        {
            UC_CRUP_ATT.recupereIdPersonne(etudiantCourant);  // OBSERVATEUR D AJOUT D ATTESTATION

            UC_CRUP_ATT.emptyUC_CRUP_ATT();
            UC_CRUP_ATT.Visible = true;
            UC_SRCH_ETU.Enabled = false;
            toolStrip2.Enabled = false;
        }

        // Appuie sur le boutton ANNULER/ENREGISTRER dans UC_CRUP_ATT
        private void UC_CRUP_ATT_ONCLICKED(Personne etu, int idSection, int possedeAtt)
        {

            UC_CRUP_ATT.emptyUC_CRUP_ATT();
            toolStrip2.Enabled = true;
            UC_SRCH_ETU.Enabled = true; ;

            //appuie ENREGISTRER et ca marche (sans attest)
            if (etu != null && possedeAtt == 0)
            {
                UC_CRUP_ATT.Visible = false;
                UC_AC_ETU.etuChoisis(etu, idSection);
            }
            //appuis ANNULER
            if (etu == null)
            {
                UC_CRUP_ATT.Visible = false;
            }
        }

        //Boutton Gestion eleve
        private void GestionElevesClick(object sender, EventArgs e)
        {
            if(etuCourant == null)
                tabControl.Enabled = false;

            UC_SRCH_ETU.Visible = true;
            UC_SRCH_SES.Visible = false;

            UC_DISP_ETU.Visible = true;
            UC_DISP_SES.Visible = false;

            UC_CRUP_SESS.Visible = false;

            UC_SRCH_ETU.resetUc();
        }

        //Boutton Gestion session
        private void GestionSessionClick(object sender, EventArgs e)
        {
            tabControl.Enabled = true;

            UC_SRCH_ETU.Visible = false;
            UC_SRCH_SES.Visible = true;

            UC_DISP_ETU.Visible = false;
            UC_DISP_SES.Visible = true;

            tabControl.SelectedIndex = 0;
        }

        // Appuie sur AJOUTER SESSION dans UC_SRCH_SES
        private void UC_SRCH_SES_ONAJOUTERSESSION(object section)
        {
            tabControl.Enabled = true;
            UC_CRUP_SESS.Enabled = true;
            UC_CRUP_SEA.Enabled = false;
            
            UC_CRUP_SESS.Visible = true;
            UC_DISP_SES.Visible = false;
            UC_CRUP_SEA.Visible = true;

            UC_CRUP_SEA.Location = new Point(1, 397);

            toolStrip2.Enabled = false;
            UC_SRCH_SES.Enabled = false;
            UC_CRUP_SESS.recupereSection((Section)section);
        }

        // Appuie sur AJOUTER SEANCE dans UC_SRCH_SES    initialSes determine si l ajout de seance se fait suite a l'ajout d'une nouvelle session
        private void UC_SRCH_SES_ONAJOUTERSEANCE(object session, int initialSes = 0)
        {
            if (initialSes == 0)
            {
                //UC_CRUP_SEA.desactiverAnnuler(initialSes);
                UC_CRUP_SEA.Location = new Point(3, 3);
            }
            
            UC_CRUP_SEA.supprimerSesSea(initialSes);
            tabControl.Enabled = true;
            UC_CRUP_SEA.Visible = true;
            UC_DISP_SES.Visible = false;

            toolStrip2.Enabled = false;
            UC_SRCH_SES.Enabled = false;
            UC_CRUP_SEA.Enabled = true;

            UC_CRUP_SEA.obtenirSessionCourant((Session)session, sectionCourante);
            UC_CRUP_SEA.jourSemaineCreneau();
        }

        // Event quand une section est selectionnée
        private void UC_SRCH_SES_ONSECTIONSELECTIONNEE(object section)
        {
            UC_SRCH_SES.onoffButtonSeance(false);
            UC_DISP_SES.onoffButtonSupprimer(false);
            sectionCourante = (Section)section;
            UC_DISP_SES.sectionSelectionne((Section)section);
        }

        // Event quand on clique sur une ligne dans la DGVSESSION
        private void UC_DISP_SES_ONSESCLICKED(object session)
        {
            sessionCourante = (Session)session;
            UC_SRCH_SES.sessionCellSelectedInUC_DISP((Session)sessionCourante);            
        }

        // Appuie sur ANNULER dans UC_CRUP_SES
        private void UC_CRUP_SES_ONANNULER()
        {
            UC_CRUP_SESS.Visible = false;
            UC_CRUP_SEA.Visible = false;
            UC_DISP_SES.Visible = true;

            toolStrip2.Enabled = true;
            UC_SRCH_SES.Enabled = true;

            UC_SRCH_SES.onoffButtonSeance(false);
            UC_CRUP_SESS.resetUc();
        }

        // Appuie sur ENREGISTRER dans UC_CRUP_SES
        private void UC_CRUP_SES_ONAENREGISTRER(Object session)
        {
            sessionCourante = (Session)session;
            //UC_CRUP_SESS.Visible = false;
            UC_CRUP_SESS.Enabled = false;
            UC_DISP_SES.Visible = true;

            toolStrip2.Enabled = true;
            UC_SRCH_SES.Enabled = true;

            UC_DISP_SES.sectionSelectionne(sectionCourante);

            UC_SRCH_SES.onoffButtonSeance(false);
            //UC_CRUP_SESS.resetUc();
            Session ses = (Session)session;
            //condition pour les stage qui n'ont pas de seance
            if (ses.SesFkUe != 30 && ses.SesFkUe != 34
                && ses.SesFkUe != 39 && ses.SesFkUe != 24 && ses.SesFkUe != 25)
            {
                //on active la seance apres avoir fait la session
                UC_CRUP_SEA.Enabled = true;

                UC_SRCH_SES_ONAJOUTERSEANCE(session, 1);
            }else
            {
                UC_CRUP_SEA.Visible = false;
            }

        }

        // Appuie sur ANNULER dans UC_CRUP_SEA
        private void UC_CRUP_SEA_ONANNULER()
        {
            UC_CRUP_SEA.Visible = false;
            UC_DISP_SES.Visible = true;

            toolStrip2.Enabled = true;
            UC_SRCH_SES.Enabled = true;

            UC_CRUP_SEA.Enabled = true;
            UC_CRUP_SESS.Enabled = true;

            UC_DISP_SES.sectionSelectionne(sectionCourante);

            UC_SRCH_SES.onoffButtonSeance(false);
            UC_CRUP_SEA.resetUc();
        }

        // Appuie sur ENREGISTRER dans UC_CRUP_SEA
        private void UC_CRUP_SEA_ONENREGISTRER()
        {
            UC_CRUP_SEA.Visible = false;
            UC_DISP_SES.Visible = true;

            toolStrip2.Enabled = true;
            UC_SRCH_SES.Enabled = true;

            UC_DISP_SES.sectionSelectionne(sectionCourante);
            UC_DISP_SES.mettreAJourDgvSea(sessionCourante.SesId);

            UC_CRUP_SEA.Enabled = true;
            UC_CRUP_SESS.Enabled = true;

            UC_SRCH_SES.onoffButtonSeance(false);
            UC_CRUP_SEA.resetUc();
            UC_CRUP_SESS.resetUc();
        }

        //Quand on change la section, UC_DISP_ETU prend la premiere personne de la liste dgvEtu
        private void UC_SRCH_ETU_OnSelectedSection()
        {
            if (UC_DISP_ETU.Enabled)
            {
                Personne dgvEtuFirst = UC_SRCH_ETU.getFirstEtuListe();
                UC_DISP_ETU.etuchoisis(dgvEtuFirst);               //on utilise l OBSERVATEUR de DISP vers SRCH
                UC_AC_ETU.etuChoisis(dgvEtuFirst, UC_SRCH_ETU.sectionSelectionne());
                etuCourant = dgvEtuFirst;
            }
        }

        //quand on appuie sur le button supprimer dans DISP_SES
        private void UC_DISP_SES_ONSUPPRIMERCLICKED()
        {
            UC_SRCH_SES.onoffButtonSeance(false);
        }
    }
}
