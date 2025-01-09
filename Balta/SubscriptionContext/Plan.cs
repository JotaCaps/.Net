namespace Balta.SubscriptionContext;
using SharedContext;

public class Plan : Base
{
    public string Title { get; set; }
    public decimal Price { get; set; }
}