namespace Ekaterina
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Размер массива: ");
            int size = System.Convert.ToInt32(System.Console.ReadLine());
            int[] array = new int[size];
            System.Random myRandom = new System.Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(100, 999);
                System.Console.Write("{0} ", array[i]);
            }
            System.Console.Write("\n");
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) n++;
            }
            System.Console.Write("Количество чётных: {0}", n);
            System.Console.ReadKey(true);
        }
    }
}