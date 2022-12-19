
namespace ConsoleWebScraping.DTOs
{
    public class IbovespaInfoDTO
    {
        public double TotalPoints { get; set; }

        public string PercentagemVariation { get; set; }

        public IbovespaInfoDTO()
        {

        }

        public IbovespaInfoDTO(double totalPoints, string percentagemVariation)
        {
            TotalPoints = totalPoints;
            PercentagemVariation = percentagemVariation;
        }
    }
}
