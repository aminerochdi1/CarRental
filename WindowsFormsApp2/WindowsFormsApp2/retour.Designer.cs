namespace WindowsFormsApp2
{
    partial class retour
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Immatriculation = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.input_numcl = new System.Windows.Forms.ComboBox();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gest_de_locations_des_voituresDataSet1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1();
            this.input_immatr = new System.Windows.Forms.ComboBox();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gest_de_locations_des_voituresDataSet = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet();
            this.vehiculeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.input_datedeb = new System.Windows.Forms.DateTimePicker();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSetTableAdapters.clientTableAdapter();
            this.vehiculeTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSetTableAdapters.vehiculeTableAdapter();
            this.btn_ajouter = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_retour = new MaterialSkin.Controls.MaterialFlatButton();
            this.fknumèclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSetTableAdapters.contratTableAdapter();
            this.fknumèclientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSetTableAdapters.modelTableAdapter();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retourTableAdapter = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1TableAdapters.retourTableAdapter();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeTableAdapter1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1TableAdapters.vehiculeTableAdapter();
            this.clientTableAdapter1 = new WindowsFormsApp2.gest_de_locations_des_voituresDataSet1TableAdapters.clientTableAdapter();
            this.input_dateret = new System.Windows.Forms.DateTimePicker();
            this.btn_print = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fknumèclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fknumèclientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(382, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(300, 46);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Numero de client";
            // 
            // Immatriculation
            // 
            this.Immatriculation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Immatriculation.AutoSize = true;
            this.Immatriculation.BackColor = System.Drawing.Color.Transparent;
            this.Immatriculation.Depth = 0;
            this.Immatriculation.Font = new System.Drawing.Font("Roboto", 11F);
            this.Immatriculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Immatriculation.Location = new System.Drawing.Point(393, 235);
            this.Immatriculation.MouseState = MaterialSkin.MouseState.HOVER;
            this.Immatriculation.Name = "Immatriculation";
            this.Immatriculation.Size = new System.Drawing.Size(278, 46);
            this.Immatriculation.TabIndex = 2;
            this.Immatriculation.Text = "Immatriculation";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(430, 319);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(205, 46);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Date d\'ebut";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(405, 403);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(254, 46);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Date de retour";
            // 
            // input_numcl
            // 
            this.input_numcl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_numcl.DataSource = this.clientBindingSource2;
            this.input_numcl.DisplayMember = "num";
            this.input_numcl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_numcl.FormattingEnabled = true;
            this.input_numcl.Location = new System.Drawing.Point(795, 151);
            this.input_numcl.Name = "input_numcl";
            this.input_numcl.Size = new System.Drawing.Size(397, 39);
            this.input_numcl.TabIndex = 10;
            this.input_numcl.ValueMember = "cin";
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "client";
            this.clientBindingSource2.DataSource = this.gest_de_locations_des_voituresDataSet1;
            // 
            // gest_de_locations_des_voituresDataSet1
            // 
            this.gest_de_locations_des_voituresDataSet1.DataSetName = "gest_de_locations_des_voituresDataSet1";
            this.gest_de_locations_des_voituresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // input_immatr
            // 
            this.input_immatr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_immatr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehiculeBindingSource, "Immatriculation", true));
            this.input_immatr.DataSource = this.vehiculeBindingSource1;
            this.input_immatr.DisplayMember = "Immatriculation";
            this.input_immatr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_immatr.FormattingEnabled = true;
            this.input_immatr.Location = new System.Drawing.Point(795, 242);
            this.input_immatr.Name = "input_immatr";
            this.input_immatr.Size = new System.Drawing.Size(397, 39);
            this.input_immatr.TabIndex = 11;
            this.input_immatr.ValueMember = "column_nom";
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "vehicule";
            this.vehiculeBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet;
            // 
            // gest_de_locations_des_voituresDataSet
            // 
            this.gest_de_locations_des_voituresDataSet.DataSetName = "gest_de_locations_des_voituresDataSet";
            this.gest_de_locations_des_voituresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeBindingSource1
            // 
            this.vehiculeBindingSource1.DataMember = "vehicule";
            this.vehiculeBindingSource1.DataSource = this.gest_de_locations_des_voituresDataSet1;
            // 
            // input_datedeb
            // 
            this.input_datedeb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_datedeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_datedeb.Location = new System.Drawing.Point(795, 319);
            this.input_datedeb.Name = "input_datedeb";
            this.input_datedeb.Size = new System.Drawing.Size(397, 38);
            this.input_datedeb.TabIndex = 12;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.AutoSize = true;
            this.btn_ajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ajouter.Depth = 0;
            this.btn_ajouter.Icon = null;
            this.btn_ajouter.Location = new System.Drawing.Point(616, 555);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Primary = false;
            this.btn_ajouter.Size = new System.Drawing.Size(177, 36);
            this.btn_ajouter.TabIndex = 13;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retour.AutoSize = true;
            this.btn_retour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_retour.Depth = 0;
            this.btn_retour.Icon = null;
            this.btn_retour.Location = new System.Drawing.Point(833, 555);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_retour.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Primary = false;
            this.btn_retour.Size = new System.Drawing.Size(157, 36);
            this.btn_retour.TabIndex = 14;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // fknumèclientBindingSource
            // 
            this.fknumèclientBindingSource.DataMember = "fk_numèclient";
            this.fknumèclientBindingSource.DataSource = this.clientBindingSource;
            // 
            // contratTableAdapter
            // 
            this.contratTableAdapter.ClearBeforeFill = true;
            // 
            // fknumèclientBindingSource1
            // 
            this.fknumèclientBindingSource1.DataMember = "fk_numèclient";
            this.fknumèclientBindingSource1.DataSource = this.clientBindingSource;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataMember = "contrat";
            this.contratBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet;
            // 
            // retourBindingSource
            // 
            this.retourBindingSource.DataMember = "retour";
            this.retourBindingSource.DataSource = this.gest_de_locations_des_voituresDataSet1;
            // 
            // retourTableAdapter
            // 
            this.retourTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.gest_de_locations_des_voituresDataSet;
            // 
            // vehiculeTableAdapter1
            // 
            this.vehiculeTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // input_dateret
            // 
            this.input_dateret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_dateret.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_dateret.Location = new System.Drawing.Point(795, 411);
            this.input_dateret.Name = "input_dateret";
            this.input_dateret.Size = new System.Drawing.Size(397, 38);
            this.input_dateret.TabIndex = 15;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.AutoSize = true;
            this.btn_print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_print.Depth = 0;
            this.btn_print.Icon = null;
            this.btn_print.Location = new System.Drawing.Point(1030, 555);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_print.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_print.Name = "btn_print";
            this.btn_print.Primary = false;
            this.btn_print.Size = new System.Drawing.Size(184, 36);
            this.btn_print.TabIndex = 16;
            this.btn_print.Text = "Contrat";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // retour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1065);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.input_dateret);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.input_datedeb);
            this.Controls.Add(this.input_immatr);
            this.Controls.Add(this.input_numcl);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Immatriculation);
            this.Controls.Add(this.materialLabel1);
            this.Name = "retour";
            this.Text = "Prix total";
            this.Load += new System.EventHandler(this.retour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gest_de_locations_des_voituresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fknumèclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fknumèclientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Immatriculation;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox input_numcl;
        private System.Windows.Forms.ComboBox input_immatr;
        private System.Windows.Forms.DateTimePicker input_datedeb;
        private gest_de_locations_des_voituresDataSet gest_de_locations_des_voituresDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gest_de_locations_des_voituresDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private gest_de_locations_des_voituresDataSetTableAdapters.vehiculeTableAdapter vehiculeTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton btn_ajouter;
        private MaterialSkin.Controls.MaterialFlatButton btn_retour;
        private System.Windows.Forms.BindingSource fknumèclientBindingSource;
        private gest_de_locations_des_voituresDataSetTableAdapters.contratTableAdapter contratTableAdapter;
        private System.Windows.Forms.BindingSource fknumèclientBindingSource1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private gest_de_locations_des_voituresDataSetTableAdapters.modelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private gest_de_locations_des_voituresDataSet1 gest_de_locations_des_voituresDataSet1;
        private System.Windows.Forms.BindingSource retourBindingSource;
        private gest_de_locations_des_voituresDataSet1TableAdapters.retourTableAdapter retourTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource vehiculeBindingSource1;
        private gest_de_locations_des_voituresDataSet1TableAdapters.vehiculeTableAdapter vehiculeTableAdapter1;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private gest_de_locations_des_voituresDataSet1TableAdapters.clientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.DateTimePicker input_dateret;
        private MaterialSkin.Controls.MaterialFlatButton btn_print;
    }
}