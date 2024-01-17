using System;
using TabuleiroDeJogos;

namespace Xadrez
{
    class Vazio : Peca
    {
        public Vazio(Tabuleiro tab, Cor cor) : base(cor, tab) { }
        public override string ToString()
        {
            return "-";
        }
    }
}