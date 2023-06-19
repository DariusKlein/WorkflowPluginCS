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
    public partial class CheckOutReviewForm : MaterialForm
    {
        public string GevoelText {get;set;} 
        public string PlannedText {get;set;}
        public string CompletedText {get;set;} 
        public string LearnedText {get;set;}
        public bool Scorion {get;set;}

        public int CheckInId {get;set;}

        public CheckOutReviewForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var response = await Api.GetScorionCheckIn();
            
            Text = (string)response["created"];
            CheckInId = (int)response["id"];
            TextBoxGevoel.Text = (string)response["gevoel"];
            TextBoxPlanned.Text = (string)response["planned"];
            TextBoxCompleted.Text = (string)response["completed"];
            TextBoxLearned.Text = (string)response["learned"];
            ScorionSaved.Checked = (bool)response["inScorion"];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.GevoelText = this.TextBoxGevoel.Text;
            this.PlannedText = this.TextBoxPlanned.Text;
            this.CompletedText = this.TextBoxCompleted.Text;
            this.LearnedText = this.TextBoxLearned.Text;
            this.Scorion = this.ScorionSaved.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Scorion = true;
        }
    }
}
