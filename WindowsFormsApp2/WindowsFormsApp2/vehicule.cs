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
    public partial class vehicule : MaterialForm
    {
        public vehicule()
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

        private void vehicule_Load(object sender, EventArgs e)
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
            if (
                this.input_immatr.Text.Trim().Equals(string.Empty) ||
                //this.input_model.Text.Trim().Equals(string.Empty) ||
                this.input_prixassu.Text.Trim().Equals(string.Empty) 
                //this.input_prix.Text.Trim().Equals(string.Empty) 
                
                )
                return false;
            return true;

        }

        private void clear_text()
        {
            //this.input_num.Clear();
            this.input_immatr.Clear();
           // this.input_model.Clear();
            //this.input_prixassu.Clear();
            //this.input_prix.Clear();
            
        }
        private void Btn_submit_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("insert into vehicule values ('" + input_immatr.Text + "','" + input_model.Text + "','" + input_carburant.Text + "','" + input_prixassu.Text.ToString() + "','" + input_prix.Text.ToString() + "','"+input_disp.Text+"','"+inputnom.Text+"') ", cnx) ;
                /*cmd.Parameters.AddWithValue("@p1", "Immatriculation");
                cmd.Parameters.AddWithValue("@p2", "model");
                cmd.Parameters.AddWithValue("@p3", "carburant");
               //cmd.Parameters.AddWithValue("@p4", "assurance"); ;
                //cmd.Parameters.AddWithValue("@p5", "prix");
                cmd.Parameters.AddWithValue("@p6", "disponible");
                cmd.Parameters.AddWithValue("@p7", "column_nom");*/

                //SqlCommand Comm1 = new SqlCommand(cmd, cnx);


                int lines = cmd.ExecuteNonQuery();
                MessageBox.Show(lines + " ligne(s) est bien affectees");
                //clear_text();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            client formcl = new client();
            formcl.Show();
        }

        private void btn_retourveh_Click(object sender, EventArgs e)
        {
            this.Hide();
            retour fromret = new retour();
            fromret.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            depannage formdepana = new depannage();
            formdepana.Show();
        }
    }
}
