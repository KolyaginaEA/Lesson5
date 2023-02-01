namespace N
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
                array[i] = myRandom.Next(-100, 100);
                System.Console.Write("{0} ", array[i]);
            }
            System.Console.Write("\n");
            int Sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                Sum += array[i];
            }
            System.Console.Write("Сумма: {0}", Sum);
            System.Console.ReadKey(true);
        }
    }
}