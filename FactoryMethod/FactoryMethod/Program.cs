using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        public static VesselFactory GetFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new PassengerVesselFactory();

                case 2:
                    return new FreightVesselFactory();

                case 3:
                    return new SpecializedVesselFactory();
            }

            return new UnidentifiedVesselFactory();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to shipbuilding:)\n\n");


            Console.WriteLine("1 - Create Passenger Vessel");
            Console.WriteLine("2 - Create Freight Vessel");
            Console.WriteLine("3 - Create Specialized Vessel\n");
            Console.Write("Pick one: ");


            int choice = int.Parse(Console.ReadLine());
            
            VesselFactory vesselFactory = GetFactory(choice);
            IVessel vessel = vesselFactory.GetVessel();

            Console.WriteLine("\nVessel properties:\n\n");

            Console.WriteLine($"Name => {vessel.Name}");
            Console.WriteLine($"Width => {vessel.Width}");
            Console.WriteLine($"Height => {vessel.Height}");
            Console.WriteLine($"Length => {vessel.Length}");
            Console.WriteLine($"Load Capacity => {vessel.LoadCapacity}");
            Console.WriteLine($"Quantity of Decks => {vessel.QuantityOfDecks}");
            Console.WriteLine($"Price => {vessel.GetVesselPrice()}\n\n");
        }
    }
}
