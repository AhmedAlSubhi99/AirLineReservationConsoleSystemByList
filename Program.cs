using System;
using System.Collections.Generic;

namespace AirLineReservationConsoleSystem
{
    internal class Program
    {
        // Airline Reservation System Functions
        // ──────────────────────────────
        // 1. Lists for Flights
        public static List<string> flightCodes = new List<string>();
        public static List<string> fromCities = new List<string>();
        public static List<string> toCities = new List<string>();
        public static List<DateTime> departureTimes = new List<DateTime>();
        public static List<int> durations = new List<int>();
        public static List<int> prices = new List<int>();
        public static List<string> destinations = new List<string>();


        // ──────────────────────────────
        // 2. Lists for Bookings
        public static List<string> bookingIDs = new List<string>();
        public static List<string> bookedFlightCodes = new List<string>();
        public static List<string> bookedFromCities = new List<string>();
        public static List<string> bookedToCities = new List<string>();
        public static List<DateTime> bookedDepartureTimes = new List<DateTime>();
        public static List<int> bookedDurations = new List<int>();
        public static List<int> bookedPrices = new List<int>();
        public static List<string> bookedDestinations = new List<string>();
        public static List<string> bookedPassengerNames = new List<string>();

        // ──────────────────────────────
        // Main function
        static void Main(string[] args)
        {
            // 1. Starts the system
            StartSystem();
        }

        // 1. Starts the system
        public static void StartSystem()
        {

        }

        // 2. Displays menu
        public static string DisplayMenu()
        {
            try
            {
                // Display menu header
                Console.WriteLine("=====================================");
                Console.WriteLine("| Airline Reservation System Menu |");
                Console.WriteLine("=====================================");

                // Display menu options
                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. Display All Flights");
                Console.WriteLine("3. Find Flight by Code");
                Console.WriteLine("4. Update Flight Departure");
                Console.WriteLine("5. Cancel Flight Booking");
                Console.WriteLine("6. Book Flight");
                Console.WriteLine("7. Validate Flight Code");
                Console.WriteLine("8. Display Flight Details");
                Console.WriteLine("9. Search Bookings by Destination");
                Console.WriteLine("10. Exit Application");
                Console.WriteLine("=====================================");

                // Display menu footer
                Console.WriteLine("Please select an option from the menu above.");

                // Return menu display message
                Console.WriteLine("=====================================");
                return "Menu displayed.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during menu display
                return $"Error displaying menu due to: {ex.Message}";
            }
        }

        // 3. Shows welcome screen
        public static string DisplayWelcomeMessage()
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Airline Reservation System!");
            Console.WriteLine("=====================================");
            Console.WriteLine("Please follow the instructions to proceed.");
            Console.WriteLine("=====================================");
            // Return welcome message
            return "Welcome message displayed.";
        }

        // 4. Exit
        public static string ExitApplication()
        {
            // Display exit message
            Console.WriteLine("Thank you for using the Airline Reservation System!");
            Console.WriteLine("Goodbye!");
            // Return exit message
            return "Application exited.";
        }

        // 5. Adds a new flight
        public static string AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration, int basePrice, string destination)
        {
            return "";
        }

        // 6. Prints all flights
        public static string DisplayAllFlights()
        {
            return "";
        }

        // 7. Find Flight by Code
        public static string FindFlightByCode(string code)
        {
            return "";
        }

        // 8. Updates the departure time of flight
        public static string UpdateFlightDeparture(ref DateTime departure)
        {
            return "";
        }

        // 9. Cancels a flight booking
        public static string CancelFlightBooking(out string passengerName)
        {
            passengerName = "";
            return "";
        }

        // 10. Books flight
        public static string BookFlight(string passengerName, string flightCode)
        {
            return "";
        }

        // 11. Validate if flight code exists
        public static string ValidateFlightCode(string flightCode)
        {
            return "";
        }

        // 12. Generates booking ID
        public static string GenerateBookingID(string passengerName)
        {
            return "";
        }

        // 13. Display full details of flight using code
        public static string DisplayFlightDetails(string code)
        {

            return "";
        }

        // 14. Display or Search bookings by destination
        public static string SearchBookingsByDestination(string toCity)
        {
            return "";
        }

        // 15. Calculates total fare
        public static int CalculateFare(int basePrice, int numTickets)
        {
            return 0;
        }

        public static string CalculateFare(double basePrice, int numTickets)
        {
            // Empty implementation
            return "";
        }

        // 16. Overloaded version with discount applied
        public static int CalculateFare(int basePrice, int numTickets, int discount = 0)
        {
            return 0;
        }

        // 17. Confirms a user action (e.g., cancel booking)
        public static string ConfirmAction(string action)
        {
            return "";
        }
    }
}