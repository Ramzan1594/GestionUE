namespace TFEGestionUE.UC
{
    partial class UC_CRUP_ATT
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
            System.Windows.Forms.Label personneNomLabel;
            System.Windows.Forms.Label personnePrenomLabel;
            System.Windows.Forms.Label personneDateNaissanceLabel;
            System.Windows.Forms.Label personneNationaliteLabel;
            System.Windows.Forms.Label personneSexeLabel;
            System.Windows.Forms.Label label1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUe = new System.Windows.Forms.ComboBox();
            this.bsUe = new System.Windows.Forms.BindingSource(this.components);
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.bsSection = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbNormale = new System.Windows.Forms.CheckBox();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            personneNomLabel = new System.Windows.Forms.Label();
            personnePrenomLabel = new System.Windows.Forms.Label();
            personneDateNaissanceLabel = new System.Windows.Forms.Label();
            personneNationaliteLabel = new System.Windows.Forms.Label();
            personneSexeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).BeginInit();
            this.SuspendLayout();
            // 
            // personneNomLabel
            // 
            personneNomLabel.AutoSize = true;
            personneNomLabel.Location = new System.Drawing.Point(569, 34);
            personneNomLabel.Name = "personneNomLabel";
            personneNomLabel.Size = new System.Drawing.Size(26, 16);
            personneNomLabel.TabIndex = 25;
            personneNomLabel.Text = "Ue";
            // 
            // personnePrenomLabel
            // 
            personnePrenomLabel.AutoSize = true;
            personnePrenomLabel.Location = new System.Drawing.Point(16, 144);
            personnePrenomLabel.Name = "personnePrenomLabel";
            personnePrenomLabel.Size = new System.Drawing.Size(57, 16);
            personnePrenomLabel.TabIndex = 29;
            personnePrenomLabel.Text = "Resultat";
            // 
            // personneDateNaissanceLabel
            // 
            personneDateNaissanceLabel.AutoSize = true;
            personneDateNaissanceLabel.Location = new System.Drawing.Point(16, 211);
            personneDateNaissanceLabel.Name = "personneDateNaissanceLabel";
            personneDateNaissanceLabel.Size = new System.Drawing.Size(106, 16);
            personneDateNaissanceLabel.TabIndex = 7;
            personneDateNaissanceLabel.Text = "Date d\'obtention";
            // 
            // personneNationaliteLabel
            // 
            personneNationaliteLabel.AutoSize = true;
            personneNationaliteLabel.Location = new System.Drawing.Point(849, 147);
            personneNationaliteLabel.Name = "personneNationaliteLabel";
            personneNationaliteLabel.Size = new System.Drawing.Size(117, 16);
            personneNationaliteLabel.TabIndex = 23;
            personneNationaliteLabel.Text = "Obtention normale";
            // 
            // personneSexeLabel
            // 
            personneSexeLabel.AutoSize = true;
            personneSexeLabel.Location = new System.Drawing.Point(16, 342);
            personneSexeLabel.Name = "personneSexeLabel";
            personneSexeLabel.Size = new System.Drawing.Size(79, 16);
            personneSexeLabel.TabIndex = 37;
            personneSexeLabel.Text = "Description ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 16);
            label1.TabIndex = 44;
            label1.Text = "Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUe);
            this.groupBox2.Controls.Add(this.cbSection);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.cbNormale);
            this.groupBox2.Controls.Add(personneNomLabel);
            this.groupBox2.Controls.Add(this.tbResultat);
            this.groupBox2.Controls.Add(personnePrenomLabel);
            this.groupBox2.Controls.Add(personneDateNaissanceLabel);
            this.groupBox2.Controls.Add(personneNationaliteLabel);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(personneSexeLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 537);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajout attestation";
            // 
            // cbUe
            // 
            this.cbUe.DataSource = this.bsUe;
            this.cbUe.DisplayMember = "Intitule";
            this.cbUe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUe.FormattingEnabled = true;
            this.cbUe.Location = new System.Drawing.Point(632, 31);
            this.cbUe.Name = "cbUe";
            this.cbUe.Size = new System.Drawing.Size(367, 24);
            this.cbUe.TabIndex = 2;
            this.cbUe.ValueMember = "UeId";
            // 
            // bsUe
            // 
            this.bsUe.DataSource = typeof(DTO.Ue);
            // 
            // cbSection
            // 
            this.cbSection.DataSource = this.bsSection;
            this.cbSection.DisplayMember = "SecDescription";
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(128, 31);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(381, 24);
            this.cbSection.TabIndex = 1;
            this.cbSection.ValueMember = "SecId";
            this.cbSection.SelectedIndexChanged += new System.EventHandler(this.cbSectionOnSelectedIndexChange);
            // 
            // bsSection
            // 
            this.bsSection.DataSource = typeof(DTO.Section);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(19, 361);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(980, 125);
            this.tbDescription.TabIndex = 6;
            // 
            // cbNormale
            // 
            this.cbNormale.Checked = true;
            this.cbNormale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNormale.Location = new System.Drawing.Point(981, 144);
            this.cbNormale.Name = "cbNormale";
            this.cbNormale.Size = new System.Drawing.Size(15, 24);
            this.cbNormale.TabIndex = 3;
            this.cbNormale.Text = "checkBox1";
            this.cbNormale.UseVisualStyleBackColor = true;
            // 
            // tbResultat
            // 
            this.tbResultat.Location = new System.Drawing.Point(128, 142);
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(381, 22);
            this.tbResultat.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(128, 211);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.Size = new System.Drawing.Size(381, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.Location = new System.Drawing.Point(527, 706);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(109, 31);
            this.bAnnuler.TabIndex = 8;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(400, 706);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(109, 31);
            this.bEnregistrer.TabIndex = 7;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // UC_CRUP_ATT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_CRUP_ATT";
            this.Size = new System.Drawing.Size(1047, 758);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.CheckBox cbNormale;
        private System.Windows.Forms.TextBox tbResultat;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.ComboBox cbUe;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.BindingSource bsSection;
        private System.Windows.Forms.BindingSource bsUe;
    }
}
