using System;

namespace ConsoleWebScraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting web scraping...");

            var ibovespaWebScraping =  new IbovespaWebScraping();
            var result = ibovespaWebScraping.GetIbovespaInfo();

            Console.WriteLine("O total de pontos do dia é: " + result.TotalPoints);

            Console.WriteLine("A variação total do dia é: " + result.PercentagemVariation);
        }
    }
}
