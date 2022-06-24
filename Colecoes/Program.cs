namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Matriz
            int[,] matriz = new int[4, 2]
            {
                { 5, 10 },
                { 11, 20 },
                { 21, 30 },
                { 31, 50 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
            #endregion

            #region Array
            //int[] arrayInteiros = new int[3];

            //arrayInteiros[0] = 10;
            //arrayInteiros[1] = 20;
            //arrayInteiros[2] = int.Parse("30");

            //Console.WriteLine("Percorrendo array pelo for!");

            //for (int i = 0; i < arrayInteiros.Length; i++)
            //{
            //    Console.WriteLine("Array: " + arrayInteiros[i]);
            //}

            //Console.WriteLine("Percorrendo array pelo foreach!");

            //foreach (int item in arrayInteiros)
            //{
            //    Console.WriteLine("Array: " + item);
            //}
            #endregion
        }
    }
}