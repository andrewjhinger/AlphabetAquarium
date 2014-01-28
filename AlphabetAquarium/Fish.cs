using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AlphabetAquarium
{
    class Fish
    {
        private Color _fishColor;
        public Color FishColor
        {
            get { return _fishColor; }
            set { _fishColor = value; }
        }

        private int _xPosition;
        public int XPosition
        {
            get { return _xPosition; }
            set { _xPosition = value; }
        }

        private int _yPosition;
        public int YPosition
        {
            get { return _yPosition; }
            set { _yPosition = value; }
        }

        private string _fishLetter;
        public string FishLetter
        {
            get { return _fishLetter; }
            set { _fishLetter = value; }
        }

        private string _direction;
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }


        public Fish(string fishLetter, int xPosition, int yPosition, Color fishColor)
        {
            // If no letter specified, use "X."
            if (fishLetter.Length == 0)
                fishLetter = "X";
            _fishLetter = fishLetter;

            // Ensure the position is >= 0.
            if (xPosition < 0)
                xPosition = 0;
            _xPosition = xPosition;

            if (yPosition < 0)
                yPosition = 0;
            _yPosition = yPosition;

            // Set the fish color.
            _fishColor = fishColor;

            Random random = new Random();
            int randomDirection = random.Next(1, 50);
            if (randomDirection <= 25)
            {_direction = "L";}
            else
            {_direction = "R";}
        }
    }
}
