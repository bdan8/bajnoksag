namespace TournamentTracker
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel() { }             

        public PrizeModel(string inPlaceName, string inPlaceNumber, string inPrizePool, string inPrizePercentage)
        {
            PlaceName = inPlaceName;

            int placeNumberValue = 0;
            int.TryParse(inPlaceNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(inPrizePool, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(inPrizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
