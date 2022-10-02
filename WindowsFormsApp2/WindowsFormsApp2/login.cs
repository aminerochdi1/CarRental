using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class login :MaterialForm
    {
        public login()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE)
                ;
            input_password.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        bool tr;
        private void Btn_submit_Click(object sender, EventArgs e)
        {
          /*  SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            //check();
            cmd = new SqlCommand("SELECT username,password from [user]", cnx);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (input_username.Text.ToString().Equals(dr[0]) && input_password.Text.ToString().Equals(dr[0]))
                {
                    tr = true;
                    break;
                }
            }
            if (tr == true)
            {
                this.Hide();
                input_nation f = new input_nation();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!\nPlease enter a valid username and password to continue.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            cnx.Close();*/

            if(input_username.Text=="rochdi" && input_password.Text=="ROCHDI")
            {
                this.Hide();
                MDM f = new MDM();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!\nPlease enter a valid username and password to continue.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (input_password.PasswordChar == '*')
            {
                //Show.BringToFront();
                input_password.PasswordChar = '\0';
            }
            else if(input_password.PasswordChar == '\0')
            {
                input_password.PasswordChar = '*';

            }
        }
    }
}
