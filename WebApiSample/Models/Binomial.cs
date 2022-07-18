namespace WebApiSample.Models
{
    public class Binomial
    {
        public int SampleTotal { get; set; }
        public float Chance { get; set; }
        public float Lose => 1 - Chance;
        public int factorial(int n) { 
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }

    }

}
