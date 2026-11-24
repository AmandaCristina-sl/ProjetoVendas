using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota()
        {
            // um documento em que o conteúodo é igual a vazio
            var documento = Document.Create(conteudo =>
            { //criando o conteudo

                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(fonte => fonte.FontSize(10));

                //repete em toda pagina
                    pagina.Header().Column(coluna => 
                    {
                        coluna.Item().AlignCenter().Text("CUPOM DE VENDA").FontSize(15);
                        coluna.Item().LineHorizontal(1.5f);
                        coluna.Item().AlignCenter().Text("Mercadinho da Cristina").SemiBold();
                        coluna.Item().AlignCenter().Text("Rua Florinda de Alves, N°1540 - Votorantim/SP - CEP: 00000-00 - CNPJ: 00.000.000./0000-00").FontSize(4).Underline();
                    });
                        
                       

                    
                    pagina.Content();


                    //repete em toda pagina
                    pagina.Footer().Column(coluna => 
                    { 
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text("DATA: 23/11/2026").FontSize(5).Bold();
                        coluna.Item().Text("Volte sempre!").FontSize(6).Italic();
                    });
                });

                
            });

            return documento;
        }

        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog 
            { 
                Title = "Salvar Documento",
                FileName = "nota_pdf",
                Filter = "(PDF)|*.pdf"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);
            }
            
        }
    }
}
