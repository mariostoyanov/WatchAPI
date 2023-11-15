namespace WatchAPi;
using System.Linq;

public class WatchApiHelper {

    public static readonly Watch[] watches = new Watch[]{
        new Watch(1, "Rolex", 100, 3, 200),
        new Watch(2, "Michael Kors", 80, 2, 120),
        new Watch(3, "Swatch", 50),
        new Watch(4, "Casio", 30)
    };

    public static int CheckoutTotal(int[] watchesInCart){
        int total = 0; 

        for (int i = 1; i <= watches.Length; i++){
            int watchCount = watchesInCart.Count(x => x == i);

            int discountCount = 0;
            
            if(watches[i-1].DiscountQuantity.HasValue){
                discountCount = Math.DivRem(watchCount, watches[i-1].DiscountQuantity.Value, out int singlePriceWatch); 
                total += (discountCount * watches[i-1].DiscountAmount.Value) + (singlePriceWatch * watches[i-1].UnitPrice);
            }
            else{
                total += watchCount * watches[i-1].UnitPrice;
            }
        }

        return total; 
    }
}