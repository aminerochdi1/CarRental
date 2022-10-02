namespace WindowsFormsApp2
{
    partial class register
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_usern = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_ajouter = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_supr = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_modifier = new MaterialSkin.Controls.MaterialFlatButton();
            this.Login = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.username,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(131, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1536, 841);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 12;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 12;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 12;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // input_usern
            // 
            this.input_usern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_usern.Location = new System.Drawing.Point(2061, 436);
            this.input_usern.Name = "input_usern";
            this.input_usern.Size = new System.Drawing.Size(297, 38);
            this.input_usern.TabIndex = 8;
            // 
            // input_name
            // 
            this.input_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_name.Location = new System.Drawing.Point(2061, 343);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(297, 38);
            this.input_name.TabIndex = 7;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1777, 428);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 42);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1777, 339);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 42);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Nom";
            // 
            // input_pass
            // 
            this.input_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_pass.Location = new System.Drawing.Point(2061, 525);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(297, 38);
            this.input_pass.TabIndex = 10;
            this.input_pass.TextChanged += new System.EventHandler(this.input_pass_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(1777, 518);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(183, 42);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Password";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.AutoSize = true;
            this.btn_ajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ajouter.Depth = 0;
            this.btn_ajouter.Icon = null;
            this.btn_ajouter.Location = new System.Drawing.Point(1855, 642);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Primary = false;
            this.btn_ajouter.Size = new System.Drawing.Size(177, 36);
            this.btn_ajouter.TabIndex = 11;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supr
            // 
            this.btn_supr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supr.AutoSize = true;
            this.btn_supr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_supr.Depth = 0;
            this.btn_supr.Icon = null;
            this.btn_supr.Location = new System.Drawing.Point(2057, 642);
            this.btn_supr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_supr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_supr.Name = "btn_supr";
            this.btn_supr.Primary = false;
            this.btn_supr.Size = new System.Drawing.Size(217, 36);
            this.btn_supr.TabIndex = 12;
            this.btn_supr.Text = "Supprimer";
            this.btn_supr.UseVisualStyleBackColor = true;
            this.btn_supr.Click += new System.EventHandler(this.btn_supr_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modifier.AutoSize = true;
            this.btn_modifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_modifier.Depth = 0;
            this.btn_modifier.Icon = null;
            this.btn_modifier.Location = new System.Drawing.Point(2299, 642);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Primary = false;
            this.btn_modifier.Size = new System.Drawing.Size(183, 36);
            this.btn_modifier.TabIndex = 13;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.AutoSize = true;
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.Depth = 0;
            this.Login.Icon = null;
            this.Login.Location = new System.Drawing.Point(2106, 748);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.Primary = false;
            this.Login.Size = new System.Drawing.Size(127, 36);
            this.Login.TabIndex = 14;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2632, 1159);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_supr);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.input_pass);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.input_usern);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox input_usern;
        private System.Windows.Forms.TextBox input_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox input_pass;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btn_ajouter;
        private MaterialSkin.Controls.MaterialFlatButton btn_supr;
        private MaterialSkin.Controls.MaterialFlatButton btn_modifier;
        private MaterialSkin.Controls.MaterialFlatButton Login;
    }
}