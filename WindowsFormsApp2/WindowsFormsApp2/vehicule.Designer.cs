namespace WindowsFormsApp2
{
    partial class vehicule
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.input_datedenais = new MaterialSkin.Controls.MaterialLabel();
            this.input_prenom = new MaterialSkin.Controls.MaterialLabel();
            this.input_immatr = new System.Windows.Forms.TextBox();
            this.input_nom = new MaterialSkin.Controls.MaterialLabel();
            this.numero = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_submit = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_carburant = new System.Windows.Forms.ComboBox();
            this.input_disp = new System.Windows.Forms.ComboBox();
            this.input_prix = new System.Windows.Forms.ComboBox();
            this.input_model = new System.Windows.Forms.ComboBox();
            this.Nom = new MaterialSkin.Controls.MaterialLabel();
            this.inputnom = new System.Windows.Forms.ComboBox();
            this.input_prixassu = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_retourveh = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.materialLabel1.Location = new System.Drawing.Point(472, 512);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 46);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Prix";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(417, 607);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(193, 46);
            this.materialLabel2.TabIndex = 51;
            this.materialLabel2.Text = "Disponible";
            // 
            // input_datedenais
            // 
            this.input_datedenais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_datedenais.AutoSize = true;
            this.input_datedenais.BackColor = System.Drawing.Color.Transparent;
            this.input_datedenais.Depth = 0;
            this.input_datedenais.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_datedenais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_datedenais.Location = new System.Drawing.Point(369, 418);
            this.input_datedenais.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_datedenais.Name = "input_datedenais";
            this.input_datedenais.Size = new System.Drawing.Size(289, 46);
            this.input_datedenais.TabIndex = 44;
            this.input_datedenais.Text = "Prix d\'assurance";
            // 
            // input_prenom
            // 
            this.input_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_prenom.AutoSize = true;
            this.input_prenom.BackColor = System.Drawing.Color.Transparent;
            this.input_prenom.Depth = 0;
            this.input_prenom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_prenom.Location = new System.Drawing.Point(422, 317);
            this.input_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(183, 46);
            this.input_prenom.TabIndex = 43;
            this.input_prenom.Text = "Carburant";
            // 
            // input_immatr
            // 
            this.input_immatr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_immatr.Location = new System.Drawing.Point(832, 133);
            this.input_immatr.Name = "input_immatr";
            this.input_immatr.Size = new System.Drawing.Size(447, 38);
            this.input_immatr.TabIndex = 41;
            // 
            // input_nom
            // 
            this.input_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_nom.AutoSize = true;
            this.input_nom.BackColor = System.Drawing.Color.Transparent;
            this.input_nom.Depth = 0;
            this.input_nom.Font = new System.Drawing.Font("Roboto", 11F);
            this.input_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.input_nom.Location = new System.Drawing.Point(452, 226);
            this.input_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(123, 46);
            this.input_nom.TabIndex = 40;
            this.input_nom.Text = "Model";
            // 
            // numero
            // 
            this.numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.Color.Transparent;
            this.numero.Depth = 0;
            this.numero.Font = new System.Drawing.Font("Roboto", 11F);
            this.numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numero.Location = new System.Drawing.Point(374, 125);
            this.numero.MouseState = MaterialSkin.MouseState.HOVER;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(278, 46);
            this.numero.TabIndex = 39;
            this.numero.Text = "Immatriculation";
            // 
            // Btn_submit
            // 
            this.Btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_submit.AutoSize = true;
            this.Btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_submit.Depth = 0;
            this.Btn_submit.Icon = null;
            this.Btn_submit.Location = new System.Drawing.Point(460, 819);
            this.Btn_submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Primary = false;
            this.Btn_submit.Size = new System.Drawing.Size(177, 36);
            this.Btn_submit.TabIndex = 55;
            this.Btn_submit.Text = "Ajouter";
            this.Btn_submit.UseVisualStyleBackColor = true;
            this.Btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // input_carburant
            // 
            this.input_carburant.AllowDrop = true;
            this.input_carburant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_carburant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_carburant.FormattingEnabled = true;
            this.input_carburant.Items.AddRange(new object[] {
            "Essence",
            "Diesel"});
            this.input_carburant.Location = new System.Drawing.Point(832, 324);
            this.input_carburant.Name = "input_carburant";
            this.input_carburant.Size = new System.Drawing.Size(447, 39);
            this.input_carburant.TabIndex = 56;
            // 
            // input_disp
            // 
            this.input_disp.AllowDrop = true;
            this.input_disp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_disp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_disp.FormattingEnabled = true;
            this.input_disp.Items.AddRange(new object[] {
            "OUI\t\t",
            "NON"});
            this.input_disp.Location = new System.Drawing.Point(832, 607);
            this.input_disp.Name = "input_disp";
            this.input_disp.Size = new System.Drawing.Size(447, 39);
            this.input_disp.TabIndex = 57;
            // 
            // input_prix
            // 
            this.input_prix.AllowDrop = true;
            this.input_prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_prix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_prix.FormattingEnabled = true;
            this.input_prix.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.input_prix.Location = new System.Drawing.Point(832, 519);
            this.input_prix.Name = "input_prix";
            this.input_prix.Size = new System.Drawing.Size(447, 39);
            this.input_prix.TabIndex = 58;
            // 
            // input_model
            // 
            this.input_model.AllowDrop = true;
            this.input_model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_model.FormattingEnabled = true;
            this.input_model.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.input_model.Location = new System.Drawing.Point(832, 233);
            this.input_model.Name = "input_model";
            this.input_model.Size = new System.Drawing.Size(447, 39);
            this.input_model.TabIndex = 59;
            // 
            // Nom
            // 
            this.Nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.Transparent;
            this.Nom.Depth = 0;
            this.Nom.Font = new System.Drawing.Font("Roboto", 11F);
            this.Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nom.Location = new System.Drawing.Point(464, 689);
            this.Nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(99, 46);
            this.Nom.TabIndex = 60;
            this.Nom.Text = "Nom";
            // 
            // inputnom
            // 
            this.inputnom.AllowDrop = true;
            this.inputnom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputnom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputnom.FormattingEnabled = true;
            this.inputnom.Items.AddRange(new object[] {
            "Dacia LOGAN",
            "Dacia Duster",
            "Clio 4",
            "Clio Megane 3",
            "Clio CAPTUR",
            "Clio KADJAR",
            "Clio Kangoo",
            "Fiat 500 SPORT",
            "Fiat Berline",
            "Citroën C3",
            "Citroën C4",
            "Range Rover",
            "Ford Fiesta"});
            this.inputnom.Location = new System.Drawing.Point(832, 696);
            this.inputnom.Name = "inputnom";
            this.inputnom.Size = new System.Drawing.Size(447, 39);
            this.inputnom.TabIndex = 61;
            // 
            // input_prixassu
            // 
            this.input_prixassu.AllowDrop = true;
            this.input_prixassu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_prixassu.FormattingEnabled = true;
            this.input_prixassu.Items.AddRange(new object[] {
            "1200",
            "2500",
            "3400",
            "4600",
            "5600"});
            this.input_prixassu.Location = new System.Drawing.Point(832, 425);
            this.input_prixassu.Name = "input_prixassu";
            this.input_prixassu.Size = new System.Drawing.Size(447, 39);
            this.input_prixassu.TabIndex = 62;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(1130, 819);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(157, 36);
            this.materialFlatButton1.TabIndex = 63;
            this.materialFlatButton1.Text = "Retour";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btn_retourveh
            // 
            this.btn_retourveh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retourveh.AutoSize = true;
            this.btn_retourveh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_retourveh.Depth = 0;
            this.btn_retourveh.Icon = null;
            this.btn_retourveh.Location = new System.Drawing.Point(729, 819);
            this.btn_retourveh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_retourveh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_retourveh.Name = "btn_retourveh";
            this.btn_retourveh.Primary = false;
            this.btn_retourveh.Size = new System.Drawing.Size(309, 36);
            this.btn_retourveh.TabIndex = 64;
            this.btn_retourveh.Text = "Delai de retour";
            this.btn_retourveh.UseVisualStyleBackColor = true;
            this.btn_retourveh.Click += new System.EventHandler(this.btn_retourveh_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(784, 907);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(229, 36);
            this.materialFlatButton2.TabIndex = 65;
            this.materialFlatButton2.Text = "Depannage";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 1119);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btn_retourveh);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.input_prixassu);
            this.Controls.Add(this.inputnom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.input_model);
            this.Controls.Add(this.input_prix);
            this.Controls.Add(this.input_disp);
            this.Controls.Add(this.input_carburant);
            this.Controls.Add(this.Btn_submit);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.input_datedenais);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_immatr);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.numero);
            this.Name = "vehicule";
            this.Text = "vehicule";
            this.Load += new System.EventHandler(this.vehicule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel input_datedenais;
        private MaterialSkin.Controls.MaterialLabel input_prenom;
        private System.Windows.Forms.TextBox input_immatr;
        private MaterialSkin.Controls.MaterialLabel input_nom;
        private MaterialSkin.Controls.MaterialLabel numero;
        private MaterialSkin.Controls.MaterialFlatButton Btn_submit;
        private System.Windows.Forms.ComboBox input_carburant;
        private System.Windows.Forms.ComboBox input_disp;
        private System.Windows.Forms.ComboBox input_prix;
        private System.Windows.Forms.ComboBox input_model;
        private MaterialSkin.Controls.MaterialLabel Nom;
        private System.Windows.Forms.ComboBox inputnom;
        private System.Windows.Forms.ComboBox input_prixassu;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btn_retourveh;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}