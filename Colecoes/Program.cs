using Colecoes.Entity;

namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Ordenando Array
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            Console.WriteLine("Array original");
            op.ImprimirArray(array);

         // op.OrdenarBubbleSort(ref array);
            op.Ordener(ref array);

            Console.WriteLine("Array ordenado");
            op.ImprimirArray(array);

            Console.WriteLine("Array antes da cópia");
            op.ImprimirArray(arrayCopia);

            Console.WriteLine("Array depois da cópia");
            op.Copiar(ref array, ref arrayCopia);

            op.ImprimirArray(arrayCopia);
            #endregion

            #region Matriz
            //int[,] matriz = new int[4, 2]
            //{
            //    { 5, 10 },
            //    { 11, 20 },
            //    { 21, 30 },
            //    { 31, 50 }
            //};

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }
            //}
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