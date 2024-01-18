using System;
using TabuleiroDeJogos;
using xadrez_console;
using Xadrez;


try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.finalizada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);
            Console.WriteLine();

            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoOrigem(origem);

            Console.Clear();
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
            Console.WriteLine();

            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch (TabuleiroException e) 
        { 
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
    Console.Clear();
    Tela.imprimirPartida(partida);
    Console.ReadLine();
}

catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
