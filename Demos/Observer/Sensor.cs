namespace ObserverNS
{
    internal class Sensor
    {
        private List<Observer> _observers=new List<Observer>();
        public event Action<string> OnChange;

        public void Register(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detect(string what)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(what);
            }
            OnChange?.Invoke(what);
        }
    }
}