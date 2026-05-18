using System;
using System.Collections.Generic;
using System.Linq;

namespace PrototipoMessier
{
    // Entidades

    public class Jogo
    {
        public int    Id          { get; set; }
        public string Titulo      { get; set; } = "";
        public string Descricao   { get; set; } = "";
        public string Disciplina  { get; set; } = "";
        public string FaixaEtaria { get; set; } = "";
        public bool   Ativo       { get; set; } = true;

        public override string ToString() => Titulo;
    }

    public class Pacote
    {
        public int       Id           { get; set; }
        public string    Nome         { get; set; } = "";
        public List<int> JogosIds     { get; set; } = new List<int>();
        public int       LimiteMensal { get; set; } = 100;
        public double    PrecoMensal  { get; set; } = 0;

        public override string ToString() => Nome;
    }

    public class Escolas
    {
        public int          Id             { get; set; }
        public string       Instituicao    { get; set; } = "";
        public string       CNPJ           { get; set; } = "";
        public string       Senha          { get; set; } = "";
        public int?         PacoteId       { get; set; }
        public List<string> IPsAutorizados { get; set; } = new List<string>();
        public int          AcessosMes     { get; set; } = 0;
        public int          MesContagem    { get; set; } = DateTime.Now.Month;
        public int          AnoContagem    { get; set; } = DateTime.Now.Year;
    }

    public class LogAcesso
    {
        public DateTime DataHora   { get; set; } = DateTime.Now;
        public int      EscolaId   { get; set; }
        public string   NomeEscola { get; set; } = "";
        public int      JogoId     { get; set; }
        public string   NomeJogo   { get; set; } = "";
        public string   IP         { get; set; } = "";
        public bool     Permitido  { get; set; }
        public string   Motivo     { get; set; } = "";
    }

    // Repositório em memória

    public static class DadosSistema
    {
        public static List<Jogo> Jogos = new List<Jogo>
        {
            new Jogo
            {
                Id          = 1,
                Titulo      = "Matemática Mágica",
                Descricao   = "Operações matemáticas",
                Disciplina  = "Matemática",
                FaixaEtaria = "6-10",
                Ativo       = true
            },

            new Jogo
            {
                Id          = 2,
                Titulo      = "Mundo das Letras",
                Descricao   = "Alfabetização interativa",
                Disciplina  = "Português",
                FaixaEtaria = "5-8",
                Ativo       = true
            },

            new Jogo
            {
                Id          = 3,
                Titulo      = "Ciências em Ação",
                Descricao   = "Experimentos científicos virtuais",
                Disciplina  = "Ciências",
                FaixaEtaria = "9-12",
                Ativo       = true
            },

            new Jogo
            {
                Id          = 4,
                Titulo      = "História do Brasil",
                Descricao   = "Aventura pela história brasileira",
                Disciplina  = "História",
                FaixaEtaria = "10-14",
                Ativo       = true
            },

            new Jogo
            {
                Id          = 5,
                Titulo      = "Geografia Viva",
                Descricao   = "Explore o mapa-múndi interativo",
                Disciplina  = "Geografia",
                FaixaEtaria = "8-12",
                Ativo       = false
            },
        };

        public static List<Pacote> Pacotes = new List<Pacote>
        {
            new Pacote
            {
                Id           = 1,
                Nome         = "Bronze",
                JogosIds     = new List<int> { 1, 2 },
                LimiteMensal = 50,
                PrecoMensal  = 99.90
            },

            new Pacote
            {
                Id           = 2,
                Nome         = "Prata",
                JogosIds     = new List<int> { 1, 2, 3 },
                LimiteMensal = 150,
                PrecoMensal  = 199.90
            },

            new Pacote
            {
                Id           = 3,
                Nome         = "Ouro",
                JogosIds     = new List<int> { 1, 2, 3, 4, 5 },
                LimiteMensal = 500,
                PrecoMensal  = 399.90
            },
        };

        public static List<Escolas> Escolas = new List<Escolas>
        {
            new Escolas
            {
                Id             = 1,
                Instituicao    = "Escola Modelo",
                CNPJ           = "12345678000100",
                Senha          = "123456",
                PacoteId       = 2,
                IPsAutorizados = new List<string> { "192.168.1.1", "10.0.0.1" },
                AcessosMes     = 0,
                MesContagem    = DateTime.Now.Month,
                AnoContagem    = DateTime.Now.Year,
            }
        };

        public static List<LogAcesso> Logs = new List<LogAcesso>();

        // Helpers

        public static Pacote?  GetPacote(int id)          => Pacotes.FirstOrDefault(p => p.Id == id);
        public static Jogo?    GetJogo(int id)            => Jogos.FirstOrDefault(j => j.Id == id);
        public static Escolas? GetEscolaPorCNPJ(string c) => Escolas.FirstOrDefault(e => e.CNPJ == c);

        public static int ProximoIdJogo()   => Jogos.Count   > 0 ? Jogos.Max(j => j.Id) + 1 : 1;
        public static int ProximoIdPacote() => Pacotes.Count > 0 ? Pacotes.Max(p => p.Id) + 1 : 1;
        public static int ProximoIdEscola() => Escolas.Count > 0 ? Escolas.Max(e => e.Id) + 1 : 1;

        // Reinicia o contador mensal se o mês/ano mudou.
        public static void VerificarReinicioMensal(Escolas escola)
        {
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            if (escola.MesContagem != mes || escola.AnoContagem != ano)
            {
                escola.AcessosMes  = 0;
                escola.MesContagem = mes;
                escola.AnoContagem = ano;
            }
        }
    }
}
