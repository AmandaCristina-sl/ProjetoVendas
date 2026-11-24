using ProjetoVenda.controle;
using ProjetoVenda.formulario;
using QuestPDF.Infrastructure;

namespace ProjetoVenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread] 
        static void Main()
        {

            QuestPDF.Settings.License = LicenseType.Community;

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmCadastroVenda());
            //Relatorio relatorio = new Relatorio();
            //relatorio.salvarPdf();

            while (true)
            {
                //using é utilizado de modo temporario, enxergue como se fosse um "IF".
                using (frmLogin login = new frmLogin()) // criação da nossa instancia, da nossa variavel
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }

                using frmPrincipal principal = new frmPrincipal();
                {
                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }

                }
            }            
        }
    }
}