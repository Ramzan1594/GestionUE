namespace TFEGestionUE.UC
{
    partial class UC_DISP_ETU
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
            System.Windows.Forms.Label personneCodePostalLabel;
            System.Windows.Forms.Label lDateNaissance;
            System.Windows.Forms.Label personneGSMLabel;
            System.Windows.Forms.Label personneidLocaliteLabel;
            System.Windows.Forms.Label personneidSectionLabel;
            System.Windows.Forms.Label personneMailLabel;
            System.Windows.Forms.Label lNationalite;
            System.Windows.Forms.Label lNom;
            System.Windows.Forms.Label personneNumImmLabel;
            System.Windows.Forms.Label lPrenom;
            System.Windows.Forms.Label personneRueLabel;
            System.Windows.Forms.Label lSexe;
            System.Windows.Forms.Label personneTelLabel;
            this.cbAdminDisp = new System.Windows.Forms.CheckBox();
            this.bsPersonne = new System.Windows.Forms.BindingSource(this.components);
            this.tbBoite = new System.Windows.Forms.TextBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.tbNai = new System.Windows.Forms.DateTimePicker();
            this.tbGsm = new System.Windows.Forms.TextBox();
            this.tbLoc = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNat = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbNumImm = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.tbSexe = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.gbSection = new System.Windows.Forms.GroupBox();
            this.gbSignaletique = new System.Windows.Forms.GroupBox();
            this.gbAdresse = new System.Windows.Forms.GroupBox();
            this.gbTelephone = new System.Windows.Forms.GroupBox();
            this.bModifier = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bAttestation = new System.Windows.Forms.Button();
            personneAdminLabel = new System.Windows.Forms.Label();
            personneBoîteLabel = new System.Windows.Forms.Label();
            personneCodePostalLabel = new System.Windows.Forms.Label();
            lDateNaissance = new System.Windows.Forms.Label();
            personneGSMLabel = new System.Windows.Forms.Label();
            personneidLocaliteLabel = new System.Windows.Forms.Label();
            personneidSectionLabel = new System.Windows.Forms.Label();
            personneMailLabel = new System.Windows.Forms.Label();
            lNationalite = new System.Windows.Forms.Label();
            lNom = new System.Windows.Forms.Label();
            personneNumImmLabel = new System.Windows.Forms.Label();
            lPrenom = new System.Windows.Forms.Label();
            personneRueLabel = new System.Windows.Forms.Label();
            lSexe = new System.Windows.Forms.Label();
            personneTelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).BeginInit();
            this.gbSection.SuspendLayout();
            this.gbSignaletique.SuspendLayout();
            this.gbAdresse.SuspendLayout();
            this.gbTelephone.SuspendLayout();
            this.SuspendLayout();
            // 
            // personneAdminLabel
            // 
            personneAdminLabel.AutoSize = true;
            personneAdminLabel.Location = new System.Drawing.Point(449, 26);
            personneAdminLabel.Name = "personneAdminLabel";
            personneAdminLabel.Size = new System.Drawing.Size(46, 16);
            personneAdminLabel.TabIndex = 0;
            personneAdminLabel.Text = "Admin";
            // 
            // personneBoîteLabel
            // 
            personneBoîteLabel.AutoSize = true;
            personneBoîteLabel.Location = new System.Drawing.Point(19, 117);
            personneBoîteLabel.Name = "personneBoîteLabel";
            personneBoîteLabel.Size = new System.Drawing.Size(39, 16);
            personneBoîteLabel.TabIndex = 2;
            personneBoîteLabel.Text = "Boîte";
            // 
            // personneCodePostalLabel
            // 
            personneCodePostalLabel.AutoSize = true;
            personneCodePostalLabel.Location = new System.Drawing.Point(19, 54);
            personneCodePostalLabel.Name = "personneCodePostalLabel";
            personneCodePostalLabel.Size = new System.Drawing.Size(82, 16);
            personneCodePostalLabel.TabIndex = 4;
            personneCodePostalLabel.Text = "Code Postal";
            // 
            // lDateNaissance
            // 
            lDateNaissance.AutoSize = true;
            lDateNaissance.Location = new System.Drawing.Point(19, 138);
            lDateNaissance.Name = "lDateNaissance";
            lDateNaissance.Size = new System.Drawing.Size(73, 16);
            lDateNaissance.TabIndex = 6;
            lDateNaissance.Text = "Naissance";
            // 
            // personneGSMLabel
            // 
            personneGSMLabel.AutoSize = true;
            personneGSMLabel.Location = new System.Drawing.Point(19, 57);
            personneGSMLabel.Name = "personneGSMLabel";
            personneGSMLabel.Size = new System.Drawing.Size(38, 16);
            personneGSMLabel.TabIndex = 8;
            personneGSMLabel.Text = "GSM";
            // 
            // personneidLocaliteLabel
            // 
            personneidLocaliteLabel.AutoSize = true;
            personneidLocaliteLabel.Location = new System.Drawing.Point(19, 147);
            personneidLocaliteLabel.Name = "personneidLocaliteLabel";
            personneidLocaliteLabel.Size = new System.Drawing.Size(55, 16);
            personneidLocaliteLabel.TabIndex = 12;
            personneidLocaliteLabel.Text = "Localité";
            // 
            // personneidSectionLabel
            // 
            personneidSectionLabel.AutoSize = true;
            personneidSectionLabel.Location = new System.Drawing.Point(-118, 56);
            personneidSectionLabel.Name = "personneidSectionLabel";
            personneidSectionLabel.Size = new System.Drawing.Size(128, 16);
            personneidSectionLabel.TabIndex = 16;
            personneidSectionLabel.Text = "Personneid Section:";
            // 
            // personneMailLabel
            // 
            personneMailLabel.AutoSize = true;
            personneMailLabel.Location = new System.Drawing.Point(19, 86);
            personneMailLabel.Name = "personneMailLabel";
            personneMailLabel.Size = new System.Drawing.Size(33, 16);
            personneMailLabel.TabIndex = 20;
            personneMailLabel.Text = "Mail";
            // 
            // lNationalite
            // 
            lNationalite.AutoSize = true;
            lNationalite.Location = new System.Drawing.Point(19, 169);
            lNationalite.Name = "lNationalite";
            lNationalite.Size = new System.Drawing.Size(72, 16);
            lNationalite.TabIndex = 22;
            lNationalite.Text = "Nationalité";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lNom.Location = new System.Drawing.Point(19, 28);
            lNom.Name = "lNom";
            lNom.Size = new System.Drawing.Size(29, 13);
            lNom.TabIndex = 24;
            lNom.Text = "Nom";
            // 
            // personneNumImmLabel
            // 
            personneNumImmLabel.AutoSize = true;
            personneNumImmLabel.Location = new System.Drawing.Point(19, 85);
            personneNumImmLabel.Name = "personneNumImmLabel";
            personneNumImmLabel.Size = new System.Drawing.Size(98, 16);
            personneNumImmLabel.TabIndex = 26;
            personneNumImmLabel.Text = "Num Immeuble";
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new System.Drawing.Point(19, 57);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new System.Drawing.Size(55, 16);
            lPrenom.TabIndex = 28;
            lPrenom.Text = "Prénom";
            // 
            // personneRueLabel
            // 
            personneRueLabel.AutoSize = true;
            personneRueLabel.Location = new System.Drawing.Point(19, 23);
            personneRueLabel.Name = "personneRueLabel";
            personneRueLabel.Size = new System.Drawing.Size(33, 16);
            personneRueLabel.TabIndex = 32;
            personneRueLabel.Text = "Rue";
            // 
            // lSexe
            // 
            lSexe.AutoSize = true;
            lSexe.Location = new System.Drawing.Point(19, 87);
            lSexe.Name = "lSexe";
            lSexe.Size = new System.Drawing.Size(39, 16);
            lSexe.TabIndex = 36;
            lSexe.Text = "Sexe";
            // 
            // personneTelLabel
            // 
            personneTelLabel.AutoSize = true;
            personneTelLabel.Location = new System.Drawing.Point(19, 28);
            personneTelLabel.Name = "personneTelLabel";
            personneTelLabel.Size = new System.Drawing.Size(74, 16);
            personneTelLabel.TabIndex = 38;
            personneTelLabel.Text = "Téléphone";
            // 
            // cbAdminDisp
            // 
            this.cbAdminDisp.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPersonne, "PersonneAdmin", true));
            this.cbAdminDisp.Enabled = false;
            this.cbAdminDisp.Location = new System.Drawing.Point(501, 23);
            this.cbAdminDisp.Name = "cbAdminDisp";
            this.cbAdminDisp.Size = new System.Drawing.Size(14, 24);
            this.cbAdminDisp.TabIndex = 15;
            this.cbAdminDisp.UseVisualStyleBackColor = true;
            // 
            // bsPersonne
            // 
            this.bsPersonne.DataSource = typeof(DTO.Personne);
            // 
            // tbBoite
            // 
            this.tbBoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneBoîte", true));
            this.tbBoite.Location = new System.Drawing.Point(159, 114);
            this.tbBoite.Name = "tbBoite";
            this.tbBoite.ReadOnly = true;
            this.tbBoite.Size = new System.Drawing.Size(238, 22);
            this.tbBoite.TabIndex = 10;
            // 
            // tbCp
            // 
            this.tbCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneCodePostal", true));
            this.tbCp.Location = new System.Drawing.Point(159, 51);
            this.tbCp.Name = "tbCp";
            this.tbCp.ReadOnly = true;
            this.tbCp.Size = new System.Drawing.Size(238, 22);
            this.tbCp.TabIndex = 8;
            // 
            // tbNai
            // 
            this.tbNai.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPersonne, "PersonneDateNaissance", true));
            this.tbNai.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tbNai.Enabled = false;
            this.tbNai.Location = new System.Drawing.Point(159, 134);
            this.tbNai.Name = "tbNai";
            this.tbNai.Size = new System.Drawing.Size(238, 22);
            this.tbNai.TabIndex = 5;
            // 
            // tbGsm
            // 
            this.tbGsm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneGSM", true));
            this.tbGsm.Location = new System.Drawing.Point(159, 54);
            this.tbGsm.Name = "tbGsm";
            this.tbGsm.ReadOnly = true;
            this.tbGsm.Size = new System.Drawing.Size(238, 22);
            this.tbGsm.TabIndex = 13;
            // 
            // tbLoc
            // 
            this.tbLoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneLocalite", true));
            this.tbLoc.Location = new System.Drawing.Point(159, 144);
            this.tbLoc.Name = "tbLoc";
            this.tbLoc.ReadOnly = true;
            this.tbLoc.Size = new System.Drawing.Size(238, 22);
            this.tbLoc.TabIndex = 11;
            // 
            // tbMail
            // 
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneMail", true));
            this.tbMail.Location = new System.Drawing.Point(159, 83);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(238, 22);
            this.tbMail.TabIndex = 14;
            // 
            // tbNat
            // 
            this.tbNat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNationalite", true));
            this.tbNat.Location = new System.Drawing.Point(159, 166);
            this.tbNat.Name = "tbNat";
            this.tbNat.ReadOnly = true;
            this.tbNat.Size = new System.Drawing.Size(238, 22);
            this.tbNat.TabIndex = 6;
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.SystemColors.Control;
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNom", true));
            this.tbNom.Location = new System.Drawing.Point(159, 25);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(238, 22);
            this.tbNom.TabIndex = 2;
            // 
            // tbNumImm
            // 
            this.tbNumImm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNumImm", true));
            this.tbNumImm.Location = new System.Drawing.Point(159, 82);
            this.tbNumImm.Name = "tbNumImm";
            this.tbNumImm.ReadOnly = true;
            this.tbNumImm.Size = new System.Drawing.Size(238, 22);
            this.tbNumImm.TabIndex = 9;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonnePrenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(159, 54);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.ReadOnly = true;
            this.tbPrenom.Size = new System.Drawing.Size(238, 22);
            this.tbPrenom.TabIndex = 3;
            // 
            // tbRue
            // 
            this.tbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneRue", true));
            this.tbRue.Location = new System.Drawing.Point(159, 20);
            this.tbRue.Name = "tbRue";
            this.tbRue.ReadOnly = true;
            this.tbRue.Size = new System.Drawing.Size(238, 22);
            this.tbRue.TabIndex = 7;
            // 
            // tbSection
            // 
            this.tbSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneSection", true));
            this.tbSection.Location = new System.Drawing.Point(16, 19);
            this.tbSection.Name = "tbSection";
            this.tbSection.ReadOnly = true;
            this.tbSection.Size = new System.Drawing.Size(990, 22);
            this.tbSection.TabIndex = 1;
            // 
            // tbSexe
            // 
            this.tbSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneSexe", true));
            this.tbSexe.Location = new System.Drawing.Point(159, 84);
            this.tbSexe.Name = "tbSexe";
            this.tbSexe.ReadOnly = true;
            this.tbSexe.Size = new System.Drawing.Size(238, 22);
            this.tbSexe.TabIndex = 4;
            // 
            // tbTel
            // 
            this.tbTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneTel", true));
            this.tbTel.Location = new System.Drawing.Point(159, 25);
            this.tbTel.Name = "tbTel";
            this.tbTel.ReadOnly = true;
            this.tbTel.Size = new System.Drawing.Size(238, 22);
            this.tbTel.TabIndex = 12;
            // 
            // gbSection
            // 
            this.gbSection.Controls.Add(personneidSectionLabel);
            this.gbSection.Controls.Add(this.tbSection);
            this.gbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSection.Location = new System.Drawing.Point(13, 16);
            this.gbSection.Name = "gbSection";
            this.gbSection.Size = new System.Drawing.Size(1018, 52);
            this.gbSection.TabIndex = 40;
            this.gbSection.TabStop = false;
            this.gbSection.Text = "Section";
            // 
            // gbSignaletique
            // 
            this.gbSignaletique.Controls.Add(lNom);
            this.gbSignaletique.Controls.Add(this.tbSexe);
            this.gbSignaletique.Controls.Add(lSexe);
            this.gbSignaletique.Controls.Add(this.tbPrenom);
            this.gbSignaletique.Controls.Add(this.cbAdminDisp);
            this.gbSignaletique.Controls.Add(personneAdminLabel);
            this.gbSignaletique.Controls.Add(lPrenom);
            this.gbSignaletique.Controls.Add(this.tbNom);
            this.gbSignaletique.Controls.Add(lDateNaissance);
            this.gbSignaletique.Controls.Add(this.tbNai);
            this.gbSignaletique.Controls.Add(lNationalite);
            this.gbSignaletique.Controls.Add(this.tbNat);
            this.gbSignaletique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignaletique.Location = new System.Drawing.Point(13, 91);
            this.gbSignaletique.Name = "gbSignaletique";
            this.gbSignaletique.Size = new System.Drawing.Size(1018, 210);
            this.gbSignaletique.TabIndex = 41;
            this.gbSignaletique.TabStop = false;
            this.gbSignaletique.Text = "Signalétique";
            // 
            // gbAdresse
            // 
            this.gbAdresse.Controls.Add(personneRueLabel);
            this.gbAdresse.Controls.Add(this.tbRue);
            this.gbAdresse.Controls.Add(personneCodePostalLabel);
            this.gbAdresse.Controls.Add(this.tbCp);
            this.gbAdresse.Controls.Add(personneNumImmLabel);
            this.gbAdresse.Controls.Add(this.tbNumImm);
            this.gbAdresse.Controls.Add(personneBoîteLabel);
            this.gbAdresse.Controls.Add(this.tbBoite);
            this.gbAdresse.Controls.Add(personneidLocaliteLabel);
            this.gbAdresse.Controls.Add(this.tbLoc);
            this.gbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdresse.Location = new System.Drawing.Point(13, 327);
            this.gbAdresse.Name = "gbAdresse";
            this.gbAdresse.Size = new System.Drawing.Size(1018, 200);
            this.gbAdresse.TabIndex = 42;
            this.gbAdresse.TabStop = false;
            this.gbAdresse.Text = "Adresse";
            // 
            // gbTelephone
            // 
            this.gbTelephone.Controls.Add(this.tbTel);
            this.gbTelephone.Controls.Add(personneTelLabel);
            this.gbTelephone.Controls.Add(this.tbGsm);
            this.gbTelephone.Controls.Add(personneGSMLabel);
            this.gbTelephone.Controls.Add(this.tbMail);
            this.gbTelephone.Controls.Add(personneMailLabel);
            this.gbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelephone.Location = new System.Drawing.Point(13, 555);
            this.gbTelephone.Name = "gbTelephone";
            this.gbTelephone.Size = new System.Drawing.Size(1018, 131);
            this.gbTelephone.TabIndex = 42;
            this.gbTelephone.TabStop = false;
            this.gbTelephone.Text = "Téléphone /  Connectivité";
            // 
            // bModifier
            // 
            this.bModifier.Enabled = false;
            this.bModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModifier.Location = new System.Drawing.Point(493, 707);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(98, 31);
            this.bModifier.TabIndex = 17;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifierClick);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Enabled = false;
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.Location = new System.Drawing.Point(608, 707);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(98, 31);
            this.bSupprimer.TabIndex = 18;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimerClick);
            // 
            // bAttestation
            // 
            this.bAttestation.Enabled = false;
            this.bAttestation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAttestation.Location = new System.Drawing.Point(379, 707);
            this.bAttestation.Name = "bAttestation";
            this.bAttestation.Size = new System.Drawing.Size(98, 31);
            this.bAttestation.TabIndex = 16;
            this.bAttestation.Text = "Ajouter attestation";
            this.bAttestation.UseVisualStyleBackColor = true;
            this.bAttestation.Click += new System.EventHandler(this.bAttestationClick);
            // 
            // UC_DISP_ETU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.bAttestation);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.gbTelephone);
            this.Controls.Add(this.gbAdresse);
            this.Controls.Add(this.gbSignaletique);
            this.Controls.Add(this.gbSection);
            this.Name = "UC_DISP_ETU";
            this.Size = new System.Drawing.Size(1047, 758);
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).EndInit();
            this.gbSection.ResumeLayout(false);
            this.gbSection.PerformLayout();
            this.gbSignaletique.ResumeLayout(false);
            this.gbSignaletique.PerformLayout();
            this.gbAdresse.ResumeLayout(false);
            this.gbAdresse.PerformLayout();
            this.gbTelephone.ResumeLayout(false);
            this.gbTelephone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPersonne;
        private System.Windows.Forms.CheckBox cbAdminDisp;
        private System.Windows.Forms.TextBox tbBoite;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.DateTimePicker tbNai;
        private System.Windows.Forms.TextBox tbGsm;
        private System.Windows.Forms.TextBox tbLoc;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNat;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbNumImm;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.TextBox tbSexe;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.GroupBox gbSection;
        private System.Windows.Forms.GroupBox gbSignaletique;
        private System.Windows.Forms.GroupBox gbAdresse;
        private System.Windows.Forms.GroupBox gbTelephone;
        private System.Windows.Forms.Button bModifier;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bAttestation;
    }
}
