namespace DecoratorNS;

internal class Decorator: Message
{
    protected readonly Message _wrapper;

    public Decorator(Message wrapper)
    {
        _wrapper = wrapper;
    }
    //public override void SendMessage(string message)
    //{ 
    //}
}
