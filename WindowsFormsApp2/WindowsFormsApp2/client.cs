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
    public partial class client : MaterialForm
    {
        public client()
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
        public void get_cin()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select num,ville from client ", cnx);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                input_num.Text = sdr.GetValue(0).ToString();
                inputvil.Text = sdr.GetValue(2).ToString();

            }
            cnx.Close();
        }
        private void client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet2.identite' table. You can move, or remove it, as needed.
            this.identiteTableAdapter.Fill(this.gest_de_locations_des_voituresDataSet2.identite);
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet2.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.gest_de_locations_des_voituresDataSet2.client);
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.gest_de_locations_des_voituresDataSet1.client);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from client", cnx);
            cnx.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                this.dataGridViewCL.Rows.Clear();
                while (sdr.Read())
                {
                    this.dataGridViewCL.Rows.Add(sdr[0], sdr[1], sdr[2], sdr[3], sdr[4], sdr[5], sdr[6], sdr[7]);
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
            SqlCommand cmd = new SqlCommand("select * from client", cnx);
            cnx.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                this.dataGridViewCL.Rows.Clear();
                while (sdr.Read())
                {
                    this.dataGridViewCL.Rows.Add(sdr[0], sdr[1], sdr[2], sdr[3], sdr[4], sdr[5], sdr[6], sdr[7]);
                }
                cnx.Close();
            }
            else
                MessageBox.Show("le table est vide");
        }
        private bool checkinfo()
        {
            if (
                this.input_codepos.Text.Trim().Equals(string.Empty) ||
                this.inputvil.Text.Trim().Equals(string.Empty) ||
                this.input_rue.Text.Trim().Equals(string.Empty) ||
                this.input_tele.Text.Trim().Equals(string.Empty) ||
                this.input_num_per.Text.Trim().Equals(string.Empty) ||
                this.input_cin.Text.Trim().Equals(string.Empty)
                )
                return false;
            return true;

        }

        private void clear_text()
        {
            //this.input_num.Clear();
            this.input_codepos.Clear();
            this.inputvil.Clear();
            this.input_rue.Clear();
            this.input_tele.Clear();
            this.input_num_per.Clear();
            // this.input_cin.Clear();
            this.input_codepos.Focus();
        }

        private void get_id()
        {
            // afficher
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select num from client ", cnx);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                input_num.Text = sdr.GetValue(0).ToString();

            }
            cnx.Close();
        }
        private void Btn_create_Click(object sender, EventArgs e)
        {
            // ajouter
            try
            {
                if (!checkinfo())
                {
                    MessageBox.Show("Vueillez saisie tous les infomations");
                    return;
                }
                //get_id();
                // get_cin();
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                cnx.Open();

                SqlCommand cmd = new SqlCommand("insert into client values ('" + input_codepos.Text.Trim() + "','" + inputvil.Text.Trim() + "', '" + input_rue.Text + "','" + input_tele.Text + "','" + input_num_per.Text + "','" + input_datenaissance.Text + "','" + input_cin.Text.Trim().ToLower().ToString() + "') ", cnx);
                //SqlCommand Comm1 = new SqlCommand(cmd, cnx);


                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                afficher();
                clear_text();
                /*vehicule formvehicule = new vehicule();
                formvehicule.Show();
                this.Hide();
                cnx.Close();*/

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            input_nation formlog = new input_nation();
            formlog.Show();

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicule fromveh = new vehicule();
            fromveh.Show();
        }

        private void input_num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

           
        

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            /*// button supprimer
            try
            {
                if (position == -1)
                {
                    MessageBox.Show("svp selectioner une ligne ! ");
                    return;
                }

                //position = this.dataGridViewCL.CurrentRow.Index;
                //num = int.Parse(dataGridViewCL.Rows[position].Cells[0].Value.ToString());
                //int num;
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "Delete from client where num = @num ";
                cmd.Parameters.AddWithValue("@num", nmr);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dataGridViewCL.Rows.RemoveAt(position);
                MessageBox.Show("la commande est bien effectuée");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }

      //  int position = -1;
       // int nmr;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            position = this.dataGridViewCL.CurrentRow.Index;
            nmr = int.Parse(this.dataGridViewCL.Rows[position].Cells[0].Value.ToString());
*/
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            // button chercher

            try
            {
                if (this.Txtsearch.Text.Trim() == string.Empty)
                    return; //stop if not inputed values
                string query = "select * from client where num= @p";


                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@p", this.Txtsearch.Text.Trim());

                cnx.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    MessageBox.Show("code postal : " + sdr[1] + "\n ville : " + sdr[2] + "\n Rue : " + sdr[3] + "\n TEL: " + sdr[4] + "\n Num de permis: " + sdr[5] + "\n Date de permis: " + sdr[6] + "\n CIN: " + sdr[7]);
                }
                else
                {
                    MessageBox.Show("Le client recherché n'existe pas !! ");
                }
                cnx.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }

        private void dataGridViewCL_Click(object sender, EventArgs e)
        {
       
        }
    }
}
