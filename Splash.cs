using System;
using System.Reflection;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            string strVersion = typeof(Splash).GetType().Assembly.GetName().Version.ToString();

            TXT_version.Text = "Version: " + Application.ProductVersion; // +" Build " + strVersion;

            Console.WriteLine(strVersion);

            if (Program.Logo != null)
            {
                this.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
            }

            Console.WriteLine("Splash .ctor");
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}