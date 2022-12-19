using ConsoleWebScraping.DTOs;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;

namespace ConsoleWebScraping
{
    public class CsvHelper
    {
        // O Static permite que eu chame o método sem precisar instanciar a classe CsvHelper
        public static string SaveIbovespaInfo(IbovespaInfoDTO ibovespaInfoDTO)
        {
            string folderName = "results";
            string fileName = "ibovespaInfo.csv";
            var filePath = $"{folderName}\\{fileName}";

            if (File.Exists(fileName) is false) //Verifica se o arquivo existe e se n existir ele cria
            {
                Directory.CreateDirectory(folderName); //Cria a pasta
                File.Create(filePath).Dispose(); //Cria o file path
            }

            using (var writer = new StreamWriter(filePath)) 
            using (var csv = new CsvWriter(writer, 
                new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
            {
                csv.WriteHeader<IbovespaInfoDTO>(); //Header do arquivo csv
                csv.NextRecord(); //Coloca para a proxima linha
                csv.WriteRecord(ibovespaInfoDTO); //Coloca os valores obtidos após a execução do programa
            }

            return Path.GetFullPath(filePath);
                    
        }
    }
}
