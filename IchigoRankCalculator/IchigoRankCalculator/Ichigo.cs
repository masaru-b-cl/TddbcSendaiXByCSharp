namespace IchigoRankCalculator
{
    public class Ichigo
    {
        public Ichigo(string breed, string size)
        {
            Breed = breed;
            Size = size;
        }

        public string Breed { get; }
        public string Size { get; }

        public override string ToString()
        {
            return $"{Breed}: {Size}";
        }
    }
}
