namespace TicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Would you like to purchase a bus ticket or a movie ticket?");
                string ticketType = Console.ReadLine();

                if (ticketType.Equals("bus", StringComparison.OrdinalIgnoreCase))
                {
                    Ticket busTicket = new TransportationTicket();
                    busTicket.displayTicket(busTicket.validateTicket());
                }
                else if (ticketType.Equals("movie", StringComparison.OrdinalIgnoreCase))
                {
                    Ticket movieTicket = new EventTicket();
                    movieTicket.displayTicket(movieTicket.validateTicket());
                }
                else
                {
                    Console.WriteLine("Invalid ticket type");
                }

                //asking the user if they would like to purchase another ticket and closing the program if they do not
                Console.WriteLine("Would you like to purchase another ticket? ");
                string response = Console.ReadLine();
                if (response.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
            
            
        }
    }
}
