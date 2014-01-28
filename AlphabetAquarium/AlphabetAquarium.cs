using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlphabetAquarium
{
    public partial class AlphabetAquarium : Form
    {
        bool doAnimation = false;

        private FishTank _fishTank = new FishTank();

        public AlphabetAquarium()
        {
            InitializeComponent();
        }

        private void AlphabetAquarium_Load(object sender, EventArgs e)
        {
            // Populate "colors" ComboBox, select "Black" as default.
            colorsComboBox.Items.Add("Black");
            colorsComboBox.Items.Add("Red");
            colorsComboBox.Items.Add("Green");
            colorsComboBox.Items.Add("Blue");
            colorsComboBox.SelectedIndex = colorsComboBox.FindString("Black");
            // Populate the "fish" ComboBox, select "A" as default
            fishComboBox.Items.Add("A");
            fishComboBox.Items.Add("B");
            fishComboBox.Items.Add("C");
            fishComboBox.Items.Add("D");
            fishComboBox.SelectedIndex = fishComboBox.FindString("A");
        }

        private void colorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the color of the colorPictureBox to match the selected color.
            colorPictureBox.BackColor = Color.FromName(colorsComboBox.SelectedItem.ToString());
        }

        private void addFishButton_Click(object sender, EventArgs e)
        {
            // Use the boundaries of the fishTankPanel to limit our random x, y location.
            Rectangle fishTankRect = fishTankPanel.Bounds;
            Random random = new Random();
            int x = random.Next(10, fishTankRect.Width - 10);
            int y = random.Next(10, fishTankRect.Height - 10);
            // Create a new Fish object, and add to our fish tank.
            Fish fish = new Fish(fishComboBox.SelectedItem.ToString(), x, y, Color.FromName(colorsComboBox.SelectedItem.ToString()));
            _fishTank.AddFish(fish);
            fishTankPanel.Invalidate();

            
        }

        private void clearFishButton_Click(object sender, EventArgs e)
        {
            _fishTank.ClearFish();
            fishTankPanel.Invalidate();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fishTankPanel_Paint(object sender, PaintEventArgs e)
        {
            
            // Loop through each fish in our fish tank, and draw them.
            for (int i = 0; i < _fishTank.CountFish(); i++)
            {
                    Fish fish = _fishTank.GetFish(i);
                    int previousX = fish.XPosition;
                    e.Graphics.DrawString(fish.FishLetter, new Font("Arial", 10),
                        new SolidBrush(fish.FishColor), new Point(previousX, fish.YPosition));

            }
            fishCountLabel.Text = _fishTank.CountFish().ToString();

        }

        private void moveFish()
        {
                for (int i = 0; i < _fishTank.CountFish(); i++)
                {

                    Fish fish = _fishTank.GetFish(i);
                    System.Threading.Thread.Sleep(20); Application.DoEvents();
                    if (fish.Direction == "L")
                    {int previousX = fish.XPosition; 
                        fish.XPosition--; }
                    if (fish.Direction == "R")
                    {int previousX = fish.XPosition;
                        fish.XPosition++; }
                    Rectangle fishTankRectMargin = fishTankPanel.Bounds;
                    int Margin =  fishTankRectMargin.Width - 10;
                    if (fish.XPosition <= 0 && fish.Direction == "L")
                    {fish.Direction = "R";} 
                    if (fish.XPosition >= Margin && fish.Direction == "R")
                    { fish.Direction = "L"; }
                    fishTankPanel.Invalidate();
               }
                 
         }
                

            
          
            
        

        private void animateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if we are to animate, then force paint event to occur using Refresh.
            if (animateCheckBox.Checked)
            { animateTimer.Enabled = true; }
            else
            { animateTimer.Enabled = false; }
            this.Refresh();
        }

        private void animateTimer_Tick(object sender, EventArgs e)
        {
            moveFish();
        }


    }
}
