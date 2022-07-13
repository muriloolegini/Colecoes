using Colecoes.Entity;

namespace Colecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();
            estados.Add("MG", "Uberlândia");
            estados.Add("MT", "Cuiabá");
            estados.Add("SP", "Campinas");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "SP";

            if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine(estadoEncontrado);
            }
            else
            {
                Console.WriteLine($"A chave {valorProcurado} não existe no dicionário.");
            }

            //Console.WriteLine($"Removendo o valor: {valorProcurado}");
            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //Console.WriteLine("Valor original:");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "MG - Uberlândia";

            //Console.WriteLine("Valor atualizado:");
            //Console.WriteLine(estados[valorProcurado]);

            //OperacoesLista opLista = new OperacoesLista();
            //List<string> estados = new List<string> { "SP", "MG", "BA" };
            //string[] estadosArray = new string[2] { "SC", "MT" };


            //Console.WriteLine($"Quantidade de elementos na lista. {estados.Count}");
            //opLista.ImprimirListaString(estados);

            //Console.WriteLine("Removendo o elemento");
            //estados.Remove("MG");
            //estados.AddRange(estadosArray);

            //Console.WriteLine();

            //estados.Insert(1, "RJ");
            //opLista.ImprimirListaString(estados);


            /* OperacoesArray op = new OperacoesArray();
               int[] array = new int[5] { 6, 3, 8, 1, 9 };
               int[] arrayCopia = new int[10];
               string[] arrayString = op.ConverterArrayParaString(array);

               int valorProcurado = 8; */

            #region Pilha
            //Stack<string> pilhaLivros = new Stack<string>();

            //pilhaLivros.Push(".NET");
            //pilhaLivros.Push("DDD");
            //pilhaLivros.Push("PYTHON");

            //Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo livro: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} livro lido com sucesso");
            //}

            //Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            #endregion

            #region Fila
            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Murilo");
            //fila.Enqueue("Thaís");
            //fila.Enqueue("Carlos");

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");

            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido(a)!");
            //}

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");
            #endregion

            #region Metodo RedmensionarArray
            //Console.WriteLine($"Capacidade atual do array: {array.Length}");
            //op.RedmensionarArray(ref array, array.Length * 2);
            //Console.WriteLine($"Capacidade atual do array após redminsionado: {array.Length}");
            #endregion

            #region Metodo ObterIndice
            //int indice = op.ObterIndice(array, valorProcurado);
            //if (indice > - 1)
            //{
            //    Console.WriteLine("O índice do valor {0} é {1}", valorProcurado, indice);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existe no array");
            //}
            #endregion

            #region Metodo ObterValor
            //int valorAchado = op.ObtreValor(array, valorProcurado);
            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}
            #endregion

            #region Metodo TodosMaiorQue
            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            //}
            #endregion

            #region  Metodo Existe
            //bool existe = op.Existe(array, valorProcurado);
            //if (existe)
            //{
            //    Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            //}
            #endregion

            #region Ordenar Array
            //   Console.WriteLine("Array original");
            //   op.ImprimirArray(array);

            //   op.OrdenarBubbleSort(ref array);
            //   op.Ordenar(ref array);

            //   Console.WriteLine("Array ordenado");
            //   op.ImprimirArray(array);
            #endregion

            #region Copiar Array
            //   Console.WriteLine("Array antes da cópia");
            //   op.ImprimirArray(arrayCopia);

            //   Console.WriteLine("Array depois da cópia");
            //   op.Copiar(ref array, ref arrayCopia);

            //   op.ImprimirArray(arrayCopia);
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