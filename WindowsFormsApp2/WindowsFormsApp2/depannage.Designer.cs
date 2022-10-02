namespace WindowsFormsApp2
{
    partial class depannage
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
            this.components = new System.ComponentModel.Container();
            this.vehicule = new MaterialSkin.Controls.MaterialFlatButton();
            this.retour = new MaterialSkin.Controls.MaterialFlatButton();
            this.Btn_create = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_dateacc = new System.Windows.Forms.DateTimePicker();
            this.input_prenom = new MaterialSkin.Controls.MaterialLabel();
            this.input_adresse = new System.Windows.Forms.TextBox();
            this.input_nom = new MaterialSkin.Controls.MaterialLabel();
            this.Imm = new MaterialSkin.Controls.MaterialLabel();
            this.input_matr = new System.Windows.Forms.ComboBox();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gest_de_locations_des_voituresDataSet1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1();
            this.vehiculeTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1TableAdapters.vehiculeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Immatruculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adreesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datedac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicule
            // 
            this.vehicule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicule.AutoSize = true;
            this.vehicule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vehicule.Depth = 0;
            this.vehicule.Icon = null;
            this.vehicule.Location = new System.Drawing.Point(608, 451);
            this.vehicule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vehicule.MouseState = MaterialSkin.MouseState.HOVER;
            this.vehicule.Name = "vehicule";
            this.vehicule.Primary = false;
            this.vehicule.Size = new System.Drawing.Size(186, 36);
            this.vehicule.TabIndex = 59;
            this.vehicule.Text = "Vehicule";
            this.vehicule.UseVisualStyleBackColor = true;
            this.vehicule.Click += new System.EventHandler(this.vehicule_Click);
            // 
            // retour
            // 
            this.retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retour.AutoSize = true;
            this.retour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.retour.Depth = 0;
            this.retour.Icon = null;
            this.retour.Location = new System.Drawing.Point(825, 451);
            this.retour.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.retour.MouseState = MaterialSkin.MouseState.HOVER;
            this.retour.Name = "retour";
            this.retour.Primary = false;
            this.retour.Size = new System.Drawing.Size(157, 36);
            this.retour.TabIndex = 58;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Btn_create
            // 
            this.Btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_create.AutoSize = true;
            this.Btn_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_create.Depth = 0;
            this.Btn_create.Icon = null;
            this.Btn_create.Location = new System.Drawing.Point(423, 451);
            this.Btn_create.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_create.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Primary = false;
            this.Btn_create.Size = new System.Drawing.Size(154, 36);
            this.Btn_create.TabIndex = 53;
            this.Btn_create.Text = "Create";
            this.Btn_create.UseVisualStyleBackColor = true;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // input_dateacc
            // 
            this.input_dateacc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_dateacc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_dateacc.Location = new System.Drawing.Point(586, 301);
            this.input_dateacc.Name = "input_dateacc";
            this.input_dateacc.Size = new System.Drawing.Size(447, 38);
            this.input_dateacc.TabIndex = 52;
            // 
            // input_prenom
            // 
            this.input_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_prenom.AutoSize = true;
            this.input_prenom.BackColor = System.Drawing.Color.Transparent;
            this.input_prenom.Depth = 0;
            this.input_prenom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_prenom.Location = new System.Drawing.Point(238, 311);
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(272, 46);
            this.input_prenom.TabIndex = 45;
            this.input_prenom.Text = "Date d\'accident";
            // 
            // input_adresse
            // 
            this.input_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_adresse.Location = new System.Drawing.Point(586, 219);
            this.input_adresse.Name = "input_adresse";
            this.input_adresse.Size = new System.Drawing.Size(447, 38);
            this.input_adresse.TabIndex = 44;
            this.input_adresse.TextChanged += new System.EventHandler(this.input_adresse_TextChanged);
            // 
            // input_nom
            // 
            this.input_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_nom.AutoSize = true;
            this.input_nom.BackColor = System.Drawing.Color.Transparent;
            this.input_nom.Depth = 0;
            this.input_nom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_nom.Location = new System.Drawing.Point(296, 219);
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(156, 46);
            this.input_nom.TabIndex = 42;
            this.input_nom.Text = "Adresse";
            // 
            // Imm
            // 
            this.Imm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imm.AutoSize = true;
            this.Imm.BackColor = System.Drawing.Color.Transparent;
            this.Imm.Depth = 0;
            this.Imm.Font = new System.Drawing.Font("Roboto", 11F);
            this.Imm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Imm.Location = new System.Drawing.Point(235, 118);
            this.Imm.MouseState = MaterialSkin.MouseState.HOVER;
            this.Imm.Name = "Imm";
            this.Imm.Size = new System.Drawing.Size(278, 46);
            this.Imm.TabIndex = 41;
            this.Imm.Text = "Immatricualtion";
            // 
            // input_matr
            // 
            this.input_matr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_matr.DataSource = this.vehiculeBindingSource;
            this.input_matr.DisplayMember = "Immatriculation";
            this.input_matr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_matr.FormattingEnabled = true;
            this.input_matr.Location = new System.Drawing.Point(586, 123);
            this.input_matr.Name = "input_matr";
            this.input_matr.Size = new System.Drawing.Size(447, 39);
            this.input_matr.TabIndex = 60;
            this.input_matr.ValueMember = "column_nom";
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "vehicule";
            this.vehiculeBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet1;
            // 
            // gest_de_locations_des_voituresDataSet1
            // 
            this.gest_de_locations_des_voituresDataSet1.DataSetName = "gest_de_locations_des_voituresDataSet1";
            this.gest_de_locations_des_voituresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Immatruculation,
            this.Adreesse,
            this.Datedac});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1153, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 826);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Immatruculation
            // 
            this.Immatruculation.HeaderText = "Immatruculation";
            this.Immatruculation.MinimumWidth = 12;
            this.Immatruculation.Name = "Immatruculation";
            // 
            // Adreesse
            // 
            this.Adreesse.HeaderText = "Adresse";
            this.Adreesse.MinimumWidth = 12;
            this.Adreesse.Name = "Adreesse";
            // 
            // Datedac
            // 
            this.Datedac.HeaderText = "Date d\'accident";
            this.Datedac.MinimumWidth = 12;
            this.Datedac.Name = "Datedac";
            // 
            // depannage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2359, 1087);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.input_matr);
            this.Controls.Add(this.vehicule);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.input_dateacc);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_adresse);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.Imm);
            this.Name = "depannage";
            this.Text = "depannage";
            this.Load += new System.EventHandler(this.depannage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton vehicule;
        private MaterialSkin.Controls.MaterialFlatButton retour;
        private MaterialSkin.Controls.MaterialFlatButton Btn_create;
        private System.Windows.Forms.DateTimePicker input_dateacc;
        private MaterialSkin.Controls.MaterialLabel input_prenom;
        private System.Windows.Forms.TextBox input_adresse;
        private MaterialSkin.Controls.MaterialLabel input_nom;
        private MaterialSkin.Controls.MaterialLabel Imm;
        private System.Windows.Forms.ComboBox input_matr;
        private gest_de_locations_des_voituresDataSet1 gest_de_locations_des_voituresDataSet1;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private gest_de_locations_des_voituresDataSet1TableAdapters.vehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatruculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adreesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datedac;
    }
}