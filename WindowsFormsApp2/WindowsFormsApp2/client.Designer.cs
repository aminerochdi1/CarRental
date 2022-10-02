namespace WindowsFormsApp2
{
    partial class client
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
            this.input_datenaissance = new System.Windows.Forms.DateTimePicker();
            this.input_rue = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.datenaiss = new MaterialSkin.Controls.MaterialLabel();
            this.inputvil = new System.Windows.Forms.TextBox();
            this.input_datedenais = new MaterialSkin.Controls.MaterialLabel();
            this.input_prenom = new MaterialSkin.Controls.MaterialLabel();
            this.input_codepos = new System.Windows.Forms.TextBox();
            this.input_nom = new MaterialSkin.Controls.MaterialLabel();
            this.numero = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_create = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_num_per = new System.Windows.Forms.TextBox();
            this.input_tele = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_cin = new System.Windows.Forms.ComboBox();
            this.identiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gest_de_locations_des_voituresDataSet2 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet2();
            this.gest_de_locations_des_voituresDataSet1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1TableAdapters.clientTableAdapter();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet2TableAdapters.clientTableAdapter();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.input_num = new System.Windows.Forms.TextBox();
            this.identiteTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet2TableAdapters.identiteTableAdapter();
            this.dataGridViewCL = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.identiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            this.SuspendLayout();
            // 
            // input_datenaissance
            // 
            this.input_datenaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_datenaissance.Location = new System.Drawing.Point(228, 457);
            this.input_datenaissance.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_datenaissance.Name = "input_datenaissance";
            this.input_datenaissance.Size = new System.Drawing.Size(170, 20);
            this.input_datenaissance.TabIndex = 33;
            // 
            // input_rue
            // 
            this.input_rue.Location = new System.Drawing.Point(228, 330);
            this.input_rue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_rue.Name = "input_rue";
            this.input_rue.Size = new System.Drawing.Size(170, 20);
            this.input_rue.TabIndex = 31;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(136, 496);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(31, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Cin";
            // 
            // datenaiss
            // 
            this.datenaiss.AutoSize = true;
            this.datenaiss.BackColor = System.Drawing.Color.Transparent;
            this.datenaiss.Depth = 0;
            this.datenaiss.Font = new System.Drawing.Font("Roboto", 11F);
            this.datenaiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datenaiss.Location = new System.Drawing.Point(99, 453);
            this.datenaiss.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.datenaiss.MouseState = MaterialSkin.MouseState.HOVER;
            this.datenaiss.Name = "datenaiss";
            this.datenaiss.Size = new System.Drawing.Size(110, 19);
            this.datenaiss.TabIndex = 29;
            this.datenaiss.Text = "Date de permis";
            // 
            // inputvil
            // 
            this.inputvil.Location = new System.Drawing.Point(228, 290);
            this.inputvil.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.inputvil.Name = "inputvil";
            this.inputvil.Size = new System.Drawing.Size(170, 20);
            this.inputvil.TabIndex = 28;
            // 
            // input_datedenais
            // 
            this.input_datedenais.AutoSize = true;
            this.input_datedenais.BackColor = System.Drawing.Color.Transparent;
            this.input_datedenais.Depth = 0;
            this.input_datedenais.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_datedenais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_datedenais.Location = new System.Drawing.Point(134, 329);
            this.input_datedenais.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.input_datedenais.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_datedenais.Name = "input_datedenais";
            this.input_datedenais.Size = new System.Drawing.Size(34, 19);
            this.input_datedenais.TabIndex = 27;
            this.input_datedenais.Text = "Rue";
            // 
            // input_prenom
            // 
            this.input_prenom.AutoSize = true;
            this.input_prenom.BackColor = System.Drawing.Color.Transparent;
            this.input_prenom.Depth = 0;
            this.input_prenom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_prenom.Location = new System.Drawing.Point(132, 287);
            this.input_prenom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(39, 19);
            this.input_prenom.TabIndex = 26;
            this.input_prenom.Text = "Ville";
            // 
            // input_codepos
            // 
            this.input_codepos.Location = new System.Drawing.Point(228, 251);
            this.input_codepos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_codepos.Name = "input_codepos";
            this.input_codepos.Size = new System.Drawing.Size(170, 20);
            this.input_codepos.TabIndex = 25;
            // 
            // input_nom
            // 
            this.input_nom.AutoSize = true;
            this.input_nom.BackColor = System.Drawing.Color.Transparent;
            this.input_nom.Depth = 0;
            this.input_nom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_nom.Location = new System.Drawing.Point(109, 249);
            this.input_nom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(90, 19);
            this.input_nom.TabIndex = 23;
            this.input_nom.Text = "Code postal";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.Color.Transparent;
            this.numero.Depth = 0;
            this.numero.Font = new System.Drawing.Font("Roboto", 11F);
            this.numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numero.Location = new System.Drawing.Point(121, 206);
            this.numero.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.numero.MouseState = MaterialSkin.MouseState.HOVER;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(63, 19);
            this.numero.TabIndex = 22;
            this.numero.Text = "Numero";
            // 
            // Btn_create
            // 
            this.Btn_create.AutoSize = true;
            this.Btn_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_create.Depth = 0;
            this.Btn_create.Icon = null;
            this.Btn_create.Location = new System.Drawing.Point(153, 540);
            this.Btn_create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_create.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Primary = false;
            this.Btn_create.Size = new System.Drawing.Size(71, 36);
            this.Btn_create.TabIndex = 34;
            this.Btn_create.Text = "Create";
            this.Btn_create.UseVisualStyleBackColor = true;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // input_num_per
            // 
            this.input_num_per.Location = new System.Drawing.Point(228, 412);
            this.input_num_per.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_num_per.Name = "input_num_per";
            this.input_num_per.Size = new System.Drawing.Size(170, 20);
            this.input_num_per.TabIndex = 38;
            // 
            // input_tele
            // 
            this.input_tele.Location = new System.Drawing.Point(228, 372);
            this.input_tele.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_tele.Name = "input_tele";
            this.input_tele.Size = new System.Drawing.Size(170, 20);
            this.input_tele.TabIndex = 37;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(88, 411);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 19);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Numero de permis";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(136, 369);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(30, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Tel";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(303, 540);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton1.TabIndex = 39;
            this.materialFlatButton1.Text = "Retour";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(222, 540);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton2.TabIndex = 40;
            this.materialFlatButton2.Text = "Vehicule";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // input_cin
            // 
            this.input_cin.DataSource = this.identiteBindingSource;
            this.input_cin.DisplayMember = "cin";
            this.input_cin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_cin.FormattingEnabled = true;
            this.input_cin.Location = new System.Drawing.Point(228, 496);
            this.input_cin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_cin.Name = "input_cin";
            this.input_cin.Size = new System.Drawing.Size(170, 21);
            this.input_cin.TabIndex = 41;
            this.input_cin.ValueMember = "cin";
            // 
            // identiteBindingSource
            // 
            this.identiteBindingSource.DataMember = "identite";
            this.identiteBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet2;
            // 
            // gest_de_locations_des_voituresDataSet2
            // 
            this.gest_de_locations_des_voituresDataSet2.DataSetName = "gest_de_locations_des_voituresDataSet2";
            this.gest_de_locations_des_voituresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gest_de_locations_des_voituresDataSet1
            // 
            this.gest_de_locations_des_voituresDataSet1.DataSetName = "gest_de_locations_des_voituresDataSet1";
            this.gest_de_locations_des_voituresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.gest_de_locations_des_voituresDataSet2;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "client";
            this.clientBindingSource2.DataSource = this.gest_de_locations_des_voituresDataSet2;
            // 
            // clientBindingSource3
            // 
            this.clientBindingSource3.DataMember = "client";
            this.clientBindingSource3.DataSource = this.gest_de_locations_des_voituresDataSet2;
            // 
            // input_num
            // 
            this.input_num.Location = new System.Drawing.Point(228, 210);
            this.input_num.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.input_num.Name = "input_num";
            this.input_num.ReadOnly = true;
            this.input_num.Size = new System.Drawing.Size(170, 20);
            this.input_num.TabIndex = 42;
            // 
            // identiteTableAdapter
            // 
            this.identiteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCL
            // 
            this.dataGridViewCL.AllowUserToAddRows = false;
            this.dataGridViewCL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCL.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.Code,
            this.vill,
            this.Rue,
            this.TEL,
            this.num_per,
            this.Dateper,
            this.cin});
            this.dataGridViewCL.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewCL.Location = new System.Drawing.Point(438, 210);
            this.dataGridViewCL.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.RowHeadersWidth = 102;
            this.dataGridViewCL.RowTemplate.Height = 40;
            this.dataGridViewCL.Size = new System.Drawing.Size(699, 272);
            this.dataGridViewCL.TabIndex = 44;
            this.dataGridViewCL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewCL.Click += new System.EventHandler(this.dataGridViewCL_Click);
            // 
            // num
            // 
            this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num.HeaderText = "Numero";
            this.num.MinimumWidth = 12;
            this.num.Name = "num";
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code postal";
            this.Code.MinimumWidth = 12;
            this.Code.Name = "Code";
            // 
            // vill
            // 
            this.vill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vill.HeaderText = "Ville";
            this.vill.MinimumWidth = 12;
            this.vill.Name = "vill";
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.MinimumWidth = 12;
            this.Rue.Name = "Rue";
            // 
            // TEL
            // 
            this.TEL.HeaderText = "TEL";
            this.TEL.MinimumWidth = 12;
            this.TEL.Name = "TEL";
            // 
            // num_per
            // 
            this.num_per.HeaderText = "Numero de Permis";
            this.num_per.MinimumWidth = 12;
            this.num_per.Name = "num_per";
            // 
            // Dateper
            // 
            this.Dateper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dateper.HeaderText = "Date de permis";
            this.Dateper.MinimumWidth = 12;
            this.Dateper.Name = "Dateper";
            // 
            // cin
            // 
            this.cin.HeaderText = "CIN";
            this.cin.MinimumWidth = 12;
            this.cin.Name = "cin";
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(205, 577);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton4.TabIndex = 45;
            this.materialFlatButton4.Text = "Chercher";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // Txtsearch
            // 
            this.Txtsearch.Location = new System.Drawing.Point(322, 582);
            this.Txtsearch.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Txtsearch.Name = "Txtsearch";
            this.Txtsearch.Size = new System.Drawing.Size(91, 20);
            this.Txtsearch.TabIndex = 46;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 623);
            this.Controls.Add(this.Txtsearch);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.dataGridViewCL);
            this.Controls.Add(this.input_num);
            this.Controls.Add(this.input_cin);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.input_num_per);
            this.Controls.Add(this.input_tele);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.input_datenaissance);
            this.Controls.Add(this.input_rue);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.datenaiss);
            this.Controls.Add(this.inputvil);
            this.Controls.Add(this.input_datedenais);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_codepos);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.numero);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "client";
            this.Text = " ";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.identiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker input_datenaissance;
        private System.Windows.Forms.TextBox input_rue;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel datenaiss;
        private System.Windows.Forms.TextBox inputvil;
        private MaterialSkin.Controls.MaterialLabel input_datedenais;
        private MaterialSkin.Controls.MaterialLabel input_prenom;
        private System.Windows.Forms.TextBox input_codepos;
        private MaterialSkin.Controls.MaterialLabel input_nom;
        private MaterialSkin.Controls.MaterialLabel numero;
        private MaterialSkin.Controls.MaterialFlatButton Btn_create;
        private System.Windows.Forms.TextBox input_num_per;
        private System.Windows.Forms.TextBox input_tele;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.ComboBox input_cin;
        private gest_de_locations_des_voituresDataSet1 gest_de_locations_des_voituresDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gest_de_locations_des_voituresDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private gest_de_locations_des_voituresDataSet2 gest_de_locations_des_voituresDataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private gest_de_locations_des_voituresDataSet2TableAdapters.clientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private System.Windows.Forms.BindingSource clientBindingSource3;
        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.BindingSource identiteBindingSource;
        private gest_de_locations_des_voituresDataSet2TableAdapters.identiteTableAdapter identiteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn vill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_per;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.TextBox Txtsearch;
    }
}