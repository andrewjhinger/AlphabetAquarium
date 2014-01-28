namespace AlphabetAquarium
{
    partial class AlphabetAquarium
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fishTankPanel = new System.Windows.Forms.Panel();
            this.animateCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.fishCountLabel = new System.Windows.Forms.Label();
            this.fishLabel = new System.Windows.Forms.Label();
            this.clearFishButton = new System.Windows.Forms.Button();
            this.addFishButton = new System.Windows.Forms.Button();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorsComboBox = new System.Windows.Forms.ComboBox();
            this.fishComboBox = new System.Windows.Forms.ComboBox();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fishTankPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.animateCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.fishCountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fishLabel);
            this.splitContainer1.Panel2.Controls.Add(this.clearFishButton);
            this.splitContainer1.Panel2.Controls.Add(this.addFishButton);
            this.splitContainer1.Panel2.Controls.Add(this.colorPictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.colorsComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.fishComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(592, 329);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 0;
            // 
            // fishTankPanel
            // 
            this.fishTankPanel.BackColor = System.Drawing.Color.Cyan;
            this.fishTankPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fishTankPanel.Location = new System.Drawing.Point(0, 0);
            this.fishTankPanel.Name = "fishTankPanel";
            this.fishTankPanel.Size = new System.Drawing.Size(388, 329);
            this.fishTankPanel.TabIndex = 0;
            this.fishTankPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fishTankPanel_Paint);
            // 
            // animateCheckBox
            // 
            this.animateCheckBox.AutoSize = true;
            this.animateCheckBox.Location = new System.Drawing.Point(15, 174);
            this.animateCheckBox.Name = "animateCheckBox";
            this.animateCheckBox.Size = new System.Drawing.Size(64, 17);
            this.animateCheckBox.TabIndex = 1;
            this.animateCheckBox.Text = "Animate";
            this.animateCheckBox.UseVisualStyleBackColor = true;
            this.animateCheckBox.CheckedChanged += new System.EventHandler(this.animateCheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(113, 294);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fishCountLabel
            // 
            this.fishCountLabel.AutoSize = true;
            this.fishCountLabel.Location = new System.Drawing.Point(78, 121);
            this.fishCountLabel.Name = "fishCountLabel";
            this.fishCountLabel.Size = new System.Drawing.Size(13, 13);
            this.fishCountLabel.TabIndex = 6;
            this.fishCountLabel.Text = "0";
            // 
            // fishLabel
            // 
            this.fishLabel.AutoSize = true;
            this.fishLabel.Location = new System.Drawing.Point(12, 121);
            this.fishLabel.Name = "fishLabel";
            this.fishLabel.Size = new System.Drawing.Size(60, 13);
            this.fishLabel.TabIndex = 5;
            this.fishLabel.Text = "Fish Count:";
            // 
            // clearFishButton
            // 
            this.clearFishButton.Location = new System.Drawing.Point(98, 197);
            this.clearFishButton.Name = "clearFishButton";
            this.clearFishButton.Size = new System.Drawing.Size(75, 23);
            this.clearFishButton.TabIndex = 4;
            this.clearFishButton.Text = "Clear Fish";
            this.clearFishButton.UseVisualStyleBackColor = true;
            this.clearFishButton.Click += new System.EventHandler(this.clearFishButton_Click);
            // 
            // addFishButton
            // 
            this.addFishButton.Location = new System.Drawing.Point(15, 197);
            this.addFishButton.Name = "addFishButton";
            this.addFishButton.Size = new System.Drawing.Size(75, 23);
            this.addFishButton.TabIndex = 3;
            this.addFishButton.Text = "Add Fish";
            this.addFishButton.UseVisualStyleBackColor = true;
            this.addFishButton.Click += new System.EventHandler(this.addFishButton_Click);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.Location = new System.Drawing.Point(113, 24);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(17, 18);
            this.colorPictureBox.TabIndex = 2;
            this.colorPictureBox.TabStop = false;
            // 
            // colorsComboBox
            // 
            this.colorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorsComboBox.FormattingEnabled = true;
            this.colorsComboBox.Location = new System.Drawing.Point(15, 24);
            this.colorsComboBox.Name = "colorsComboBox";
            this.colorsComboBox.Size = new System.Drawing.Size(85, 21);
            this.colorsComboBox.TabIndex = 0;
            this.colorsComboBox.SelectedIndexChanged += new System.EventHandler(this.colorsComboBox_SelectedIndexChanged);
            // 
            // fishComboBox
            // 
            this.fishComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fishComboBox.FormattingEnabled = true;
            this.fishComboBox.Location = new System.Drawing.Point(15, 51);
            this.fishComboBox.Name = "fishComboBox";
            this.fishComboBox.Size = new System.Drawing.Size(69, 21);
            this.fishComboBox.TabIndex = 1;
            // 
            // animateTimer
            // 
            this.animateTimer.Interval = 1000;
            this.animateTimer.Tick += new System.EventHandler(this.animateTimer_Tick);
            // 
            // AlphabetAquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 329);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AlphabetAquarium";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AlphabetAquarium_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel fishTankPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label fishCountLabel;
        private System.Windows.Forms.Label fishLabel;
        private System.Windows.Forms.Button clearFishButton;
        private System.Windows.Forms.Button addFishButton;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.ComboBox colorsComboBox;
        private System.Windows.Forms.ComboBox fishComboBox;
        private System.Windows.Forms.CheckBox animateCheckBox;
        private System.Windows.Forms.Timer animateTimer;
    }
}

