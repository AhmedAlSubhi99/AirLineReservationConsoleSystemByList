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
        // 1. Shows welcome screen
        public static string DisplayWelcomeMessage()
        { 
            return "";
        }

        // 2. Exit
        public static string ExitApplication()
        {
            return "";
        }

        // 3. Adds a new flight
        public static string AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration, int basePrice, string destination)
        {
            return "";
        }

        // 5. Prints all flights
        public static string DisplayAllFlights()
        {
            return "";
        }

        // 6. Find Flight by Code
        public static string FindFlightByCode(string code)
        {
            return "";
        }

        // 7. Updates the departure time of flight
        public static string UpdateFlightDeparture(ref DateTime departure)
        {
            return "";
        }

        // 8. Cancels a flight booking
        public static string CancelFlightBooking(out string passengerName)
        {
            passengerName = "";
            return "";
        }

        // 9. Books flight
        public static string BookFlight(string passengerName, string flightCode)
        {
            return "";
        }

        // 10. Validate if flight code exists
        public static string ValidateFlightCode(string flightCode)
        {
            return "";
        }

        // 11. Generates booking ID
        public static string GenerateBookingID(string passengerName)
        {
            return "";
        }

        // 12. Display full details of flight using code
        public static string DisplayFlightDetails(string code)
        {

            return "";
        }

        // 13. Display or Search bookings by destination
        public static string SearchBookingsByDestination(string toCity)
        {
            return "";
        }

        // 14. Calculates total fare
        public static int CalculateFare(int basePrice, int numTickets)
        {
            return 0;
        }

        public static string CalculateFare(double basePrice, int numTickets)
        {
            // Empty implementation
            return "";
        }

        // 15. Overloaded version with discount applied
        public static int CalculateFare(int basePrice, int numTickets, int discount = 0)
        {
            return 0;
        }

        // 16. Confirms a user action (e.g., cancel booking)
        public static string ConfirmAction(string action)
        {
            return "";
        }

        // 17. Displays menu
        public static string DisplayMenu()
        {
            return "";
        }

        // 18. Starts the system
        public static void StartSystem()
        {

        }

        // Main function
        static void Main(string[] args)
        {

        }
    }
}