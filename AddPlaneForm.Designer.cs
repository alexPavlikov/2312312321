
namespace Airport_v2
{
    partial class AddPlaneForm
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
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cargoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.passengerRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(287, 294);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(154, 49);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cargoRadioButton);
            this.groupBox2.Controls.Add(this.statusComboBox);
            this.groupBox2.Controls.Add(this.modelBox);
            this.groupBox2.Controls.Add(this.capacityBox);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.passengerRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(6, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 271);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aircraft characteristics";
            // 
            // cargoRadioButton
            // 
            this.cargoRadioButton.AutoSize = true;
            this.cargoRadioButton.Depth = 0;
            this.cargoRadioButton.Location = new System.Drawing.Point(133, 56);
            this.cargoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.cargoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cargoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargoRadioButton.Name = "cargoRadioButton";
            this.cargoRadioButton.Ripple = true;
            this.cargoRadioButton.Size = new System.Drawing.Size(77, 37);
            this.cargoRadioButton.TabIndex = 8;
            this.cargoRadioButton.TabStop = true;
            this.cargoRadioButton.Text = "Cargo";
            this.cargoRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Ready to start",
            "Waiting",
            "Repaired",
            "Flies"});
            this.statusComboBox.Location = new System.Drawing.Point(7, 223);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(214, 30);
            this.statusComboBox.TabIndex = 6;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(7, 115);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(214, 29);
            this.modelBox.TabIndex = 5;
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(6, 168);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(215, 29);
            this.capacityBox.TabIndex = 4;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(6, 200);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(47, 19);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "Status";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(6, 146);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Capacity";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(6, 92);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(45, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Model";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 34);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(36, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Type";
            // 
            // passengerRadioButton
            // 
            this.passengerRadioButton.AutoSize = true;
            this.passengerRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passengerRadioButton.Depth = 0;
            this.passengerRadioButton.Location = new System.Drawing.Point(1, 56);
            this.passengerRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.passengerRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.passengerRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.passengerRadioButton.Name = "passengerRadioButton";
            this.passengerRadioButton.Ripple = true;
            this.passengerRadioButton.Size = new System.Drawing.Size(109, 37);
            this.passengerRadioButton.TabIndex = 7;
            this.passengerRadioButton.TabStop = true;
            this.passengerRadioButton.Text = "Passenger";
            this.passengerRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionComboBox
            // 
            this.positionComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Senior pilot",
            "Juniour pilot",
            "Administrator",
            "Director",
            "Cleaner",
            "Engineer",
            "Trainee",
            "Security"});
            this.positionComboBox.Location = new System.Drawing.Point(256, 206);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(215, 29);
            this.positionComboBox.TabIndex = 9;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(253, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(253, 171);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Position";
            // 
            // nameComboBox
            // 
            this.nameComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(256, 124);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(215, 29);
            this.nameComboBox.TabIndex = 10;
            // 
            // AddPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 373);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximumSize = new System.Drawing.Size(490, 373);
            this.MinimumSize = new System.Drawing.Size(490, 373);
            this.Name = "AddPlaneForm";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Plane";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton cargoRadioButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox capacityBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton passengerRadioButton;
        private System.Windows.Forms.ComboBox positionComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox nameComboBox;
    }
}