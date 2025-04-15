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
            try
            {
                // Added confirmation message
                string confirmAdd = ConfirmAction("add flight");
                Console.WriteLine(confirmAdd);

                if (confirmAdd != "add flight confirmed.")
                {
                    return "Flight addition cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight addition confirmed.");
                }

                // Check if flight code is empty
                if (string.IsNullOrEmpty(flightCode))
                {
                    return "Flight code cannot be empty.";
                }

                // Check if flight code already exists
                if (flightCodes.Contains(flightCode))
                {
                    return $"Flight code {flightCode} already exists.";
                }

                // Check if from city is empty
                if (string.IsNullOrEmpty(fromCity))
                {
                    return "From city cannot be empty.";
                }

                // Check if to city is empty
                if (string.IsNullOrEmpty(toCity))
                {
                    return "To city cannot be empty.";
                }

                // Check if departure time is in the past
                if (departureTime < DateTime.Now)
                {
                    return "Departure time cannot be in the past.";
                }

                // Check if duration is valid
                if (duration <= 0)
                {
                    return "Duration must be greater than zero.";
                }

                // Check if base price is valid
                if (basePrice <= 0)
                {
                    return "Base price must be greater than zero.";
                }

                // Check if destination is empty
                if (string.IsNullOrEmpty(destination))
                {
                    return "Destination cannot be empty.";
                }

                // Check if from city and to city are the same
                if (fromCity == toCity)
                {
                    return "From city and to city cannot be the same.";
                }

                // Add flight details to lists
                flightCodes.Add(flightCode);
                fromCities.Add(fromCity);
                toCities.Add(toCity);
                departureTimes.Add(departureTime);
                durations.Add(duration);
                prices.Add(basePrice);
                destinations.Add(destination);

                // print details of the added flight
                return $"Flight {flightCode} added successfully: From {fromCity} to {toCity}, " +
                       $"Departure: {departureTime}, Duration: {duration} mins, Price: ${basePrice}, " +
                       $"Destination: {destination}";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight addition
                return $"Error adding flight due to: {ex.Message}";
            }
        }

        // 6. Prints all flights
        public static string DisplayAllFlights()
        {
            try
            {
                // Added confirmation message
                string confirmDisplay = ConfirmAction("display all flights");
                Console.WriteLine(confirmDisplay);

                if (confirmDisplay != "display all flights confirmed.")
                {
                    return "Flight display cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight display confirmed.");
                }

                // Check if there are any flights
                if (flightCodes.Count == 0)
                {
                    return "No flights available.";
                }

                // Print all flight details
                string flightDetails = "Available Flights:\n";

                for (int i = 0; i < flightCodes.Count; i++)
                {
                    flightDetails += $"{flightCodes[i]}: From {fromCities[i]} to {toCities[i]}, " +
                                    $"Departure: {departureTimes[i]}, Duration: {durations[i]} mins, " +
                                    $"Price: ${prices[i]}, Destination: {destinations[i]}\n";
                }

                return flightDetails;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight display
                return $"Error displaying flights due to: {ex.Message}";
            }
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