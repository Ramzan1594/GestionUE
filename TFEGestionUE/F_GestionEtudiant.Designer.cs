namespace TFEGestionUE
{
    partial class F_GestionEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestionEtudiant));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bGestionEleve = new System.Windows.Forms.ToolStripButton();
            this.bGestionSession = new System.Windows.Forms.ToolStripButton();
            this.UC_SRCH_SES = new TFEGestionUE.UC.UC_SRCH_SESS();
            this.UC_SRCH_ETU = new TFEGestionUE.UC.UC_SRCH_ETU();
            this.UC_DISP_ETU = new TFEGestionUE.UC.UC_DISP_ETU();
            this.UC_CRUP_ETU = new TFEGestionUE.UC.UC_CRUP();
            this.UC_DISP_SES = new TFEGestionUE.UC.UC_DISP_SS();
            this.UC_CRUP_SESS = new TFEGestionUE.UC.UC_CRUP_SESS();
            this.UC_CRUP_ATT = new TFEGestionUE.UC.UC_CRUP_ATT();
            this.UC_CRUP_SEA = new TFEGestionUE.UC.UC_CRUP_SEA();
            this.UC_AC_ETU = new TFEGestionUE.UC.UC_AC_ETU();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Enabled = false;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(4, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1392, 1032);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabContolIndexChangeS);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.UC_CRUP_ATT);
            this.tabPage1.Controls.Add(this.UC_CRUP_SEA);
            this.tabPage1.Controls.Add(this.UC_DISP_ETU);
            this.tabPage1.Controls.Add(this.UC_CRUP_ETU);
            this.tabPage1.Controls.Add(this.UC_DISP_SES);
            this.tabPage1.Controls.Add(this.UC_CRUP_SESS);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1384, 1003);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Données générales";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.UC_AC_ETU);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1384, 1003);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Situation académique";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UC_SRCH_SES);
            this.splitContainer1.Panel1.Controls.Add(this.UC_SRCH_ETU);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1921, 1036);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGestionEleve,
            this.bGestionSession});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1921, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // bGestionEleve
            // 
            this.bGestionEleve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bGestionEleve.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGestionEleve.Image = ((System.Drawing.Image)(resources.GetObject("bGestionEleve.Image")));
            this.bGestionEleve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bGestionEleve.Name = "bGestionEleve";
            this.bGestionEleve.Size = new System.Drawing.Size(96, 22);
            this.bGestionEleve.Text = "Gestion élèves";
            this.bGestionEleve.Click += new System.EventHandler(this.GestionElevesClick);
            // 
            // bGestionSession
            // 
            this.bGestionSession.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bGestionSession.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGestionSession.Image = ((System.Drawing.Image)(resources.GetObject("bGestionSession.Image")));
            this.bGestionSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bGestionSession.Name = "bGestionSession";
            this.bGestionSession.Size = new System.Drawing.Size(109, 22);
            this.bGestionSession.Text = "Gestion sessions";
            this.bGestionSession.Click += new System.EventHandler(this.GestionSessionClick);
            // 
            // UC_SRCH_SES
            // 
            this.UC_SRCH_SES.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_SRCH_SES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_SRCH_SES.Location = new System.Drawing.Point(0, 0);
            this.UC_SRCH_SES.Name = "UC_SRCH_SES";
            this.UC_SRCH_SES.Size = new System.Drawing.Size(518, 1032);
            this.UC_SRCH_SES.TabIndex = 2;
            this.UC_SRCH_SES.Visible = false;
            this.UC_SRCH_SES.OnAjouterSession += new TFEGestionUE.UC.EnvoieUnParam(this.UC_SRCH_SES_ONAJOUTERSESSION);
            this.UC_SRCH_SES.OnAjouterSeance += new TFEGestionUE.UC.EnvoieDeuxParam(this.UC_SRCH_SES_ONAJOUTERSEANCE);
            this.UC_SRCH_SES.OnSectionSelected += new TFEGestionUE.UC.EnvoieUnParam(this.UC_SRCH_SES_ONSECTIONSELECTIONNEE);
            // 
            // UC_SRCH_ETU
            // 
            this.UC_SRCH_ETU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_SRCH_ETU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_SRCH_ETU.Location = new System.Drawing.Point(0, 0);
            this.UC_SRCH_ETU.Name = "UC_SRCH_ETU";
            this.UC_SRCH_ETU.Size = new System.Drawing.Size(518, 1032);
            this.UC_SRCH_ETU.TabIndex = 0;
            this.UC_SRCH_ETU.OnSelectedSection += new TFEGestionUE.UC.SelectionSection(this.UC_SRCH_ETU_OnSelectedSection);
            this.UC_SRCH_ETU.OnSelectedEtudiant += new TFEGestionUE.UC.SelectionEtudiant(this.UC_SRCH_ETU_OnSelectedEtudiant);
            this.UC_SRCH_ETU.OnAjoutEtudiantClicked += new TFEGestionUE.UC.AjouterEtudiant(this.UC_SRCH_ETU_ONAJOUTER);
            // 
            // UC_DISP_ETU
            // 
            this.UC_DISP_ETU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_DISP_ETU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DISP_ETU.Location = new System.Drawing.Point(3, 3);
            this.UC_DISP_ETU.Name = "UC_DISP_ETU";
            this.UC_DISP_ETU.Size = new System.Drawing.Size(1378, 997);
            this.UC_DISP_ETU.TabIndex = 0;
            this.UC_DISP_ETU.OnAttestationClicked += new TFEGestionUE.UC.ModifierEtudiant(this.UC_DISP_ETU_ONATTEST_CLICK);
            this.UC_DISP_ETU.OnModifierEtudiantClicked += new TFEGestionUE.UC.ModifierEtudiant(this.UC_DISP_ETU_ONMODIFIER_CLICK);
            this.UC_DISP_ETU.OnSupprimerEtuClicked += new TFEGestionUE.UC.SuppressionTerminee(this.UC_DISP_ETU_ONSUPPRIMER_CLICK);
            // 
            // UC_CRUP_ETU
            // 
            this.UC_CRUP_ETU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_CRUP_ETU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_CRUP_ETU.Location = new System.Drawing.Point(3, 3);
            this.UC_CRUP_ETU.Name = "UC_CRUP_ETU";
            this.UC_CRUP_ETU.Size = new System.Drawing.Size(1378, 997);
            this.UC_CRUP_ETU.TabIndex = 1;
            this.UC_CRUP_ETU.Visible = false;
            this.UC_CRUP_ETU.OnModifAjoutTermine += new TFEGestionUE.UC.ModifAjoutTermine(this.UC_CRUP_ETU_OnAjoutModif_CLICK);
            // 
            // UC_DISP_SES
            // 
            this.UC_DISP_SES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DISP_SES.Location = new System.Drawing.Point(3, 3);
            this.UC_DISP_SES.Name = "UC_DISP_SES";
            this.UC_DISP_SES.Size = new System.Drawing.Size(1378, 997);
            this.UC_DISP_SES.TabIndex = 3;
            this.UC_DISP_SES.Visible = false;
            this.UC_DISP_SES.OnSessionCellClicked += new TFEGestionUE.UC.EnvoieUnParam(this.UC_DISP_SES_ONSESCLICKED);
            this.UC_DISP_SES.OnSupprimerClicked += new TFEGestionUE.UC.Selection(this.UC_DISP_SES_ONSUPPRIMERCLICKED);
            // 
            // UC_CRUP_SESS
            // 
            this.UC_CRUP_SESS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_CRUP_SESS.Location = new System.Drawing.Point(3, 3);
            this.UC_CRUP_SESS.Name = "UC_CRUP_SESS";
            this.UC_CRUP_SESS.Size = new System.Drawing.Size(1378, 997);
            this.UC_CRUP_SESS.TabIndex = 3;
            this.UC_CRUP_SESS.Visible = false;
            this.UC_CRUP_SESS.OnAnnulerClicked += new TFEGestionUE.UC.Selection(this.UC_CRUP_SES_ONANNULER);
            this.UC_CRUP_SESS.OnEnregistrerClicked += new TFEGestionUE.UC.EnvoieUnParam(this.UC_CRUP_SES_ONAENREGISTRER);
            // 
            // UC_CRUP_ATT
            // 
            this.UC_CRUP_ATT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_CRUP_ATT.Location = new System.Drawing.Point(3, 3);
            this.UC_CRUP_ATT.Name = "UC_CRUP_ATT";
            this.UC_CRUP_ATT.Size = new System.Drawing.Size(1378, 997);
            this.UC_CRUP_ATT.TabIndex = 2;
            this.UC_CRUP_ATT.Visible = false;
            this.UC_CRUP_ATT.OnClicked += new TFEGestionUE.UC.Finir(this.UC_CRUP_ATT_ONCLICKED);
            // 
            // UC_CRUP_SEA
            // 
            this.UC_CRUP_SEA.Location = new System.Drawing.Point(1, 397);
            this.UC_CRUP_SEA.Name = "UC_CRUP_SEA";
            this.UC_CRUP_SEA.Size = new System.Drawing.Size(1378, 595);
            this.UC_CRUP_SEA.TabIndex = 5;
            this.UC_CRUP_SEA.Visible = false;
            this.UC_CRUP_SEA.OnAnnulerClicked += new TFEGestionUE.UC.Selection(this.UC_CRUP_SEA_ONANNULER);
            this.UC_CRUP_SEA.OnEnregistrerClicked += new TFEGestionUE.UC.Selection(this.UC_CRUP_SEA_ONENREGISTRER);
            // 
            // UC_AC_ETU
            // 
            this.UC_AC_ETU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_AC_ETU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_AC_ETU.Location = new System.Drawing.Point(3, 3);
            this.UC_AC_ETU.Name = "UC_AC_ETU";
            this.UC_AC_ETU.Size = new System.Drawing.Size(1378, 997);
            this.UC_AC_ETU.TabIndex = 0;
            // 
            // F_GestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_GestionEtudiant";
            this.Text = "Gestion Etudiant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.UC_SRCH_ETU UC_SRCH_ETU;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UC.UC_DISP_ETU UC_DISP_ETU;
        private UC.UC_AC_ETU UC_AC_ETU;
        private UC.UC_CRUP UC_CRUP_ETU;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton bGestionEleve;
        private System.Windows.Forms.ToolStripButton bGestionSession;
        private UC.UC_CRUP_ATT UC_CRUP_ATT;
        private UC.UC_SRCH_SESS UC_SRCH_SES;
        private UC.UC_DISP_SS UC_DISP_SES;
        private UC.UC_CRUP_SESS UC_CRUP_SESS;
        private UC.UC_CRUP_SEA UC_CRUP_SEA;
    }
}