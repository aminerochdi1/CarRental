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
    public partial class register : MaterialForm
    {
        public register()
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

        SqlConnection cnx = new SqlConnection();
        //cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";

        private void register_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //  afficher
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from [user]", cnx);
            cnx.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                this.dataGridView1.Rows.Clear();
                while (sdr.Read())
                {
                    this.dataGridView1.Rows.Add(sdr[0], sdr[1], sdr[2]);
                }
                cnx.Close();
            }
            else
                MessageBox.Show("le table est vide");
        }

        private bool checkinfo()
        {
            if (this.input_name.Text.Trim().Equals(string.Empty) ||
                this.input_usern.Text.Trim().Equals(string.Empty) ||
                this.input_pass.Text.Trim().Equals(string.Empty)
                )
                return false;
            return true;

        }
        bool check = false;

        private void btn_ajouter_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("insert into [user] values ('" + input_name.Text.Trim().ToLower() + "','" + input_usern.Text.Trim().ToLower() + "','" + input_pass.Text.Trim() + "' ) ", cnx);
                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                cnx.Close();
                afficher();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void afficher()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from [user]", cnx);
            cnx.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                this.dataGridView1.Rows.Clear();
                while (sdr.Read())
                {
                    this.dataGridView1.Rows.Add(sdr[0], sdr[1], sdr[2]);
                }
                cnx.Close();
            }
            else
                MessageBox.Show("le table est vide");
        }
       
        int position = -1;
        private void btn_supr_Click(object sender, EventArgs e)
        {
            // button supprimer
           /* if (position == -1)
            {
                MessageBox.Show("svp selectioner une ligne !");
                return;
            }
            //position = this.dataGridView1.CurrentRow.Index;
            //id_eleve = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());

            cnx.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Delete from [user] where username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dataGridView1.Rows.RemoveAt(position);
                MessageBox.Show("la commande est bien effectuée");
                cnx.Close();*/
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // button supprimer
           /* if (position == -1)
            {
                MessageBox.Show("svp selectioner une ligne !");
                return;
            }
            //position = this.dataGridView1.CurrentRow.Index;
            //id_eleve = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";

            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "Delete from [user] where username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.RemoveAt(position);
            MessageBox.Show("la commande est bien effectuée");
            cnx.Close();*/
        }

        private void input_pass_TextChanged(object sender, EventArgs e)
        {

            // password type
            if (input_pass.PasswordChar == '\0')
            {
                //Show.BringToFront();
                input_pass.PasswordChar = '*';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
           

            
        }

        private void Show_Click(object sender, EventArgs e)
        {

           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login formlog = new login();
            formlog.Show();
        }
    }

}
    
