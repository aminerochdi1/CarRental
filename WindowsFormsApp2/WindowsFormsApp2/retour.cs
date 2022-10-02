using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class retour : MaterialForm
    {
        public retour()
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

        private void retour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.gest_de_locations_des_voituresDataSet1.client);
            // TODO: This line of code loads data into the 'gest_de_locations_des_voituresDataSet1.vehicule' table. You can move, or remove it, as needed.
            this.vehiculeTableAdapter1.Fill(this.gest_de_locations_des_voituresDataSet1.vehicule);

            //this.clientTableAdapter.Fill(this.gest_de_locations_des_voituresDataSet.client);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicule formveh = new vehicule();
            formveh.Show();
        }
        private bool checkinfo()
        {
            if (this.input_numcl.Text.Trim().Equals(string.Empty) ||
                this.input_immatr.Text.Trim().Equals(string.Empty) ||
                this.input_datedeb.Text.Trim().Equals(string.Empty) ||
                this.input_dateret.Text.Trim().Equals(string.Empty) 
                )
                return false;
            return true;

        }
        
        private void btn_ajouter_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("insert into retour values ('" + input_numcl.Text.ToString().Trim() + "','" + input_immatr.Text.ToString().Trim() + "', '" + input_datedeb.Text + "','" + input_dateret.Text + "' ) ", cnx);
                //SqlCommand Comm1 = new SqlCommand(cmd, cnx);


                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                //clear_text();
                contrat formcontra = new contrat();
                formcontra.Show();
                this.Hide();
                cnx.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            this.Hide();
            contrat formcnt = new contrat();
            formcnt.Show();

                
                
                }
    }
}
