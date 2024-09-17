using System;

public class Publisher
{
    // decalre the event
    public event Action Notify;

    // the function that raises the event
    public void RaiseEvent()
    {
        Notify?.Invoke();
    }
}

public class Subscriber
{
    int x;
    public Subscriber(int x) => this.x = x;
    // any function that should be called when the event is raised
    public void OnNotify() => Console.WriteLine($"Event received by Subscriber0{x}");

}

class Program
{
    static void MainV02()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber01 = new Subscriber(1);
        Subscriber subscriber02 = new Subscriber(2);


        // Subscribe to the event
        publisher.Notify += subscriber01.OnNotify;
        publisher.Notify += subscriber02.OnNotify;


        // Raise the event
        publisher.RaiseEvent();
    }
}
