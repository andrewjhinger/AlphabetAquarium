using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlphabetAquarium
{
    class FishTank
    {
        // Use a List collection to hold the fish.
        private List<Fish> _fishTank = new List<Fish>();

        public int CountFish()
        {
            return _fishTank.Count;
        }

        public Fish GetFish(int position)
        {
            return _fishTank[position];
        }

        public void AddFish(Fish fish)
        {
            _fishTank.Add(fish);
        }

        public void ClearFish()
        {
            _fishTank.Clear();
        }
    }
}
