namespace MethodsAndProperties;

public class BusinessRules
{
    public static bool EligableForVoucher(int NumberOfPurchases, in decimal biggestPurchase) => NumberOfPurchases > 5 && biggestPurchase > 100m;
}
