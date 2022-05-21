namespace TFEGestionUE.UC
{
    partial class UC_CRUP_SESS
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
            System.Windows.Forms.Label sesDebLabel;
            System.Windows.Forms.Label sesFinLabel;
            System.Windows.Forms.Label intituleLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUe = new System.Windows.Forms.ComboBox();
            this.bsUe = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDeb = new System.Windows.Forms.DateTimePicker();
            this.bsSes = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            sesDebLabel = new System.Windows.Forms.Label();
            sesFinLabel = new System.Windows.Forms.Label();
            intituleLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSes)).BeginInit();
            this.SuspendLayout();
            // 
            // sesDebLabel
            // 
            sesDebLabel.AutoSize = true;
            sesDebLabel.Location = new System.Drawing.Point(567, 55);
            sesDebLabel.Name = "sesDebLabel";
            sesDebLabel.Size = new System.Drawing.Size(74, 16);
            sesDebLabel.TabIndex = 2;
            sesDebLabel.Text = "Date début";
            // 
            // sesFinLabel
            // 
            sesFinLabel.AutoSize = true;
            sesFinLabel.Location = new System.Drawing.Point(574, 177);
            sesFinLabel.Name = "sesFinLabel";
            sesFinLabel.Size = new System.Drawing.Size(53, 16);
            sesFinLabel.TabIndex = 4;
            sesFinLabel.Text = "Date fin";
            // 
            // intituleLabel
            // 
            intituleLabel.AutoSize = true;
            intituleLabel.Location = new System.Drawing.Point(55, 53);
            intituleLabel.Name = "intituleLabel";
            intituleLabel.Size = new System.Drawing.Size(26, 16);
            intituleLabel.TabIndex = 5;
            intituleLabel.Text = "Ue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAnnuler);
            this.groupBox2.Controls.Add(this.bEnregistrer);
            this.groupBox2.Controls.Add(intituleLabel);
            this.groupBox2.Controls.Add(this.cbUe);
            this.groupBox2.Controls.Add(sesDebLabel);
            this.groupBox2.Controls.Add(this.dtpDeb);
            this.groupBox2.Controls.Add(sesFinLabel);
            this.groupBox2.Controls.Add(this.dtpFin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 308);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter Session";
            // 
            // cbUe
            // 
            this.cbUe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbUe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUe, "Intitule", true));
            this.cbUe.DataSource = this.bsUe;
            this.cbUe.DisplayMember = "Intitule";
            this.cbUe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUe.FormattingEnabled = true;
            this.cbUe.Location = new System.Drawing.Point(135, 48);
            this.cbUe.Name = "cbUe";
            this.cbUe.Size = new System.Drawing.Size(330, 24);
            this.cbUe.TabIndex = 1;
            this.cbUe.ValueMember = "UeId";
            this.cbUe.SelectedIndexChanged += new System.EventHandler(this.cbUe_SelectedIndexChanged);
            // 
            // bsUe
            // 
            this.bsUe.DataSource = typeof(DTO.Ue);
            // 
            // dtpDeb
            // 
            this.dtpDeb.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSes, "SesDeb", true));
            this.dtpDeb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDeb.Location = new System.Drawing.Point(689, 53);
            this.dtpDeb.Name = "dtpDeb";
            this.dtpDeb.Size = new System.Drawing.Size(263, 22);
            this.dtpDeb.TabIndex = 2;
            this.dtpDeb.ValueChanged += new System.EventHandler(this.dtpDeb_ValueChanged);
            // 
            // bsSes
            // 
            this.bsSes.DataSource = typeof(DTO.Session);
            // 
            // dtpFin
            // 
            this.dtpFin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSes, "SesFin", true));
            this.dtpFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFin.Location = new System.Drawing.Point(689, 176);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(263, 22);
            this.dtpFin.TabIndex = 3;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.Location = new System.Drawing.Point(521, 258);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(109, 31);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(406, 258);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(109, 31);
            this.bEnregistrer.TabIndex = 4;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // UC_CRUP_SESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_CRUP_SESS";
            this.Size = new System.Drawing.Size(1047, 758);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bsSes;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.ComboBox cbUe;
        private System.Windows.Forms.BindingSource bsUe;
        private System.Windows.Forms.DateTimePicker dtpDeb;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}
