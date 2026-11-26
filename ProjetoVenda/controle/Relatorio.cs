using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ProjetoVenda.modelo;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;

            // um documento em que o conteúodo é igual a vazio
            var documento = Document.Create(conteudo =>
            { //criando o conteudo

                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(fonte => fonte.FontSize(6));

                //repete em toda pagina
                    pagina.Header().Column(coluna => 
                    {
                        coluna.Item().AlignCenter().Text("Mercadinho da Cristina").SemiBold().FontSize(15);
                        coluna.Item().PaddingBottom(6).AlignCenter().Text("CNPJ: 00.000.000./0000-00").SemiBold().FontSize(7.5f);
                        coluna.Item().PaddingBottom(6).AlignCenter().Text(@"Endereço: Rua Florinda de Alves, N°1540
Votorantim/SP - CEP: 00000-00").FontSize(5.5f);
                        coluna.Item().PaddingBottom(6).LineHorizontal(1f);
                        coluna.Item().AlignCenter().Text("CUPOM DE VENDA").FontSize(10);
                        coluna.Item().PaddingBottom(8);
                        coluna.Item().LineHorizontal(0.5f);

                    });
                        
                       

                    // conteúdo principal
                    pagina.Content().Column(coluna => 
                    { //criando conteúdo
                        coluna.Item().Row(linha => 
                        {
                            //cabeçalho dos itens
                            linha.ConstantItem(20).Text("ITEM").FontSize(6);
                            linha.RelativeItem(2).Text("DESCRIÇÃO").FontSize(6);
                            linha.RelativeItem().Text("QTD").FontSize(6).AlignRight();
                            linha.RelativeItem().Text("PREÇO").FontSize(6).AlignRight();
                            linha.RelativeItem().Text("TOTAL").FontSize(6).AlignRight();
                        
                        });
                        coluna.Item().PaddingBottom(3).LineHorizontal(0.5f);
                        // os itens descritos
                        

                        for (int i = 0; i < itens.Count; i++)
                        {
                            Item item = itens[i];

                            coluna.Item().Row(linha =>
                            {
                                linha.ConstantItem(20).Text($"{i+1}").FontSize(6);
                                linha.RelativeItem(2).Text(item.nomeProduto).FontSize(6);
                                linha.RelativeItem().AlignRight().Text($"{item.quantidade}").ToString();
                                linha.RelativeItem().AlignRight().Text($"{item.precoReal:C2}").ToString();
                                linha.RelativeItem().AlignRight().Text($"{item.subTotal:C2}").ToString();
                                

                            });
                        }
                        coluna.Item().PaddingBottom(3).LineHorizontal(0.5f);
                        coluna.Item().Row(linha =>
                        {
                            decimal total = itens.Sum(i => i.subTotal);
                            linha.RelativeItem().Text("Total").FontSize(6);
                            linha.RelativeItem().AlignRight().Text($"{total:C2}").ToString();
                            
                        
                        });

                    });


                    //repete em toda pagina
                    // Rodapé
                    pagina.Footer().Column(coluna => 
                    { 
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text($"DATA: {data:dd/MM/yyyy HH:mm:ss}").FontSize(5).Bold();
                        coluna.Item().AlignCenter().Text("Mercadinho da Cristina agradece sua compra, volte sempre!").FontSize(6).Italic();
                    });
                });

                
            });

            return documento;
        }

        public void salvarPdf(Document documento)
        {
            
            // pasta temporaria da máquina
            string pasta = Path.GetTempPath();

            // nome do pdf com a chave UUID
            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";

            // A combinação da pasta com o arquvio do local
            string caminho = Path.Combine(pasta, nomeArquivo );

            documento.GeneratePdf(caminho);

            // essa etapa ele já abri o arquivo automaticamente
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true

            });
        }
    }
}
