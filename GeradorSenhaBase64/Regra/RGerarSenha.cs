using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace GeradorSenhaBase64.Regra
{
    class RGerarSenha
    {
        public void gerarSenha(string pathExcel, string pathNovaPlanilha)
        {
            Application appUsuario = null;

            Workbook workbook;
            Worksheet worksheet;
            try
            {
                appUsuario = new Application();
                string sourceFile = @pathExcel;
                string targetPath = @pathNovaPlanilha;

                string destFile = System.IO.Path.Combine(targetPath, "UsuarioESenha.xlsx");

                System.IO.File.Copy(sourceFile, destFile, true);
                workbook = appUsuario.Workbooks.Open(destFile);

                worksheet = (Worksheet)workbook.Sheets[1];

                Range excelRange = worksheet.UsedRange;

                foreach (Range row in excelRange.Rows)
                {
                    if(row.Row < (excelRange.Rows.Count - 1))
                    {
                        int numeroLinha = row.Row;
                        string usuario = worksheet.Cells[numeroLinha, 1].Value.ToString();

                        worksheet.Cells[numeroLinha, 2] = criarSenha(usuario);
                    }
                }
                workbook.Save();
                appUsuario.Undo();
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                worksheet = null;
                workbook = null;
                appUsuario.Quit();
                appUsuario = null;
            }
        }

        public string criarSenha(string usuario)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(usuario);
            string senha = Convert.ToBase64String(bytes);

            return senha;
        }

    }
}
