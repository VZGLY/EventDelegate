namespace EventDelegate;

public class User
{
    public event NewsletterDelegate? NewsletterEvent;
    
    public string Email { get; set; }

    public void Notify()
    {
        NewsletterEvent?.Invoke(this);
    }
}