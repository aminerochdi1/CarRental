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

namespace WindowsFormsApp2
{
    public partial class MDM : MaterialForm
    {
        public MDM()
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
        }

        private void MDM_Load(object sender, EventArgs e)
        {
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
            input_nation formident = new input_nation();
            formident.Show();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            client formident = new client();
            formident.Show();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicule formident = new vehicule();
            formident.Show();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            depannage formident = new depannage();
            formident.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            retour formident = new retour();
            formident.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            contrat formident = new contrat();
            formident.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
