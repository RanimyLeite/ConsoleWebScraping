using HtmlAgilityPack;
using System;
using Xunit;

namespace ConsoleWebScrapingTestes
{
    public class IbovespaWebScrapingTeste
    {
        [Fact]
        public void TesteGetIbovespaInfoSuccess()
        {
            //Arrange
            var web =  new HtmlWeb();

            //Act
            var result = web.Load("https://www.google.com/");

            //Assert
            Assert.NotNull(result);
        }
    }
}
