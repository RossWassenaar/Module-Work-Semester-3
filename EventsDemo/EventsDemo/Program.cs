namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer t = new Thermometer();

            //Subscriber to the event. Assign method to respond when the event is triggered
            t.Overheat += AlertUser;
            t.Overheat += SendSMS;

            t.CheckTemp(25); //does not trigger the event and the AlertUser method
            t.CheckTemp(50); //triggers the event and the susbcriber method
        }

        static void AlertUser(string message)
        {
            Console.WriteLine("ALERT: " + message);
        }

        static void SendSMS(string message)
        {
            Console.WriteLine("Sending SMS: " + message + "\nMessage sent!");
        }
    }
}
