namespace TFEGestionUE.UC
{
    partial class UC_DISP_SS
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSesCour = new System.Windows.Forms.DataGridView();
            this.bsSession = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSea = new System.Windows.Forms.DataGridView();
            this.bsSeance = new System.Windows.Forms.BindingSource(this.components);
            this.bSupSea = new System.Windows.Forms.Button();
            this.bSupSes = new System.Windows.Forms.Button();
            this.SesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesDebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaDateDebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaDateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaJourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaCreneauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaFKSesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesCour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSession)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSesCour);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1008, 309);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sessions ";
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
            this.SesId,
            this.Intitule,
            this.sesDebDataGridViewTextBoxColumn,
            this.sesFinDataGridViewTextBoxColumn});
            this.dgvSesCour.DataSource = this.bsSession;
            this.dgvSesCour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSesCour.Location = new System.Drawing.Point(3, 18);
            this.dgvSesCour.Name = "dgvSesCour";
            this.dgvSesCour.ReadOnly = true;
            this.dgvSesCour.RowHeadersVisible = false;
            this.dgvSesCour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSesCour.Size = new System.Drawing.Size(1002, 288);
            this.dgvSesCour.TabIndex = 1;
            this.dgvSesCour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSessionCellClick);
            // 
            // bsSession
            // 
            this.bsSession.DataSource = typeof(DTO.Session);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 309);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seances";
            // 
            // dgvSea
            // 
            this.dgvSea.AllowUserToAddRows = false;
            this.dgvSea.AllowUserToDeleteRows = false;
            this.dgvSea.AllowUserToResizeColumns = false;
            this.dgvSea.AllowUserToResizeRows = false;
            this.dgvSea.AutoGenerateColumns = false;
            this.dgvSea.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seaIdDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn,
            this.seaDateDebDataGridViewTextBoxColumn,
            this.seaDateFinDataGridViewTextBoxColumn,
            this.seaJourDataGridViewTextBoxColumn,
            this.seaCreneauDataGridViewTextBoxColumn,
            this.seaFKSesDataGridViewTextBoxColumn});
            this.dgvSea.DataSource = this.bsSeance;
            this.dgvSea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSea.Location = new System.Drawing.Point(3, 18);
            this.dgvSea.Name = "dgvSea";
            this.dgvSea.ReadOnly = true;
            this.dgvSea.RowHeadersVisible = false;
            this.dgvSea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSea.Size = new System.Drawing.Size(1002, 288);
            this.dgvSea.TabIndex = 1;
            this.dgvSea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSea_CellContentClick);
            // 
            // bsSeance
            // 
            this.bsSeance.DataSource = typeof(DTO.Seance);
            // 
            // bSupSea
            // 
            this.bSupSea.Enabled = false;
            this.bSupSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupSea.Location = new System.Drawing.Point(471, 698);
            this.bSupSea.Name = "bSupSea";
            this.bSupSea.Size = new System.Drawing.Size(100, 31);
            this.bSupSea.TabIndex = 46;
            this.bSupSea.Text = "Supprimer";
            this.bSupSea.UseVisualStyleBackColor = true;
            this.bSupSea.Click += new System.EventHandler(this.bSupSea_Click);
            // 
            // bSupSes
            // 
            this.bSupSes.Enabled = false;
            this.bSupSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupSes.Location = new System.Drawing.Point(471, 333);
            this.bSupSes.Name = "bSupSes";
            this.bSupSes.Size = new System.Drawing.Size(100, 31);
            this.bSupSes.TabIndex = 47;
            this.bSupSes.Text = "Supprimer";
            this.bSupSes.UseVisualStyleBackColor = true;
            this.bSupSes.Click += new System.EventHandler(this.bSupSes_Click);
            // 
            // SesId
            // 
            this.SesId.DataPropertyName = "SesId";
            this.SesId.HeaderText = "SesId";
            this.SesId.Name = "SesId";
            this.SesId.ReadOnly = true;
            this.SesId.Visible = false;
            // 
            // Intitule
            // 
            this.Intitule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intitule.DataPropertyName = "Intitule";
            this.Intitule.HeaderText = "Intitulé";
            this.Intitule.Name = "Intitule";
            this.Intitule.ReadOnly = true;
            // 
            // sesDebDataGridViewTextBoxColumn
            // 
            this.sesDebDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sesDebDataGridViewTextBoxColumn.DataPropertyName = "SesDeb";
            this.sesDebDataGridViewTextBoxColumn.HeaderText = "Date début";
            this.sesDebDataGridViewTextBoxColumn.Name = "sesDebDataGridViewTextBoxColumn";
            this.sesDebDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sesFinDataGridViewTextBoxColumn
            // 
            this.sesFinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sesFinDataGridViewTextBoxColumn.DataPropertyName = "SesFin";
            this.sesFinDataGridViewTextBoxColumn.HeaderText = "Date fin";
            this.sesFinDataGridViewTextBoxColumn.Name = "sesFinDataGridViewTextBoxColumn";
            this.sesFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seaIdDataGridViewTextBoxColumn
            // 
            this.seaIdDataGridViewTextBoxColumn.DataPropertyName = "SeaId";
            this.seaIdDataGridViewTextBoxColumn.HeaderText = "SeaId";
            this.seaIdDataGridViewTextBoxColumn.Name = "seaIdDataGridViewTextBoxColumn";
            this.seaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.seaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "Intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "Intitulé";
            this.intituleDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.ReadOnly = true;
            this.intituleDataGridViewTextBoxColumn.Width = 150;
            // 
            // seaDateDebDataGridViewTextBoxColumn
            // 
            this.seaDateDebDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seaDateDebDataGridViewTextBoxColumn.DataPropertyName = "SeaDateDeb";
            this.seaDateDebDataGridViewTextBoxColumn.HeaderText = "Date début";
            this.seaDateDebDataGridViewTextBoxColumn.Name = "seaDateDebDataGridViewTextBoxColumn";
            this.seaDateDebDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seaDateFinDataGridViewTextBoxColumn
            // 
            this.seaDateFinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seaDateFinDataGridViewTextBoxColumn.DataPropertyName = "SeaDateFin";
            this.seaDateFinDataGridViewTextBoxColumn.HeaderText = "Date fin";
            this.seaDateFinDataGridViewTextBoxColumn.Name = "seaDateFinDataGridViewTextBoxColumn";
            this.seaDateFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seaJourDataGridViewTextBoxColumn
            // 
            this.seaJourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seaJourDataGridViewTextBoxColumn.DataPropertyName = "SeaJour";
            this.seaJourDataGridViewTextBoxColumn.HeaderText = "Jour semaine";
            this.seaJourDataGridViewTextBoxColumn.Name = "seaJourDataGridViewTextBoxColumn";
            this.seaJourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seaCreneauDataGridViewTextBoxColumn
            // 
            this.seaCreneauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seaCreneauDataGridViewTextBoxColumn.DataPropertyName = "SeaCreneau";
            this.seaCreneauDataGridViewTextBoxColumn.HeaderText = "Créneau";
            this.seaCreneauDataGridViewTextBoxColumn.Name = "seaCreneauDataGridViewTextBoxColumn";
            this.seaCreneauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seaFKSesDataGridViewTextBoxColumn
            // 
            this.seaFKSesDataGridViewTextBoxColumn.DataPropertyName = "seaFKSes";
            this.seaFKSesDataGridViewTextBoxColumn.HeaderText = "seaFKSes";
            this.seaFKSesDataGridViewTextBoxColumn.Name = "seaFKSesDataGridViewTextBoxColumn";
            this.seaFKSesDataGridViewTextBoxColumn.ReadOnly = true;
            this.seaFKSesDataGridViewTextBoxColumn.Visible = false;
            // 
            // UC_DISP_SS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bSupSes);
            this.Controls.Add(this.bSupSea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "UC_DISP_SS";
            this.Size = new System.Drawing.Size(1047, 758);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesCour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSession)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSesCour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSea;
        //private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSession;
        private System.Windows.Forms.BindingSource bsSeance;
        private System.Windows.Forms.Button bSupSea;
        private System.Windows.Forms.Button bSupSes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesDebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaDateDebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaJourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaCreneauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seaFKSesDataGridViewTextBoxColumn;
    }
}
