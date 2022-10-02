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
    public partial class input_nation : MaterialForm
    {
        public input_nation()
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
                TextShade.WHITE
            );
        }

        private void identite_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private bool checkinfo()
        {
            if (this.input_cin.Text.Trim().Equals(string.Empty) ||
                this.inputnom.Text.Trim().Equals(string.Empty) ||
                this.inputprenom.Text.Trim().Equals(string.Empty) ||
                this.inputdatenai.Text.Trim().Equals(string.Empty) ||
                this.inputville.Text.Trim().Equals(string.Empty) ||
                this.input_nationalite.Text.Trim().Equals(string.Empty)
                )
                return false;
            return true;

        }

        private void clear_text()
        {
            this.input_cin.Clear();
            this.inputnom.Clear();
            this.inputprenom.Clear();
            this.inputville.Clear();
            this.input_nationalite.Clear();
            this.input_cin.Focus();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            // button ajouter

            try
            {
                if (!checkinfo())
                {
                    MessageBox.Show("Vueillez saisie tous les infomations");
                    return;
                }
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into identite values ('" + input_cin.Text.Trim().ToLower() + "','" + inputnom.Text.Trim().ToLower() + "','" + inputprenom.Text.Trim() + "', '" + inputdatenai.Text + "','" + inputville.Text + "','" + input_nationalite.Text + "' ) ", cnx); ;
                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                cnx.Close();
                clear_text();
                client formclient = new client();
                formclient.Show();
                this.Hide();
                //afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            login formlog = new login();
            formlog.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            client clform = new client();
            clform.Show();
        }
    }
}
