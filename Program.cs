using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiros tab = new Tabuleiros(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                Tela.imprimirTabuleiro(tab);

            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}

