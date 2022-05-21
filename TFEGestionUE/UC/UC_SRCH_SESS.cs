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
    public delegate void Selection();   // DELEGATE   A
    public delegate void EnvoieUnParam(object secUe);  //C
    public delegate void EnvoieDeuxParam(object secUe, int initialSes = 0);  //C initialSes determine si l ajout de seance se fait suite a l'ajout d'une nouvelle session

    public partial class UC_SRCH_SESS : UserControl
    {
        // déclarations ***************************************************************************
        private List<Section> listeSections;
        private Section sectionCourante;
        private Session sessionCourante;
        //private List<Ue> listeUe;


        //EVENT *******************************************************************************        
        public event EnvoieUnParam OnAjouterSession; // EVENT A
        public event EnvoieDeuxParam OnAjouterSeance; // EVENT B
        public event EnvoieUnParam OnSectionSelected;     //  C

        public UC_SRCH_SESS()
        {
            InitializeComponent();
            rempliComboSection();
        }

        //ComboBox section
        public void rempliComboSection() // Rempli le combobox avec les sections de la DB
        {
            this.listeSections = DAL.AccesSections.ChargerSection();
            if (this.listeSections.Count > 0)
            {
                this.cbSection.DataSource = listeSections;
            }
        }

        //Selection section
        private void SectionIndexChange(object sender, EventArgs e)
        {
            sectionCourante = (Section)cbSection.SelectedItem;

            if(OnSectionSelected != null)
            {
                bSession.Enabled = true;
                OnSectionSelected(sectionCourante);
            }

        }

        //Boutton AJOUTER SESSION
        private void bAjouterSession(object sender, EventArgs e)
        {
            //sectionCourante = (Section)cbSection.SelectedItem;

            if (OnAjouterSession != null)
            {
                OnAjouterSession(sectionCourante);                 //DECLENCHEUR A
            }                
        }

        //Boutton AJOUTER SEANCE
        private void bAjouterSeance_Click(object sender, EventArgs e)
        {
            if (OnAjouterSeance != null)
            {
                OnAjouterSeance(sessionCourante, 0);                 //DECLENCHEUR B
            }
        }

        //OBSERVATEUR de dgvSes pour activer le boutton AJOUTER SEANCE et en meme temp récupérer la session dans DISP_SES
        public void sessionCellSelectedInUC_DISP(Session session)  
        {
            sessionCourante = session;
            bSeance.Enabled = true;
        }
                
        public void onoffButtonSeance(bool onoff)
        {
            bSeance.Enabled = onoff;
        }

        public void resetUc()
        {
            cbSection.SelectedIndex = 0;
            bSeance.Enabled = false;
            //bsSection.Clear();
            //bsUe.Clear();
        }
    }
}
