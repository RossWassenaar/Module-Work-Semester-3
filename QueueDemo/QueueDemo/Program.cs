namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Queues
             * Queues use a first in, first out method (FIFO)
             * First element added is the element to be removed from the queue
             * used in the scenarios in the ticket management system
             */

            Queue<string> ticketQueue = new Queue<string>();
            Stack<string> undoTicketStack = new Stack<string>();

            //Add ticket to the queue (FIFO)
            ticketQueue.Enqueue("Ticket #001: Customer Support");
            ticketQueue.Enqueue("Ticket #002: Customer Support");
            ticketQueue.Enqueue("Ticket #003: Customer Support");

            //Displaying all the tickets in the queue
            foreach (var ticket in ticketQueue)
            {
                Console.WriteLine(ticket);
            }
            Console.WriteLine(); //spacing

            //Peek() shows the first element of the queue. Helps us see the first ticket to attach
            Console.WriteLine("Next ticket to be processed: " + ticketQueue.Peek());

            Console.WriteLine("\nProcessing the next ticket... \n");

            //Stores the removed ticket in case the user wantes to undo the action
            string processedTicket = ticketQueue.Dequeue();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Processed: {processedTicket}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
