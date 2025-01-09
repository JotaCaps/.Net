namespace Balta.SubscriptionContext;
using Balta.SharedContext;
using Balta.NotificationContext;


public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }

    public IList<Subscription> Subscriptions { get; set; }

    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public void CreateSubscription(Subscription subscription)
    {
        if(IsPremium)
        {
            AddNotification(new Notification("Premium" , "O Aluno já tem uma assinatura ativa"));
            return;
        }

        Subscriptions.Add(subscription);
    }

}