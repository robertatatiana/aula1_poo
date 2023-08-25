using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_POO2
{
    internal class exercício1
    {
    }
    public class Solution
    {

    }

    public abstract class EsporteBase
    {
        public abstract int QuantidadeJogadoresPorTime { get; }
        public abstract int TempoDeJogoEmMinutos { get; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();
    }

    public class Futebol : EsporteBase
    {
        public override int QuantidadeJogadoresPorTime { get; }
        public override int TempoDeJogoEmMinutos { get; }

        public Futebol()
        {
            QuantidadeJogadoresPorTime = 11;
            TempoDeJogoEmMinutos = 90;
        }

        public override string IniciarJogo()
        {
            return "O jogo foi iniciado";
        }

        public override string FinalizarJogo()
        {
            return "O jogo foi finalizado";
        }

        public override string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos";
        }
    }
}
