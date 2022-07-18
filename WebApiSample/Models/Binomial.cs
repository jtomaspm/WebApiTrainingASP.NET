namespace WebApiSample.Models
{
    public class Binomial
    {
        public int Size { get; set; }
        public float Chance { get; set; }
        public float Lose => 1 - Chance;
        public int factorial(int n) { 
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }
        public int combination(int n, int x)
        {
            return factorial(n) / (factorial(x) * factorial(n - x));
        }
        public List<float> distribution ()
        {
            List<float> res = new List<float>(Size);

            for (int x = 0; x < Size; x++)
            {
                res[x] = Convert.ToSingle(combination(Size, x)*Math.Pow(Chance, x)*Math.Pow(Lose, Size-x));
            }

            return res;
        }

    }

}
