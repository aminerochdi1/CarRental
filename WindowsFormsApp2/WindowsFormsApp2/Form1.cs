using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;




namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Client_form_Click(object sender, EventArgs e)
        {
         
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            // materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            
            

        }

        private void contrat_form_Click(object sender, EventArgs e)
        {
            
        }

        private void voiture_form_Click(object sender, EventArgs e)
        {
           
        }

        private void fact_form_Click(object sender, EventArgs e)
        {
            
        }

        private void identite_form_Click(object sender, EventArgs e)
        {
           
        }

        private void model_form_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            // MaterialForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            //MaterialForm.ActiveForm.FormBorderStyle= FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            //Form1.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            //Form1.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            //Form1.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            //Form1.ShowDialog();

            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(1);
            if(progressBar1.Value==100)
            {
                timer1.Enabled = false;
                login formlogin = new login();
                formlogin.Show();
                this.Hide();
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
