namespace TFEGestionUE.UC
{
    partial class UC_SRCH_SESS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.bsUe = new System.Windows.Forms.BindingSource(this.components);
            this.bsSection = new System.Windows.Forms.BindingSource(this.components);
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.bSession = new System.Windows.Forms.Button();
            this.bSeance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panneau de recherche";
            // 
            // bsUe
            // 
            this.bsUe.DataSource = typeof(DTO.Ue);
            // 
            // bsSection
            // 
            this.bsSection.DataSource = typeof(DTO.Section);
            // 
            // cbSection
            // 
            this.cbSection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSection.DataSource = this.bsSection;
            this.cbSection.DisplayMember = "SecComplet";
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(12, 171);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(487, 24);
            this.cbSection.TabIndex = 1;
            this.cbSection.ValueMember = "SecId";
            this.cbSection.SelectedIndexChanged += new System.EventHandler(this.SectionIndexChange);
            // 
            // bSession
            // 
            this.bSession.Enabled = false;
            this.bSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSession.Location = new System.Drawing.Point(240, 897);
            this.bSession.Name = "bSession";
            this.bSession.Size = new System.Drawing.Size(122, 37);
            this.bSession.TabIndex = 2;
            this.bSession.Text = "Ajouter session";
            this.bSession.UseVisualStyleBackColor = true;
            this.bSession.Click += new System.EventHandler(this.bAjouterSession);
            // 
            // bSeance
            // 
            this.bSeance.Enabled = false;
            this.bSeance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeance.Location = new System.Drawing.Point(377, 897);
            this.bSeance.Name = "bSeance";
            this.bSeance.Size = new System.Drawing.Size(122, 37);
            this.bSeance.TabIndex = 3;
            this.bSeance.Text = "Ajouter séance";
            this.bSeance.UseVisualStyleBackColor = true;
            this.bSeance.Click += new System.EventHandler(this.bAjouterSeance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::TFEGestionUE.Properties.Resources.LAST2;
            this.pictureBox1.Location = new System.Drawing.Point(188, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UC_SRCH_SESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSeance);
            this.Controls.Add(this.bSession);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.label2);
            this.Name = "UC_SRCH_SESS";
            this.Size = new System.Drawing.Size(513, 975);
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsUe;
        private System.Windows.Forms.BindingSource bsSection;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Button bSession;
        private System.Windows.Forms.Button bSeance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
