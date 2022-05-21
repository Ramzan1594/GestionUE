namespace TFEGestionUE.UC
{
    partial class UC_AC_ETU
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUe = new System.Windows.Forms.DataGridView();
            this.bsUe = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSesCour = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bSupSes = new System.Windows.Forms.Button();
            this.bInscrire = new System.Windows.Forms.Button();
            this.tbPourcentage = new System.Windows.Forms.TextBox();
            this.tbPourcentageDet = new System.Windows.Forms.TextBox();
            this.tbRestantes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReussies = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSesAcc = new System.Windows.Forms.DataGridView();
            this.SES_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesCour)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1027, 322);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cours";
            // 
            // dgvUe
            // 
            this.dgvUe.AllowUserToAddRows = false;
            this.dgvUe.AllowUserToDeleteRows = false;
            this.dgvUe.AllowUserToResizeColumns = false;
            this.dgvUe.AllowUserToResizeRows = false;
            this.dgvUe.AutoGenerateColumns = false;
            this.dgvUe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.dgvUe.DataSource = this.bsUe;
            this.dgvUe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUe.Location = new System.Drawing.Point(3, 18);
            this.dgvUe.Name = "dgvUe";
            this.dgvUe.ReadOnly = true;
            this.dgvUe.RowHeadersVisible = false;
            this.dgvUe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUe.Size = new System.Drawing.Size(1021, 301);
            this.dgvUe.TabIndex = 0;
            // 
            // bsUe
            // 
            this.bsUe.DataSource = typeof(DTO.Ue);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSesCour);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 300);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sessions en cours";
            // 
            // dgvSesCour
            // 
            this.dgvSesCour.AllowUserToAddRows = false;
            this.dgvSesCour.AllowUserToDeleteRows = false;
            this.dgvSesCour.AllowUserToResizeColumns = false;
            this.dgvSesCour.AllowUserToResizeRows = false;
            this.dgvSesCour.AutoGenerateColumns = false;
            this.dgvSesCour.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSesCour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesCour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SES_ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dgvSesCour.DataSource = this.bsUe;
            this.dgvSesCour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSesCour.Location = new System.Drawing.Point(3, 18);
            this.dgvSesCour.Name = "dgvSesCour";
            this.dgvSesCour.ReadOnly = true;
            this.dgvSesCour.RowHeadersVisible = false;
            this.dgvSesCour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSesCour.Size = new System.Drawing.Size(493, 279);
            this.dgvSesCour.TabIndex = 1;
            this.dgvSesCour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSesCour_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bSupSes);
            this.groupBox6.Controls.Add(this.bInscrire);
            this.groupBox6.Controls.Add(this.tbPourcentage);
            this.groupBox6.Controls.Add(this.tbPourcentageDet);
            this.groupBox6.Controls.Add(this.tbRestantes);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.tbReussies);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(5, 636);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1027, 118);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultats";
            // 
            // bSupSes
            // 
            this.bSupSes.Enabled = false;
            this.bSupSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupSes.Location = new System.Drawing.Point(907, 64);
            this.bSupSes.Name = "bSupSes";
            this.bSupSes.Size = new System.Drawing.Size(100, 31);
            this.bSupSes.TabIndex = 47;
            this.bSupSes.Text = "Supprimer";
            this.bSupSes.UseVisualStyleBackColor = true;
            this.bSupSes.Click += new System.EventHandler(this.bSupSes_Click);
            // 
            // bInscrire
            // 
            this.bInscrire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bInscrire.Enabled = false;
            this.bInscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInscrire.Location = new System.Drawing.Point(907, 24);
            this.bInscrire.Name = "bInscrire";
            this.bInscrire.Size = new System.Drawing.Size(100, 31);
            this.bInscrire.TabIndex = 20;
            this.bInscrire.Text = "Inscrire";
            this.bInscrire.UseVisualStyleBackColor = false;
            this.bInscrire.Click += new System.EventHandler(this.bInscrireClick);
            // 
            // tbPourcentage
            // 
            this.tbPourcentage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPourcentage.Location = new System.Drawing.Point(610, 74);
            this.tbPourcentage.Name = "tbPourcentage";
            this.tbPourcentage.ReadOnly = true;
            this.tbPourcentage.Size = new System.Drawing.Size(123, 22);
            this.tbPourcentage.TabIndex = 19;
            // 
            // tbPourcentageDet
            // 
            this.tbPourcentageDet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPourcentageDet.Location = new System.Drawing.Point(610, 28);
            this.tbPourcentageDet.Name = "tbPourcentageDet";
            this.tbPourcentageDet.ReadOnly = true;
            this.tbPourcentageDet.Size = new System.Drawing.Size(123, 22);
            this.tbPourcentageDet.TabIndex = 18;
            // 
            // tbRestantes
            // 
            this.tbRestantes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRestantes.Location = new System.Drawing.Point(204, 76);
            this.tbRestantes.Name = "tbRestantes";
            this.tbRestantes.ReadOnly = true;
            this.tbRestantes.Size = new System.Drawing.Size(123, 22);
            this.tbRestantes.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pourcentage pondéré";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pourcentage pondéré déterminant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres de ue restantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombres de ue réussies";
            // 
            // tbReussies
            // 
            this.tbReussies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbReussies.Location = new System.Drawing.Point(204, 28);
            this.tbReussies.Name = "tbReussies";
            this.tbReussies.ReadOnly = true;
            this.tbReussies.Size = new System.Drawing.Size(123, 22);
            this.tbReussies.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSesAcc);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(514, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(518, 300);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sessions accessibles";
            // 
            // dgvSesAcc
            // 
            this.dgvSesAcc.AllowUserToAddRows = false;
            this.dgvSesAcc.AllowUserToDeleteRows = false;
            this.dgvSesAcc.AllowUserToResizeColumns = false;
            this.dgvSesAcc.AllowUserToResizeRows = false;
            this.dgvSesAcc.AutoGenerateColumns = false;
            this.dgvSesAcc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSesAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvSesAcc.DataSource = this.bsUe;
            this.dgvSesAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSesAcc.Location = new System.Drawing.Point(3, 18);
            this.dgvSesAcc.Name = "dgvSesAcc";
            this.dgvSesAcc.ReadOnly = true;
            this.dgvSesAcc.RowHeadersVisible = false;
            this.dgvSesAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSesAcc.Size = new System.Drawing.Size(512, 279);
            this.dgvSesAcc.TabIndex = 0;
            this.dgvSesAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessAccesCellContentClick);
            // 
            // SES_ID
            // 
            this.SES_ID.DataPropertyName = "SES_ID";
            this.SES_ID.HeaderText = "SES_ID";
            this.SES_ID.Name = "SES_ID";
            this.SES_ID.ReadOnly = true;
            this.SES_ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Intitule";
            this.dataGridViewTextBoxColumn4.FillWeight = 170F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Determinante";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Det";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SessDeb";
            this.dataGridViewTextBoxColumn5.HeaderText = "Début";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SessFin";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Intitule";
            this.dataGridViewTextBoxColumn9.FillWeight = 170F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Determinante";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Det";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SessDeb";
            this.dataGridViewTextBoxColumn14.HeaderText = "Début";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SessFin";
            this.dataGridViewTextBoxColumn15.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Intitule";
            this.dataGridViewTextBoxColumn2.FillWeight = 170F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Determinante";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Det";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Periode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Periode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Situation";
            this.dataGridViewTextBoxColumn6.HeaderText = "Situation";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UC_AC_ETU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Name = "UC_AC_ETU";
            this.Size = new System.Drawing.Size(1042, 758);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUe)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesCour)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvUe;
        private System.Windows.Forms.BindingSource bsUe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bInscrire;
        private System.Windows.Forms.TextBox tbPourcentage;
        private System.Windows.Forms.TextBox tbPourcentageDet;
        private System.Windows.Forms.TextBox tbRestantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReussies;
        private System.Windows.Forms.DataGridView dgvSesCour;
        private System.Windows.Forms.DataGridView dgvSesAcc;
        private System.Windows.Forms.Button bSupSes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SES_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}
