namespace TFEGestionUE.UC
{
    partial class UC_CRUP
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
            System.Windows.Forms.Label personneAdminLabel;
            System.Windows.Forms.Label personneBoîteLabel;
            System.Windows.Forms.Label personneDateNaissanceLabel;
            System.Windows.Forms.Label personneGSMLabel;
            System.Windows.Forms.Label personneMailLabel;
            System.Windows.Forms.Label personneNationaliteLabel;
            System.Windows.Forms.Label personneNomLabel;
            System.Windows.Forms.Label personnePrenomLabel;
            System.Windows.Forms.Label personneRueLabel;
            System.Windows.Forms.Label personneSexeLabel;
            System.Windows.Forms.Label personneTelLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label localiteCodePostalLabel;
            System.Windows.Forms.Label localiteDescriptionLabel;
            this.tbBoite = new System.Windows.Forms.TextBox();
            this.bsPersonne = new System.Windows.Forms.BindingSource(this.components);
            this.tbNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbGsm = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbImm = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.personneSectionTextBox = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.bsSection = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.cbNationalite = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.bsLocalite = new System.Windows.Forms.BindingSource(this.components);
            this.cbLocalite = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            personneAdminLabel = new System.Windows.Forms.Label();
            personneBoîteLabel = new System.Windows.Forms.Label();
            personneDateNaissanceLabel = new System.Windows.Forms.Label();
            personneGSMLabel = new System.Windows.Forms.Label();
            personneMailLabel = new System.Windows.Forms.Label();
            personneNationaliteLabel = new System.Windows.Forms.Label();
            personneNomLabel = new System.Windows.Forms.Label();
            personnePrenomLabel = new System.Windows.Forms.Label();
            personneRueLabel = new System.Windows.Forms.Label();
            personneSexeLabel = new System.Windows.Forms.Label();
            personneTelLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            localiteCodePostalLabel = new System.Windows.Forms.Label();
            localiteDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalite)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // personneAdminLabel
            // 
            personneAdminLabel.AutoSize = true;
            personneAdminLabel.Location = new System.Drawing.Point(923, 23);
            personneAdminLabel.Name = "personneAdminLabel";
            personneAdminLabel.Size = new System.Drawing.Size(46, 16);
            personneAdminLabel.TabIndex = 1;
            personneAdminLabel.Text = "Admin";
            // 
            // personneBoîteLabel
            // 
            personneBoîteLabel.AutoSize = true;
            personneBoîteLabel.Location = new System.Drawing.Point(506, 32);
            personneBoîteLabel.Name = "personneBoîteLabel";
            personneBoîteLabel.Size = new System.Drawing.Size(77, 16);
            personneBoîteLabel.TabIndex = 3;
            personneBoîteLabel.Text = "Num / Boîte";
            // 
            // personneDateNaissanceLabel
            // 
            personneDateNaissanceLabel.AutoSize = true;
            personneDateNaissanceLabel.Location = new System.Drawing.Point(506, 30);
            personneDateNaissanceLabel.Name = "personneDateNaissanceLabel";
            personneDateNaissanceLabel.Size = new System.Drawing.Size(73, 16);
            personneDateNaissanceLabel.TabIndex = 7;
            personneDateNaissanceLabel.Text = "Naissance";
            // 
            // personneGSMLabel
            // 
            personneGSMLabel.AutoSize = true;
            personneGSMLabel.Location = new System.Drawing.Point(11, 59);
            personneGSMLabel.Name = "personneGSMLabel";
            personneGSMLabel.Size = new System.Drawing.Size(38, 16);
            personneGSMLabel.TabIndex = 9;
            personneGSMLabel.Text = "GSM";
            // 
            // personneMailLabel
            // 
            personneMailLabel.AutoSize = true;
            personneMailLabel.Location = new System.Drawing.Point(11, 92);
            personneMailLabel.Name = "personneMailLabel";
            personneMailLabel.Size = new System.Drawing.Size(33, 16);
            personneMailLabel.TabIndex = 21;
            personneMailLabel.Text = "Mail";
            // 
            // personneNationaliteLabel
            // 
            personneNationaliteLabel.AutoSize = true;
            personneNationaliteLabel.Location = new System.Drawing.Point(506, 60);
            personneNationaliteLabel.Name = "personneNationaliteLabel";
            personneNationaliteLabel.Size = new System.Drawing.Size(72, 16);
            personneNationaliteLabel.TabIndex = 23;
            personneNationaliteLabel.Text = "Nationalité";
            // 
            // personneNomLabel
            // 
            personneNomLabel.AutoSize = true;
            personneNomLabel.Location = new System.Drawing.Point(11, 27);
            personneNomLabel.Name = "personneNomLabel";
            personneNomLabel.Size = new System.Drawing.Size(37, 16);
            personneNomLabel.TabIndex = 25;
            personneNomLabel.Text = "Nom";
            // 
            // personnePrenomLabel
            // 
            personnePrenomLabel.AutoSize = true;
            personnePrenomLabel.Location = new System.Drawing.Point(11, 57);
            personnePrenomLabel.Name = "personnePrenomLabel";
            personnePrenomLabel.Size = new System.Drawing.Size(55, 16);
            personnePrenomLabel.TabIndex = 29;
            personnePrenomLabel.Text = "Prénom";
            // 
            // personneRueLabel
            // 
            personneRueLabel.AutoSize = true;
            personneRueLabel.Location = new System.Drawing.Point(11, 35);
            personneRueLabel.Name = "personneRueLabel";
            personneRueLabel.Size = new System.Drawing.Size(33, 16);
            personneRueLabel.TabIndex = 33;
            personneRueLabel.Text = "Rue";
            // 
            // personneSexeLabel
            // 
            personneSexeLabel.AutoSize = true;
            personneSexeLabel.Location = new System.Drawing.Point(11, 89);
            personneSexeLabel.Name = "personneSexeLabel";
            personneSexeLabel.Size = new System.Drawing.Size(39, 16);
            personneSexeLabel.TabIndex = 37;
            personneSexeLabel.Text = "Sexe";
            // 
            // personneTelLabel
            // 
            personneTelLabel.AutoSize = true;
            personneTelLabel.Location = new System.Drawing.Point(11, 27);
            personneTelLabel.Name = "personneTelLabel";
            personneTelLabel.Size = new System.Drawing.Size(74, 16);
            personneTelLabel.TabIndex = 39;
            personneTelLabel.Text = "Téléphone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 148);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 16);
            label1.TabIndex = 39;
            label1.Text = "Section";
            // 
            // localiteCodePostalLabel
            // 
            localiteCodePostalLabel.AutoSize = true;
            localiteCodePostalLabel.Location = new System.Drawing.Point(506, 80);
            localiteCodePostalLabel.Name = "localiteCodePostalLabel";
            localiteCodePostalLabel.Size = new System.Drawing.Size(82, 16);
            localiteCodePostalLabel.TabIndex = 39;
            localiteCodePostalLabel.Text = "Code Postal";
            // 
            // localiteDescriptionLabel
            // 
            localiteDescriptionLabel.AutoSize = true;
            localiteDescriptionLabel.Location = new System.Drawing.Point(11, 80);
            localiteDescriptionLabel.Name = "localiteDescriptionLabel";
            localiteDescriptionLabel.Size = new System.Drawing.Size(58, 16);
            localiteDescriptionLabel.TabIndex = 41;
            localiteDescriptionLabel.Text = "Localite ";
            // 
            // tbBoite
            // 
            this.tbBoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneBoîte", true));
            this.tbBoite.Location = new System.Drawing.Point(748, 29);
            this.tbBoite.Name = "tbBoite";
            this.tbBoite.Size = new System.Drawing.Size(128, 22);
            this.tbBoite.TabIndex = 9;
            // 
            // bsPersonne
            // 
            this.bsPersonne.DataSource = typeof(DTO.Personne);
            // 
            // tbNaissance
            // 
            this.tbNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPersonne, "PersonneDateNaissance", true));
            this.tbNaissance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tbNaissance.Location = new System.Drawing.Point(617, 26);
            this.tbNaissance.Name = "tbNaissance";
            this.tbNaissance.Size = new System.Drawing.Size(259, 22);
            this.tbNaissance.TabIndex = 8;
            // 
            // tbGsm
            // 
            this.tbGsm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneGSM", true));
            this.tbGsm.Location = new System.Drawing.Point(121, 56);
            this.tbGsm.Name = "tbGsm";
            this.tbGsm.Size = new System.Drawing.Size(259, 22);
            this.tbGsm.TabIndex = 11;
            // 
            // tbMail
            // 
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneMail", true));
            this.tbMail.Location = new System.Drawing.Point(121, 89);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(259, 22);
            this.tbMail.TabIndex = 12;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNom", true));
            this.tbNom.Location = new System.Drawing.Point(121, 24);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(259, 22);
            this.tbNom.TabIndex = 2;
            // 
            // tbImm
            // 
            this.tbImm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNumImm", true));
            this.tbImm.Location = new System.Drawing.Point(617, 29);
            this.tbImm.Name = "tbImm";
            this.tbImm.Size = new System.Drawing.Size(128, 22);
            this.tbImm.TabIndex = 8;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonnePrenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(121, 54);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(259, 22);
            this.tbPrenom.TabIndex = 3;
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneRue", true));
            this.tbRue.Location = new System.Drawing.Point(121, 32);
            this.tbRue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(259, 22);
            this.tbRue.TabIndex = 6;
            // 
            // personneSectionTextBox
            // 
            this.personneSectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneSection", true));
            this.personneSectionTextBox.Enabled = false;
            this.personneSectionTextBox.Location = new System.Drawing.Point(14, 172);
            this.personneSectionTextBox.Name = "personneSectionTextBox";
            this.personneSectionTextBox.Size = new System.Drawing.Size(984, 22);
            this.personneSectionTextBox.TabIndex = 36;
            // 
            // tbTel
            // 
            this.tbTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneTel", true));
            this.tbTel.Location = new System.Drawing.Point(121, 24);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(259, 22);
            this.tbTel.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 62);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section";
            // 
            // cbSection
            // 
            this.cbSection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSection, "SecDescription", true));
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(14, 19);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(984, 24);
            this.cbSection.TabIndex = 1;
            // 
            // bsSection
            // 
            this.bsSection.DataSource = typeof(DTO.Section);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAdmin);
            this.groupBox2.Controls.Add(this.cbSexe);
            this.groupBox2.Controls.Add(this.cbNationalite);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.personneSectionTextBox);
            this.groupBox2.Controls.Add(personneAdminLabel);
            this.groupBox2.Controls.Add(this.tbNom);
            this.groupBox2.Controls.Add(personneNomLabel);
            this.groupBox2.Controls.Add(this.tbPrenom);
            this.groupBox2.Controls.Add(personnePrenomLabel);
            this.groupBox2.Controls.Add(personneDateNaissanceLabel);
            this.groupBox2.Controls.Add(personneNationaliteLabel);
            this.groupBox2.Controls.Add(this.tbNaissance);
            this.groupBox2.Controls.Add(personneSexeLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 212);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signalétique";
            // 
            // cbAdmin
            // 
            this.cbAdmin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPersonne, "PersonneAdmin", true));
            this.cbAdmin.Location = new System.Drawing.Point(983, 20);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(15, 24);
            this.cbAdmin.TabIndex = 42;
            this.cbAdmin.Text = "checkBox1";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // cbSexe
            // 
            this.cbSexe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneSexe", true));
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(121, 86);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(259, 24);
            this.cbSexe.TabIndex = 4;
            // 
            // cbNationalite
            // 
            this.cbNationalite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbNationalite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNationalite", true));
            this.cbNationalite.FormattingEnabled = true;
            this.cbNationalite.Location = new System.Drawing.Point(617, 56);
            this.cbNationalite.Name = "cbNationalite";
            this.cbNationalite.Size = new System.Drawing.Size(259, 24);
            this.cbNationalite.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(localiteCodePostalLabel);
            this.groupBox3.Controls.Add(this.tbCp);
            this.groupBox3.Controls.Add(localiteDescriptionLabel);
            this.groupBox3.Controls.Add(this.tbRue);
            this.groupBox3.Controls.Add(this.cbLocalite);
            this.groupBox3.Controls.Add(personneRueLabel);
            this.groupBox3.Controls.Add(personneBoîteLabel);
            this.groupBox3.Controls.Add(this.tbBoite);
            this.groupBox3.Controls.Add(this.tbImm);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 153);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adresse";
            // 
            // tbCp
            // 
            this.tbCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLocalite, "LocaliteCodePostal", true));
            this.tbCp.Enabled = false;
            this.tbCp.Location = new System.Drawing.Point(617, 77);
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(128, 22);
            this.tbCp.TabIndex = 40;
            // 
            // bsLocalite
            // 
            this.bsLocalite.DataSource = typeof(DTO.Localite);
            // 
            // cbLocalite
            // 
            this.cbLocalite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLocalite, "LocaliteDescription", true));
            this.cbLocalite.DataSource = this.bsLocalite;
            this.cbLocalite.DisplayMember = "LocaliteDescription";
            this.cbLocalite.FormattingEnabled = true;
            this.cbLocalite.Location = new System.Drawing.Point(121, 77);
            this.cbLocalite.Name = "cbLocalite";
            this.cbLocalite.Size = new System.Drawing.Size(259, 24);
            this.cbLocalite.TabIndex = 42;
            this.cbLocalite.ValueMember = "LocaliteDescription";
            this.cbLocalite.SelectedIndexChanged += new System.EventHandler(this.cbLocaliteChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(personneMailLabel);
            this.groupBox4.Controls.Add(this.tbMail);
            this.groupBox4.Controls.Add(personneGSMLabel);
            this.groupBox4.Controls.Add(this.tbTel);
            this.groupBox4.Controls.Add(personneTelLabel);
            this.groupBox4.Controls.Add(this.tbGsm);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 139);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Téléphone / Connectivité";
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(400, 706);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(100, 31);
            this.bEnregistrer.TabIndex = 45;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrerClicked);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.Location = new System.Drawing.Point(527, 706);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(100, 31);
            this.bAnnuler.TabIndex = 46;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnulerClicked);
            // 
            // UC_CRUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_CRUP";
            this.Size = new System.Drawing.Size(1047, 758);
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalite)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPersonne;
        private System.Windows.Forms.TextBox tbBoite;
        private System.Windows.Forms.DateTimePicker tbNaissance;
        private System.Windows.Forms.TextBox tbGsm;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbImm;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox personneSectionTextBox;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.BindingSource bsSection;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.ComboBox cbNationalite;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.BindingSource bsLocalite;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.ComboBox cbLocalite;
    }
}
