namespace WatchAPi;

public class Watch
{
    public int WatchId { get; set; }
    public string WatchName { get; set; }
    public int UnitPrice { get; set; }
    public int? DiscountQuantity { get; set; }
    public int? DiscountAmount { get; set; }

    public Watch (int watchId, string watchName, int unitPrice, int? discountQuantity = null, int? discountAmount = null){
        WatchId = watchId; 
        WatchName = watchName; 
        UnitPrice = unitPrice;
        DiscountQuantity = discountQuantity; 
        DiscountAmount = discountAmount;
    }
}
