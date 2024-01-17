using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroDeJogos
{
    abstract class Peca
    {
        public Posicao? posicao { get; set; }
        public Cor cor {  get; protected set; }   
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Cor cor, Tabuleiro tab)
        {
            posicao = null;
            qteMovimentos = 0;
            this.cor = cor;
            this.tab = tab;
        }
        public void incrementarQtdDeMovimento() 
        { 
            qteMovimentos++;
        }
        public void dencrementarQtdDeMovimento()
        {
            qteMovimentos--;
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            foreach (bool item in mat)
            {
                if (item)
                {
                    return true;
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
