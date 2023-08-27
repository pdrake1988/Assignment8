namespace Assignment8
{
    public class Manipulation
    {
        public void Sum(int[] ints)
        {
            int count = 0;
            foreach (int i in ints)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        public void Average(int[] ints)
        {
            int count = 0;
            foreach (int i in ints)
            {
                count += i;
            }
            Console.WriteLine(count / ints.Length);
        }

        public void MinMax(int[] ints)
        {
            Console.WriteLine(ints.Min());
            Console.WriteLine(ints.Max());
        }
    }
}
