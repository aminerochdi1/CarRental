namespace WindowsFormsApp2
{
    partial class contrat
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
            this.input_num = new System.Windows.Forms.TextBox();
            this.Print = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_kmret = new System.Windows.Forms.TextBox();
            this.input_kmdep = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_create = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_datdep = new System.Windows.Forms.DateTimePicker();
            this.datenaiss = new MaterialSkin.Controls.MaterialLabel();
            this.input_datedenais = new MaterialSkin.Controls.MaterialLabel();
            this.input_prenom = new MaterialSkin.Controls.MaterialLabel();
            this.input_montant = new System.Windows.Forms.TextBox();
            this.input_nom = new MaterialSkin.Controls.MaterialLabel();
            this.numero = new MaterialSkin.Controls.MaterialLabel();
            this.input_dateret = new System.Windows.Forms.DateTimePicker();
            this.input_numcl = new System.Windows.Forms.ComboBox();
            this.gest_de_locations_des_voituresDataSet2 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet2TableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // input_num
            // 
            this.input_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_num.Location = new System.Drawing.Point(717, 119);
            this.input_num.Name = "input_num";
            this.input_num.ReadOnly = true;
            this.input_num.Size = new System.Drawing.Size(447, 38);
            this.input_num.TabIndex = 61;
            // 
            // Print
            // 
            this.Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Print.AutoSize = true;
            this.Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Print.Depth = 0;
            this.Print.Icon = null;
            this.Print.Location = new System.Drawing.Point(759, 827);
            this.Print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Print.MouseState = MaterialSkin.MouseState.HOVER;
            this.Print.Name = "Print";
            this.Print.Primary = false;
            this.Print.Size = new System.Drawing.Size(126, 36);
            this.Print.TabIndex = 59;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(946, 827);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(157, 36);
            this.materialFlatButton1.TabIndex = 58;
            this.materialFlatButton1.Text = "Retour";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // input_kmret
            // 
            this.input_kmret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_kmret.Location = new System.Drawing.Point(717, 601);
            this.input_kmret.Name = "input_kmret";
            this.input_kmret.Size = new System.Drawing.Size(447, 38);
            this.input_kmret.TabIndex = 57;
            // 
            // input_kmdep
            // 
            this.input_kmdep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_kmdep.Location = new System.Drawing.Point(717, 507);
            this.input_kmdep.Name = "input_kmdep";
            this.input_kmdep.Size = new System.Drawing.Size(447, 38);
            this.input_kmdep.TabIndex = 56;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(320, 601);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(378, 46);
            this.materialLabel1.TabIndex = 55;
            this.materialLabel1.Text = "Kilométrage de retour";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(348, 500);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(323, 46);
            this.materialLabel2.TabIndex = 54;
            this.materialLabel2.Text = "Kilométrage debut";
            // 
            // Btn_create
            // 
            this.Btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_create.AutoSize = true;
            this.Btn_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_create.Depth = 0;
            this.Btn_create.Icon = null;
            this.Btn_create.Location = new System.Drawing.Point(544, 827);
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
            // input_datdep
            // 
            this.input_datdep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_datdep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_datdep.Location = new System.Drawing.Point(717, 216);
            this.input_datdep.Name = "input_datdep";
            this.input_datdep.Size = new System.Drawing.Size(447, 38);
            this.input_datdep.TabIndex = 52;
            // 
            // datenaiss
            // 
            this.datenaiss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datenaiss.AutoSize = true;
            this.datenaiss.BackColor = System.Drawing.Color.Transparent;
            this.datenaiss.Depth = 0;
            this.datenaiss.Font = new System.Drawing.Font("Roboto", 11F);
            this.datenaiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datenaiss.Location = new System.Drawing.Point(431, 701);
            this.datenaiss.MouseState = MaterialSkin.MouseState.HOVER;
            this.datenaiss.Name = "datenaiss";
            this.datenaiss.Size = new System.Drawing.Size(157, 46);
            this.datenaiss.TabIndex = 49;
            this.datenaiss.Text = "Montant";
            // 
            // input_datedenais
            // 
            this.input_datedenais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_datedenais.AutoSize = true;
            this.input_datedenais.BackColor = System.Drawing.Color.Transparent;
            this.input_datedenais.Depth = 0;
            this.input_datedenais.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_datedenais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_datedenais.Location = new System.Drawing.Point(411, 405);
            this.input_datedenais.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_datedenais.Name = "input_datedenais";
            this.input_datedenais.Size = new System.Drawing.Size(196, 46);
            this.input_datedenais.TabIndex = 47;
            this.input_datedenais.Text = "Num client";
            // 
            // input_prenom
            // 
            this.input_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_prenom.AutoSize = true;
            this.input_prenom.BackColor = System.Drawing.Color.Transparent;
            this.input_prenom.Depth = 0;
            this.input_prenom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_prenom.Location = new System.Drawing.Point(382, 304);
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(254, 46);
            this.input_prenom.TabIndex = 46;
            this.input_prenom.Text = "Date de retour";
            // 
            // input_montant
            // 
            this.input_montant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_montant.Location = new System.Drawing.Point(717, 701);
            this.input_montant.Name = "input_montant";
            this.input_montant.Size = new System.Drawing.Size(447, 38);
            this.input_montant.TabIndex = 45;
            // 
            // input_nom
            // 
            this.input_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_nom.AutoSize = true;
            this.input_nom.BackColor = System.Drawing.Color.Transparent;
            this.input_nom.Depth = 0;
            this.input_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.input_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_nom.Location = new System.Drawing.Point(403, 213);
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(213, 42);
            this.input_nom.TabIndex = 44;
            this.input_nom.Text = "Date depart";
            // 
            // numero
            // 
            this.numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.Color.Transparent;
            this.numero.Depth = 0;
            this.numero.Font = new System.Drawing.Font("Roboto", 11F);
            this.numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numero.Location = new System.Drawing.Point(433, 112);
            this.numero.MouseState = MaterialSkin.MouseState.HOVER;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(152, 46);
            this.numero.TabIndex = 43;
            this.numero.Text = "Numero";
            // 
            // input_dateret
            // 
            this.input_dateret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_dateret.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_dateret.Location = new System.Drawing.Point(717, 312);
            this.input_dateret.Name = "input_dateret";
            this.input_dateret.Size = new System.Drawing.Size(447, 38);
            this.input_dateret.TabIndex = 62;
            // 
            // input_numcl
            // 
            this.input_numcl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_numcl.DataSource = this.clientBindingSource;
            this.input_numcl.DisplayMember = "num";
            this.input_numcl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_numcl.FormattingEnabled = true;
            this.input_numcl.Location = new System.Drawing.Point(717, 405);
            this.input_numcl.Name = "input_numcl";
            this.input_numcl.Size = new System.Drawing.Size(447, 39);
            this.input_numcl.TabIndex = 63;
            this.input_numcl.ValueMember = "cin";
            // 
            // gest_de_locations_des_voituresDataSet2
            // 
            this.gest_de_locations_des_voituresDataSet2.DataSetName = "gest_de_locations_des_voituresDataSet2";
            this.gest_de_locations_des_voituresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet2;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // contrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1147);
            this.Controls.Add(this.input_numcl);
            this.Controls.Add(this.input_dateret);
            this.Controls.Add(this.input_num);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.input_kmret);
            this.Controls.Add(this.input_kmdep);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.input_datdep);
            this.Controls.Add(this.datenaiss);
            this.Controls.Add(this.input_datedenais);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_montant);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.numero);
            this.Name = "contrat";
            this.Text = "contrat";
            this.Load += new System.EventHandler(this.contrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_num;
        private MaterialSkin.Controls.MaterialFlatButton Print;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.TextBox input_kmret;
        private System.Windows.Forms.TextBox input_kmdep;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton Btn_create;
        private System.Windows.Forms.DateTimePicker input_datdep;
        private MaterialSkin.Controls.MaterialLabel datenaiss;
        private MaterialSkin.Controls.MaterialLabel input_datedenais;
        private MaterialSkin.Controls.MaterialLabel input_prenom;
        private System.Windows.Forms.TextBox input_montant;
        private MaterialSkin.Controls.MaterialLabel input_nom;
        private MaterialSkin.Controls.MaterialLabel numero;
        private System.Windows.Forms.DateTimePicker input_dateret;
        private System.Windows.Forms.ComboBox input_numcl;
        private gest_de_locations_des_voituresDataSet2 gest_de_locations_des_voituresDataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gest_de_locations_des_voituresDataSet2TableAdapters.clientTableAdapter clientTableAdapter;
    }
}