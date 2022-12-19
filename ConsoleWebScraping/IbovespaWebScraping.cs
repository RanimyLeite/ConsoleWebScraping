using ConsoleWebScraping.DTOs;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebScraping
{
    public class IbovespaWebScraping
    {
        public IbovespaInfoDTO GetIbovespaInfo()
        {
            try
            {
                HtmlWeb web = new HtmlWeb();

                //Carrega o site onde se quer pegar as informações
                HtmlDocument doc = web.Load("https://www.infomoney.com.br/cotacoes/b3/indice/ibovespa/");

                //Passa como path o que queremos pegar no site
                //No caso ele vai selecionar a div com class=value e o p dentro dela
                var ibovespaPointsNode = doc.DocumentNode.SelectNodes("//div[@class='value']/p");
                var ibovespaPercentageNodePositive = doc.DocumentNode.SelectNodes("//div[@class='percentage']/p[@class='positive']");
                var ibovespaPercentageNodeNegative = doc.DocumentNode.SelectNodes("//div[@class='percentage']/p[@class='negative']");

                //Na primeira posição da var, pega o valor do texto, remove os espaços e transforma em int
                var ibovespaTotalPoints = ibovespaPointsNode[0].InnerText.Trim();
                var ibovespaTotalPointsParse = double.Parse(ibovespaTotalPoints.ToString(), CultureInfo.InvariantCulture);

                var ibovespaPercentageVariation = "";

                if (ibovespaPercentageNodePositive != null)
                {
                    ibovespaPercentageVariation = ibovespaPercentageNodePositive[0].InnerText.Trim();
                }
                else
                {
                    ibovespaPercentageVariation = ibovespaPercentageNodeNegative[0].InnerText.Trim();
                }

                return new IbovespaInfoDTO(ibovespaTotalPointsParse, ibovespaPercentageVariation);
            }
            catch (Exception)
            {
                throw new Exception("Desculpe ocorreu algum erro!");
            }
        }
    }
}
