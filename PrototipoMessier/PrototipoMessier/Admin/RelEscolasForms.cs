using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class RelEscolasForms : Form
    {
        public RelEscolasForms()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            // Cabeçalho --------------------------------------------------------------------------------------------

            sb.AppendLine(" ╔══════════════════════════════════════════════════════════════════════════════╗");
            sb.AppendLine(" ║         RELATÓRIO DE ESCOLAS E PACOTES  —  MESSIER EDUCACIONAL               ║");
            sb.AppendLine($"║ Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}                                ║");
            sb.AppendLine(" ╠═════════════════════════╦═══════════════╦═══════════╦═══════════╦════════════╣");
            sb.AppendLine(" ║ Escola                  ║ Pacote        ║ Lim/Mês   ║ Uso(mês)  ║ % Uso      ║");
            sb.AppendLine(" ╠═════════════════════════╬═══════════════╬═══════════╬═══════════╬════════════╣");

            foreach (var escola in DadosSistema.Escolas)
            {
                DadosSistema.VerificarReinicioMensal(escola);

                string nomePacote = "-";
                int    limite     = 0;

                if (escola.PacoteId.HasValue)
                {
                    var p = DadosSistema.GetPacote(escola.PacoteId.Value);
                    
                    if (p != null)
                    {
                        nomePacote = p.Nome; limite = p.LimiteMensal;
                    }
                }

                double pct = limite > 0 ? (escola.AcessosMes * 100.0 / limite) : 0;

                sb.AppendLine(
                    $"║ {escola.Instituicao,-23} " +
                    $"║ {nomePacote,-13} " +
                    $"║ {limite,9} " +
                    $"║ {escola.AcessosMes,9} " +
                    $"║ {pct,7:F1} %  ║"
                );
            }

            sb.AppendLine("╚═════════════════════════╩═══════════════╩═══════════╩═══════════╩═══════════╝");

            // Log de Acessos --------------------------------------------------------------------------------------

            sb.AppendLine();
            sb.AppendLine("━━━━ LOG DE ACESSOS ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            var logs = DadosSistema.Logs.OrderByDescending(l => l.DataHora).ToList();

            if (logs.Count == 0)
            {
                sb.AppendLine("  (nenhum acesso registrado nesta sessão)");
            }
            else
            {
                sb.AppendLine($"  Total de registros: {logs.Count}  |  " +
                              $"Permitidos: {logs.Count(l => l.Permitido)}  |  " +
                              $"Bloqueados: {logs.Count(l => !l.Permitido)}");
                sb.AppendLine();
                sb.AppendLine($"  {"Data/Hora",-18} {"Escola",-22} {"Jogo",-22} {"IP",-15} Resultado");
                sb.AppendLine($"  {new string('─', 90)}");

                foreach (var log in logs)
                {
                    string resultado = log.Permitido ? "PERMITIDO" : "BLOQUEADO";
                    sb.AppendLine(
                        $"  {log.DataHora:dd/MM/yyyy HH:mm:ss,-18} " +
                        $"{log.NomeEscola,-22} " +
                        $"{log.NomeJogo,-22} " +
                        $"{log.IP,-15} " +
                        $"{resultado}"
                    );
                    if (!log.Permitido && !string.IsNullOrEmpty(log.Motivo))
                        sb.AppendLine($"    → Motivo: {log.Motivo}");
                }
            }

            txtRelatorio.Text = sb.ToString();
        }
    }
}
