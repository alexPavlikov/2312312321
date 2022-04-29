
namespace Airport_v2
{
    partial class PassengerForm
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lostButton = new MaterialSkin.Controls.MaterialButton();
            this.ticketButton = new MaterialSkin.Controls.MaterialButton();
            this.flightButton = new MaterialSkin.Controls.MaterialButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(5, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(396, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Welcome to DonFly, select the section you are interested";
            // 
            // lostButton
            // 
            this.lostButton.AutoSize = false;
            this.lostButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lostButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lostButton.Depth = 0;
            this.lostButton.HighEmphasis = true;
            this.lostButton.Icon = null;
            this.lostButton.Location = new System.Drawing.Point(7, 288);
            this.lostButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lostButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lostButton.Name = "lostButton";
            this.lostButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lostButton.Size = new System.Drawing.Size(145, 45);
            this.lostButton.TabIndex = 3;
            this.lostButton.Text = "You get lost?";
            this.toolTip1.SetToolTip(this.lostButton, "If you get lost click this button");
            this.lostButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lostButton.UseAccentColor = false;
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            this.lostButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lostButton_MouseDown);
            // 
            // ticketButton
            // 
            this.ticketButton.AutoSize = false;
            this.ticketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticketButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ticketButton.Depth = 0;
            this.ticketButton.HighEmphasis = true;
            this.ticketButton.Icon = null;
            this.ticketButton.Location = new System.Drawing.Point(256, 288);
            this.ticketButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ticketButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ticketButton.Size = new System.Drawing.Size(145, 45);
            this.ticketButton.TabIndex = 4;
            this.ticketButton.Text = "Have you lost your ticket?";
            this.toolTip1.SetToolTip(this.ticketButton, "If you lost your ticket click on button");
            this.ticketButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ticketButton.UseAccentColor = false;
            this.ticketButton.UseVisualStyleBackColor = true;
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // flightButton
            // 
            this.flightButton.AutoSize = false;
            this.flightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flightButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.flightButton.Depth = 0;
            this.flightButton.HighEmphasis = true;
            this.flightButton.Icon = null;
            this.flightButton.Location = new System.Drawing.Point(124, 345);
            this.flightButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.flightButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flightButton.Name = "flightButton";
            this.flightButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.flightButton.Size = new System.Drawing.Size(145, 45);
            this.flightButton.TabIndex = 5;
            this.flightButton.Text = "flight schedule";
            this.toolTip1.SetToolTip(this.flightButton, "If you click on the button, you will see today\'s list of departures");
            this.flightButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.flightButton.UseAccentColor = false;
            this.flightButton.UseVisualStyleBackColor = true;
            this.flightButton.Click += new System.EventHandler(this.flightButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airport_v2.Properties.Resources.fon2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 410);
            this.Controls.Add(this.flightButton);
            this.Controls.Add(this.ticketButton);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximumSize = new System.Drawing.Size(406, 410);
            this.MinimumSize = new System.Drawing.Size(406, 410);
            this.Name = "PassengerForm";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton lostButton;
        private MaterialSkin.Controls.MaterialButton ticketButton;
        private MaterialSkin.Controls.MaterialButton flightButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}