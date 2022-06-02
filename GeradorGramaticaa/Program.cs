using System;

namespace GeradorGramaticaa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInsira a Gramatica que deseja resolver\n");
            string G = Console.ReadLine();

            string[] producoesG = G.Split(new char[] { '|' });
            int tamanhoPilha = G.Length;
            Pilha pilha = new Pilha(tamanhoPilha);
            int sair = 0;
            int inserir = 0;
            string imprime = "";

            while (sair == 0)
            {
                if (inserir == 0)
                {
                    foreach (string b in producoesG)
                    {
                        char[] letras = b.ToCharArray();
                        foreach (char c in letras)
                        {
                            pilha.Push(c.ToString());
                        }
                    }
                    inserir++;
                }


                imprimeOpcoes();

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    sair = 1;
                }
                else
                    if (opcao == 1)
                    {
                        Console.WriteLine("\nInsira a Gramatica que deseja resolver\n");
                        string S = Console.ReadLine();
                        string[] solucoes = S.Split(new char[] { '=' });

                        foreach (char c in solucoes[1])
                        {
                            pilha.VerificaElementoTerminal(c);
                        }
                        Console.Clear();
                    }
                    else
                        if (opcao == 2)
                        {
                            Console.Clear();
                            imprime = pilha.ImprimirPilha();
                            Console.WriteLine(imprime);
                        }
            }
        }
        static public void imprimeOpcoes()
        {
            Console.WriteLine("\nEscolha uma opção:\n");
            Console.WriteLine("0 => Sair");
            Console.WriteLine("1 => Sentenca");
            Console.WriteLine("2 => Imprime gramatica");
        }
    }
}
