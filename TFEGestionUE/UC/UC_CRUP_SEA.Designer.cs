namespace TFEGestionUE.UC
{
    partial class UC_CRUP_SEA
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
            System.Windows.Forms.Label seaCreneauLabel;
            System.Windows.Forms.Label seaDateDebLabel;
            System.Windows.Forms.Label seaDateFinLabel;
            System.Windows.Forms.Label seaJourLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbJour = new System.Windows.Forms.ComboBox();
            this.bsSeance = new System.Windows.Forms.BindingSource(this.components);
            this.cbCreneau = new System.Windows.Forms.ComboBox();
            this.dtpDeb = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            seaCreneauLabel = new System.Windows.Forms.Label();
            seaDateDebLabel = new System.Windows.Forms.Label();
            seaDateFinLabel = new System.Windows.Forms.Label();
            seaJourLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeance)).BeginInit();
            this.SuspendLayout();
            // 
            // seaCreneauLabel
            // 
            seaCreneauLabel.AutoSize = true;
            seaCreneauLabel.Location = new System.Drawing.Point(586, 186);
            seaCreneauLabel.Name = "seaCreneauLabel";
            seaCreneauLabel.Size = new System.Drawing.Size(62, 16);
            seaCreneauLabel.TabIndex = 44;
            seaCreneauLabel.Text = "Creneau ";
            // 
            // seaDateDebLabel
            // 
            seaDateDebLabel.AutoSize = true;
            seaDateDebLabel.Location = new System.Drawing.Point(54, 57);
            seaDateDebLabel.Name = "seaDateDebLabel";
            seaDateDebLabel.Size = new System.Drawing.Size(95, 16);
            seaDateDebLabel.TabIndex = 46;
            seaDateDebLabel.Text = "Date de Début";
            // 
            // seaDateFinLabel
            // 
            seaDateFinLabel.AutoSize = true;
            seaDateFinLabel.Location = new System.Drawing.Point(63, 186);
            seaDateFinLabel.Name = "seaDateFinLabel";
            seaDateFinLabel.Size = new System.Drawing.Size(72, 16);
            seaDateFinLabel.TabIndex = 48;
            seaDateFinLabel.Text = "Date de fin";
            // 
            // seaJourLabel
            // 
            seaJourLabel.AutoSize = true;
            seaJourLabel.Location = new System.Drawing.Point(568, 55);
            seaJourLabel.Name = "seaJourLabel";
            seaJourLabel.Size = new System.Drawing.Size(122, 16);
            seaJourLabel.TabIndex = 54;
            seaJourLabel.Text = "Jour de la semaine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAnnuler);
            this.groupBox2.Controls.Add(this.bEnregistrer);
            this.groupBox2.Controls.Add(this.cbJour);
            this.groupBox2.Controls.Add(this.cbCreneau);
            this.groupBox2.Controls.Add(seaCreneauLabel);
            this.groupBox2.Controls.Add(seaDateDebLabel);
            this.groupBox2.Controls.Add(this.dtpDeb);
            this.groupBox2.Controls.Add(seaDateFinLabel);
            this.groupBox2.Controls.Add(this.dtpFin);
            this.groupBox2.Controls.Add(seaJourLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 353);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajout séance";
            // 
            // cbJour
            // 
            this.cbJour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbJour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSeance, "SeaJour", true));
            this.cbJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJour.FormattingEnabled = true;
            this.cbJour.Location = new System.Drawing.Point(703, 52);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(264, 24);
            this.cbJour.TabIndex = 3;
            // 
            // bsSeance
            // 
            this.bsSeance.DataSource = typeof(DTO.Seance);
            // 
            // cbCreneau
            // 
            this.cbCreneau.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCreneau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSeance, "SeaCreneau", true));
            this.cbCreneau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreneau.FormattingEnabled = true;
            this.cbCreneau.Location = new System.Drawing.Point(703, 182);
            this.cbCreneau.Name = "cbCreneau";
            this.cbCreneau.Size = new System.Drawing.Size(264, 24);
            this.cbCreneau.TabIndex = 4;
            // 
            // dtpDeb
            // 
            this.dtpDeb.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSeance, "SeaDateDeb", true));
            this.dtpDeb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDeb.Location = new System.Drawing.Point(171, 53);
            this.dtpDeb.Name = "dtpDeb";
            this.dtpDeb.Size = new System.Drawing.Size(263, 22);
            this.dtpDeb.TabIndex = 1;
            this.dtpDeb.ValueChanged += new System.EventHandler(this.dateDebutChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSeance, "SeaDateFin", true));
            this.dtpFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFin.Location = new System.Drawing.Point(172, 182);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(263, 22);
            this.dtpFin.TabIndex = 2;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.Location = new System.Drawing.Point(529, 308);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(109, 31);
            this.bAnnuler.TabIndex = 6;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(402, 308);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(109, 31);
            this.bEnregistrer.TabIndex = 5;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // UC_CRUP_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_CRUP_SEA";
            this.Size = new System.Drawing.Size(1047, 378);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bsSeance;
        private System.Windows.Forms.DateTimePicker dtpDeb;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.ComboBox cbCreneau;
    }
}
