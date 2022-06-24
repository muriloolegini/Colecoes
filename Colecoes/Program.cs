namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Criando e percorrendo um array

            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            Console.WriteLine("Percorrendo array pelo for!");

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine("Array: " + arrayInteiros[i]);
            }

            Console.WriteLine("Percorrendo array pelo foreach!");

            foreach (int item in arrayInteiros)
            {
                Console.WriteLine("Array: " + item);
            }
        }
    }
}