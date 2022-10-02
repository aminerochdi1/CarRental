using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class depannage : MaterialForm
    {
        public depannage()
        {
            InitializeComponent();
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

        private void depannage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet1.vehicule' table. You can move, or remove it, as needed.
            this.vehiculeTableAdapter.Fill(this.gest_de_locations_des_voituresDataSet1.vehicule);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from depannage", cnx);
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
        private void afficher()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from depannage", cnx);
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

        private void input_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void vehicule_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicule formvehi = new vehicule();
            formvehi.Show();
        }

        private bool checkinfo()
        {
            if (
                this.input_matr.Text.Trim().Equals(string.Empty) ||
                this.input_adresse.Text.Trim().Equals(string.Empty) ||
                this.input_dateacc.Text.Trim().Equals(string.Empty)
                )
                return false;
            return true;

        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkinfo())
                {
                    MessageBox.Show("Vueillez saisie tous les infomations");
                    return;
                }
                //get_id();
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                cnx.Open();

                SqlCommand cmd = new SqlCommand("insert into depannage values ('" + input_matr.Text.ToString().Trim() + "','" + input_adresse.Text.Trim() + "', '" + input_dateacc.Text + "') ", cnx);
                //SqlCommand Comm1 = new SqlCommand(cmd, cnx);


                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                afficher();
                // clear_text();
                /* vehicule formvehicule = new vehicule();
                 formvehicule.Show();
                 this.Hide();*/
                cnx.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicule formveh = new vehicule();
            formveh.Show();
        }
    }
}
