using FileHelpers;

namespace DeleteOrderUtility
{
    [DelimitedRecord(",")]
    public class Order
    {
        public string id { get; set; }
    }
}
