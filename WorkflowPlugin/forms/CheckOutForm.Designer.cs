namespace com.darius.workflow.forms
{
    partial class CheckOutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelGevoel = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxGevoel = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.LabelWat = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxPlanned = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.submit = new MaterialSkin.Controls.MaterialButton();
            this.cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // LabelGevoel
            // 
            this.LabelGevoel.Depth = 0;
            this.LabelGevoel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelGevoel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LabelGevoel.Location = new System.Drawing.Point(17, 82);
            this.LabelGevoel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelGevoel.Name = "LabelGevoel";
            this.LabelGevoel.Size = new System.Drawing.Size(260, 35);
            this.LabelGevoel.TabIndex = 2;
            this.LabelGevoel.Text = "Hoe voel je?";
            // 
            // TextBoxGevoel
            // 
            this.TextBoxGevoel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBoxGevoel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxGevoel.Depth = 0;
            this.TextBoxGevoel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxGevoel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBoxGevoel.Location = new System.Drawing.Point(7, 134);
            this.TextBoxGevoel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxGevoel.Name = "TextBoxGevoel";
            this.TextBoxGevoel.Size = new System.Drawing.Size(787, 77);
            this.TextBoxGevoel.TabIndex = 3;
            this.TextBoxGevoel.Text = "";
            // 
            // LabelWat
            // 
            this.LabelWat.Depth = 0;
            this.LabelWat.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelWat.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LabelWat.Location = new System.Drawing.Point(6, 233);
            this.LabelWat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelWat.Name = "LabelWat";
            this.LabelWat.Size = new System.Drawing.Size(260, 35);
            this.LabelWat.TabIndex = 4;
            this.LabelWat.Text = "Wat ga ik doen?";
            // 
            // TextBoxPlanned
            // 
            this.TextBoxPlanned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBoxPlanned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPlanned.Depth = 0;
            this.TextBoxPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPlanned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBoxPlanned.Location = new System.Drawing.Point(7, 283);
            this.TextBoxPlanned.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxPlanned.Name = "TextBoxPlanned";
            this.TextBoxPlanned.Size = new System.Drawing.Size(787, 92);
            this.TextBoxPlanned.TabIndex = 5;
            this.TextBoxPlanned.Text = "";
            // 
            // submit
            // 
            this.submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submit.Depth = 0;
            this.submit.HighEmphasis = true;
            this.submit.Icon = null;
            this.submit.Location = new System.Drawing.Point(6, 405);
            this.submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.submit.Name = "submit";
            this.submit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submit.Size = new System.Drawing.Size(75, 36);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submit.UseAccentColor = false;
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancel.Depth = 0;
            this.cancel.HighEmphasis = true;
            this.cancel.Icon = null;
            this.cancel.Location = new System.Drawing.Point(141, 405);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel.Name = "cancel";
            this.cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel.Size = new System.Drawing.Size(77, 36);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel.UseAccentColor = false;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.TextBoxPlanned);
            this.Controls.Add(this.LabelWat);
            this.Controls.Add(this.TextBoxGevoel);
            this.Controls.Add(this.LabelGevoel);
            this.Name = "CheckInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton cancel;

        private MaterialSkin.Controls.MaterialButton materialButton1;

        private MaterialSkin.Controls.MaterialButton submit;

        private MaterialSkin.Controls.MaterialMultiLineTextBox TextBoxPlanned;

        private MaterialSkin.Controls.MaterialMultiLineTextBox TextBoxGevoel;
        private MaterialSkin.Controls.MaterialLabel LabelWat;

        private MaterialSkin.Controls.MaterialLabel LabelGevoel;

        #endregion
    }
}