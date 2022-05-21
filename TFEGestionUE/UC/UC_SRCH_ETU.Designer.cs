namespace TFEGestionUE.UC
{
    partial class UC_SRCH_ETU
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.bsSection = new System.Windows.Forms.BindingSource(this.components);
            this.bsPersonne = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.bAjouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.bTrouver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            personneNomLabel = new System.Windows.Forms.Label();
            personnePrenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personneNomLabel
            // 
            personneNomLabel.AutoSize = true;
            personneNomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personneNomLabel.Location = new System.Drawing.Point(20, 23);
            personneNomLabel.Name = "personneNomLabel";
            personneNomLabel.Size = new System.Drawing.Size(37, 16);
            personneNomLabel.TabIndex = 7;
            personneNomLabel.Text = "Nom";
            // 
            // personnePrenomLabel
            // 
            personnePrenomLabel.AutoSize = true;
            personnePrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personnePrenomLabel.Location = new System.Drawing.Point(20, 52);
            personnePrenomLabel.Name = "personnePrenomLabel";
            personnePrenomLabel.Size = new System.Drawing.Size(55, 16);
            personnePrenomLabel.TabIndex = 9;
            personnePrenomLabel.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panneau de recherche";
            // 
            // cbSection
            // 
            this.cbSection.BackColor = System.Drawing.SystemColors.Window;
            this.cbSection.DataSource = this.bsSection;
            this.cbSection.DisplayMember = "SecDescription";
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(12, 171);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(487, 24);
            this.cbSection.TabIndex = 1;
            this.cbSection.Tag = "cbSection";
            this.cbSection.ValueMember = "SecId";
            this.cbSection.SelectedIndexChanged += new System.EventHandler(this.cbSectionSelectedIndexChanged);
            // 
            // bsSection
            // 
            this.bsSection.DataSource = typeof(DTO.Section);
            // 
            // bsPersonne
            // 
            this.bsPersonne.DataSource = typeof(DTO.Personne);
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToAddRows = false;
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.AllowUserToResizeColumns = false;
            this.dgvPersonne.AllowUserToResizeRows = false;
            this.dgvPersonne.AutoGenerateColumns = false;
            this.dgvPersonne.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvPersonne.DataSource = this.bsPersonne;
            this.dgvPersonne.Location = new System.Drawing.Point(12, 296);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.ReadOnly = true;
            this.dgvPersonne.RowHeadersVisible = false;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(487, 613);
            this.dgvPersonne.TabIndex = 2;
            this.dgvPersonne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListePersonneCellClick);
            // 
            // bAjouter
            // 
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.Location = new System.Drawing.Point(377, 917);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(122, 37);
            this.bAjouter.TabIndex = 3;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouterClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::TFEGestionUE.Properties.Resources.LAST2;
            this.pictureBox1.Location = new System.Drawing.Point(188, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonneNom", true));
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(81, 20);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(174, 22);
            this.tbNom.TabIndex = 8;
            // 
            // bTrouver
            // 
            this.bTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTrouver.Location = new System.Drawing.Point(374, 31);
            this.bTrouver.Name = "bTrouver";
            this.bTrouver.Size = new System.Drawing.Size(104, 30);
            this.bTrouver.TabIndex = 11;
            this.bTrouver.Text = "recherche";
            this.bTrouver.UseVisualStyleBackColor = true;
            this.bTrouver.Click += new System.EventHandler(this.bTrouver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.bTrouver);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(personnePrenomLabel);
            this.groupBox1.Controls.Add(personneNomLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonne, "PersonnePrenom", true));
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(81, 50);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(174, 22);
            this.tbPrenom.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonneId";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonneNom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersonnePrenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // UC_SRCH_ETU
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.label2);
            this.Name = "UC_SRCH_ETU";
            this.Size = new System.Drawing.Size(519, 975);
            ((System.ComponentModel.ISupportInitialize)(this.bsSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.BindingSource bsSection;
        private System.Windows.Forms.BindingSource bsPersonne;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button bTrouver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
