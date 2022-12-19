using System;

namespace ConsoleWebScraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting web scraping...");

            var ibovespaWebScraping =  new IbovespaWebScraping();
            var ibovespaInfo = ibovespaWebScraping.GetIbovespaInfo();
            var filePath = CsvHelper.SaveIbovespaInfo(ibovespaInfo);

            Console.WriteLine("O total de pontos do dia é: " + ibovespaInfo.TotalPoints);

            Console.WriteLine("A variação total do dia é: " + ibovespaInfo.PercentagemVariation);

            Console.WriteLine("O diretório onde o seu csv foi salvo: " + filePath);
        }
    }
}
