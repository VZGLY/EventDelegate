namespace EventDelegate;

public class Société
{
    public List<User> Users { get; set; } = new List<User>();

    private void MailNews(User user)
    {
        Console.WriteLine($"Hello {user.Email} ! voila les news !");
    }
    
    private void MailNoreply(User user)
    {
        Console.WriteLine($"Hello {user.Email} ! repond as fdp !");
    }
    
    private void MailNudes(User user)
    {
        Console.WriteLine($"Hello {user.Email} ! ( o )( o ) !");
    }

    public void AjouterNudes(User user)
    {
        user.NewsletterEvent += MailNudes;
    }
    
    public void AjouterNews(User user)
    {
        user.NewsletterEvent += MailNews;
    }
    
    public void AjouterNoreplay(User user)
    {
        user.NewsletterEvent += MailNoreply;
    }

    public void SendMails()
    {
        foreach (User user in Users)
        {
            user.Notify();
        }
    }
}