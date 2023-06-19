using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace com.darius.workflow.forms
{
    public partial class CheckInForm : MaterialForm
    {
        public string ReturnValue1 {get;set;} 
        public string ReturnValue2 {get;set;}
        public CheckInForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = this.TextBoxGevoel.Text;
            this.ReturnValue2 = this.TextBoxWat.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
