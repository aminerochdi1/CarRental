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
    public partial class contrat : MaterialForm
    {
        public contrat()
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

        private void contrat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet2.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.gest_de_locations_des_voituresDataSet2.client);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            retour formret = new retour();
            formret.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formprin = new Form2();
            formprin.Show();
        }
        private bool checkinfo()
        {
            if (//this.input_num.Text.Trim().Equals(string.Empty) ||
                //this.input_datdep.Text.Trim().Equals(string.Empty) ||
                //this.input_dateret.Text.Trim().Equals(string.Empty) ||
                //this.input_numcl.Text.Trim().Equals(string.Empty) ||
                this.input_kmdep.Text.Trim().Equals(string.Empty) ||
                this.input_kmret.Text.Trim().Equals(string.Empty) ||
                this.input_montant.Text.Trim().Equals(string.Empty)
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

                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=DESKTOP-AMINE;Initial Catalog=gest_de_locations_des_voitures;Integrated Security=True";
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into contrat values ('" + input_datdep.Text + "','" + input_dateret.Text + "','" + input_numcl.Text.ToString() + "', '" + input_kmdep.Text + "','" + input_kmret.Text + "','" + input_montant.Text + "' ) ", cnx); ;
                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                cnx.Close();
                //clear_text();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
