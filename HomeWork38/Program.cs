namespace N
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("Размер массива: ");
            int size = System.Convert.ToInt32(System.Console.ReadLine());
            double[] array = new double[size];
            System.Random myRandom = new System.Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(-100, 100);
                System.Console.Write("{0} ", array[i]);
            }
            System.Console.Write("\n");
            double max = array[0], min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                else if (array[i] > max) max = array[i];
            }
            double S = max - min;
            System.Console.Write("Сумма: {0}", S);
            System.Console.ReadKey(true);
        }
    }
}