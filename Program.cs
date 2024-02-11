using System;

namespace travelWithCount
{
    class Travel
    {
        private static int _transactions = 0;


        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }

        private int _Id;
        private string _Destination;
        private string _Transportation;

        public Travel()
        {
            _Id = 0;
            _Destination = "";
            _Transportation = "";
        }

        public Travel(int i, string Destination, string Transportation)
        {
            _Id = i;
            _Destination = Destination;
            _Transportation = Transportation;
        }

        public string GetFullName()
        {
            return _Destination + " by " + _Transportation;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetDestination(string destination)
        {
            _Destination = destination;
        }

        public void SetTransportation(string transportation)
        {
            _Transportation = transportation;
        }


        static void Main(string[] args)
        {
            Travel trip10 = new Travel();
            trip10.SetTrans();
            trip10.SetId(10);
            trip10.SetDestination("New Orleans");
            trip10.SetTransportation("Train");

            Travel trip20 = new Travel();
            trip20.SetTrans();
            Console.WriteLine("Please enter the trip ID: ");
            trip20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your travel destination: ");
            trip20.SetDestination(Console.ReadLine());
            Console.WriteLine("Please enter your mode of transportation: ");
            trip20.SetTransportation(Console.ReadLine());

            Travel book30 = new Travel(30, "Alaska", "Cruise Ship");
            book30.SetTrans();

            Console.WriteLine("Please enter the trip ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your travel destination: ");
            string tempDestination = Console.ReadLine();
            Console.WriteLine("Please enter your mode of transportation: ");
            string tempTransportation = Console.ReadLine();
            Travel trip40 = new Travel(tempID, tempDestination, tempTransportation);
            trip40.SetTrans();

            Console.WriteLine($"Pack your bags! You have {trip10.GetTrans()} trips planned.");
            displayBooks(trip10);
            displayBooks(trip20);
            displayBooks(book30);
            displayBooks(trip40);
        }

        static void displayBooks(Travel member)
        {
            Console.WriteLine("Here's your travel information");
            Console.WriteLine($"Trip ID: {member.GetId()}");
            Console.WriteLine($"Destination and Mode of Transportation: {member.GetFullName()}");
        }

    }

}

