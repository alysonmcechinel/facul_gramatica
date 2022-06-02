
namespace GeradorGramaticaa
{
    public class Pilha
    {
        private string[] valores;
        private int topo;

        public Pilha(int n) /* Método construtor */
        {
            if (n > 0)
            {
                valores = new string[n];
                topo = -1;
            }
        }

        public int Push(string valor)   /* Método para empilhar */
        {
            if (topo < valores.Length - 1)
            {
                topo++;
                valores[topo] = valor;
                return 0;
            }
            return -1;
        }

        public string Pop() /* Método para desempilhar */
        {
            if (topo >= 0)
            {
                string valor = valores[topo];
                topo--;
                return valor;
            }
            else return null;  /* Stack Underflow */
        }

        public string ImprimirPilha()    /* Método para imprimir a pilha */
        {
            string saida = " ";
            if (topo >= 0)
            {
                for (int i = topo; i >= 0; i--)
                {
                    saida = saida + valores[i] + " ";
                }
                return saida;
            }
            else return "\tPilha Vazia";
        }

        public string VerificaElementoTerminal(char b)
        {
            string saida = " ";
            if (topo >= 0)
            {
                for (int i = topo; i >= 0; i--)
                {
                    if (valores[i] == valores[i].ToUpper())
                    {
                        valores[i] = b.ToString();
                        saida = saida + valores[i];
                    }
                    else
                        saida = saida + valores[i] + " ";

                }
                return saida;
            }
            else return "Erro ao gerar Gramatica";
        }
    }
}
