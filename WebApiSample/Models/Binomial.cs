namespace WebApiSample.Models
{
    public class Binomial
    {
        public int Size { get; set; }
        public float Chance { get; set; }
        public float Lose => 1 - Chance;
        public float[] dist => distribution();
        public int factorial(int n) {
            return Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
        }
        public int combination(int n, int x)
        {
            return factorial(n) / (factorial(x) * factorial(n - x));
        }
        public float[] distribution ()
        {
            float[] res = new float[Size+1];

            for (int x = 0; x < Size+1; x++)
            {
                res[x] = Convert.ToSingle(combination(Size, x)*Math.Pow(Chance, x)*Math.Pow(Lose, Size-x));
            }

            return res;
        }


    }

}
