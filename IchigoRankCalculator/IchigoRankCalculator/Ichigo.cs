using System;

namespace IchigoRankCalculator
{
    public class Ichigo
    {
        public Ichigo(string breed, string size)
        {
            this.Breed = breed;
            this.Size = size;
        }

        public string Breed { get; private set; }

        public string Size { get; private set; }
    }
}
