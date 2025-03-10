using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    abstract class Ticket
    {
        private static int ticketID { get; set; } //ticket ID is a static attribute incrementing for each ticket generated
        protected DateTime issueDate { get; set; } 

        public Ticket()
        {
            ticketID++; //incrementing ticket ID
            issueDate = DateTime.Now; //issue data is always set to the current date
        }

        public abstract bool validateTicket(); //abstract

        public virtual void displayTicket(bool validTicket) //virtual
        {
            Console.WriteLine($"Ticket ID: {ticketID}");
            Console.WriteLine($"Issue Date: {issueDate}");
            if (validTicket)
            {
                Console.WriteLine("Ticket is valid");
            }
            else
            {
                Console.WriteLine("Ticket is invalid");
            }
        }
    }

    class TransportationTicket : Ticket
    {
        private static int availableSeats = 30; //just imagining a bus with 30 seats, static attribute that decrements with each TransportationTicket object generated
        public override bool validateTicket()
        {
            Console.WriteLine("Validating Bus Ticket:\nChecking for available seats...");
            if (availableSeats > 0)
            {
                availableSeats--;
                return true;
            }
            else
            {
                return false; //if 30 tickets are already sold, returns false to indicate no more seats are available
            }
        }
    }

    class EventTicket : Ticket
    {
        private const string BARNEY = "Barney";
        private const string SHREK = "Shrek";
        private const string TERMINATOR = "Terminator";
        private const string FIFTY_SHADES_OF_GREY = "Fifty Shades of Grey";

        private const int BARNEY_AGE_RESTRICTION = 3;
        private const int SHREK_AGE_RESTRICTION = 13;
        private const int TERMINATOR_AGE_RESTRICTION = 16;
        private const int FIFTY_SHADES_OF_GREY_AGE_RESTRICTION = 18;
        
        public override bool validateTicket()
        {
            Console.WriteLine("Please enter your age: "); //requests user for their age to compare to the current movie age restrictions
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select a movie: \nBarney\nShrek\nTerminator\nFifty Shades of Grey"); //requesting user to choose from a list of available movies
            String movie = Console.ReadLine();
            Console.WriteLine("Validating Event Ticket:\nChecking age restriction...");

            //Validating the user is of appropriate viewing age for the selected movie
            if (BARNEY.Equals(movie, StringComparison.OrdinalIgnoreCase))
            {
                return age >= BARNEY_AGE_RESTRICTION;
            }
            else if (SHREK.Equals(movie, StringComparison.OrdinalIgnoreCase))
            {
                return age >= SHREK_AGE_RESTRICTION;
            }
            else if (TERMINATOR.Equals(movie, StringComparison.OrdinalIgnoreCase))
            {
                return age >= TERMINATOR_AGE_RESTRICTION;
            }
            else if (FIFTY_SHADES_OF_GREY.Equals(movie, StringComparison.OrdinalIgnoreCase))
            {
                return age >= FIFTY_SHADES_OF_GREY_AGE_RESTRICTION;
            }
            else
            {
                return false;
            }
        }
    }
}
