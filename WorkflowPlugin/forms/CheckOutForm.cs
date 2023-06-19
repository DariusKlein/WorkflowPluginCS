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
using WorkflowPlugin.services;

namespace com.darius.workflow.forms
{
    public partial class CheckOutForm : MaterialForm
    {
        public string GevoelText {get;set;} 
        public string PlannedText {get;set;}
        public string CompletedText {get;set;} 
        public string LearnedText {get;set;}
        public int CheckInId {get;set;}

        public CheckOutForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
            
            var response = await Api.GetCheckIn(CheckInId);

            TextBoxGevoel.Text = (string)response["planned"];
            TextBoxPlanned.Text = (string)response["gevoel"];
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.GevoelText = this.TextBoxGevoel.Text;
            this.PlannedText = this.TextBoxPlanned.Text;
            this.CompletedText = this.TextBoxCompleted.Text;
            this.LearnedText = this.TextBoxLearned.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
