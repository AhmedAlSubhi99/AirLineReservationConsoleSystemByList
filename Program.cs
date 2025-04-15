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
            try
            {
                // Added confirmation message
                string confirmFind = ConfirmAction("find flight");
                Console.WriteLine(confirmFind);

                if (confirmFind != "find flight confirmed.")
                {
                    return "Flight search cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight search confirmed.");
                }

                // Check if there are any flights
                if (flightCodes.Count == 0)
                {
                    return "No flights available.";
                }

                // Check if flight code is empty
                if (string.IsNullOrEmpty(code))
                {
                    return "Flight code cannot be empty.";
                }

                // Search for flight code in the list
                int index = flightCodes.IndexOf(code);
                if (index != -1)
                {
                    return $"Flight {code} found: From {fromCities[index]} to {toCities[index]}, " +
                           $"Departure: {departureTimes[index]}, Duration: {durations[index]} mins, " +
                           $"Price: ${prices[index]}, Destination: {destinations[index]}";
                }

                return $"Flight {code} not found.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight search
                return $"Error finding flight due to: {ex.Message}";
            }
        }

        // 8. Updates the departure time of flight
        public static string UpdateFlightDeparture(ref DateTime departure)
        {
            try
            {
                // Added confirmation message
                string confirmUpdate = ConfirmAction("update flight departure");
                Console.WriteLine(confirmUpdate);

                if (confirmUpdate != "update flight departure confirmed.")
                {
                    return "Flight update cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight update confirmed.");
                }

                // Check if departure time is in the past
                if (departure < DateTime.Now)
                {
                    return "Departure time cannot be in the past.";
                }

                // Check if there are any flights
                if (flightCodes.Count == 0)
                {
                    return "No flights available to update.";
                }

                // Update flight departure time
                Console.Write("Enter flight code to update: ");
                string flightCode = Console.ReadLine();

                int index = flightCodes.IndexOf(flightCode);
                if (index != -1)
                {
                    departureTimes[index] = departure;
                    return $"Flight {flightCode} departure time updated to {departure}.";
                }

                return $"Flight {flightCode} not found.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight update
                return $"Error updating flight due to: {ex.Message}";
            }
        }

        // 9. Cancels a flight booking
        public static string CancelFlightBooking(out string passengerName)
        {
            try
            {
                // Added confirmation message
                string confirmCancel = ConfirmAction("cancel flight booking");
                Console.WriteLine(confirmCancel);
                if (confirmCancel != "cancel flight booking confirmed.")
                {
                    passengerName = "";
                    return "Flight cancellation cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight cancellation confirmed.");
                }
                // Check if there are any bookings
                if (bookingIDs.Count == 0)
                {
                    passengerName = "";
                    return "No bookings available to cancel.";
                }
                // Cancel flight booking
                Console.Write("Enter booking ID to cancel: ");
                string bookingID = Console.ReadLine();
                int index = bookingIDs.IndexOf(bookingID);
                if (index != -1)
                {
                    bookingIDs.RemoveAt(index);
                    bookedFlightCodes.RemoveAt(index);
                    bookedFromCities.RemoveAt(index);
                    bookedToCities.RemoveAt(index);
                    bookedDepartureTimes.RemoveAt(index);
                    bookedDurations.RemoveAt(index);
                    bookedPrices.RemoveAt(index);
                    bookedDestinations.RemoveAt(index);
                    passengerName = bookedPassengerNames[index];
                    bookedPassengerNames.RemoveAt(index);
                    return $"Booking {bookingID} cancelled successfully for passenger {passengerName}.";
                }
                passengerName = "";
                return $"Booking {bookingID} not found.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight cancellation
                passengerName = "";
                return $"Error cancelling flight due to: {ex.Message}";
            }
            
        }

        // 10. Books flight
        public static string BookFlight(string passengerName, string flightCode)
        {
            try
            {
                // Added confirmation message
                string confirmBook = ConfirmAction("book flight");
                Console.WriteLine(confirmBook);
                if (confirmBook != "book flight confirmed.")
                {
                    return "Flight booking cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight booking confirmed.");
                }
                // Check if flight code is empty
                if (string.IsNullOrEmpty(flightCode))
                {
                    return "Flight code cannot be empty.";
                }
                // Check if passenger name is empty
                if (string.IsNullOrEmpty(passengerName))
                {
                    return "Passenger name cannot be empty.";
                }
                // Check if flight code exists
                int index = flightCodes.IndexOf(flightCode);
                if (index != -1)
                {
                    // Add booking details to lists
                    bookingIDs.Add(GenerateBookingID(passengerName));
                    bookedFlightCodes.Add(flightCodes[index]);
                    bookedFromCities.Add(fromCities[index]);
                    bookedToCities.Add(toCities[index]);
                    bookedDepartureTimes.Add(departureTimes[index]);
                    bookedDurations.Add(durations[index]);
                    bookedPrices.Add(prices[index]);
                    bookedDestinations.Add(destinations[index]);
                    bookedPassengerNames.Add(passengerName);
                    return $"Flight {flightCode} booked successfully for passenger {passengerName}.";
                }
                return $"Flight {flightCode} not found.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight booking
                return $"Error booking flight due to: {ex.Message}";
            }
        }

        // 11. Validate if flight code exists
        public static string ValidateFlightCode(string flightCode)
        {
            try
            {
                // Added confirmation message
                string confirmValidate = ConfirmAction("validate flight code");
                Console.WriteLine(confirmValidate);

                if (confirmValidate != "validate flight code confirmed.")
                {
                    return "Flight validation cancelled.";
                }
                else
                {
                    Console.WriteLine("Flight validation confirmed.");
                }

                // Check if flight code is empty
                if (string.IsNullOrEmpty(flightCode))
                {
                    return "Flight code cannot be empty.";
                }

                // Check if there are any flights
                if (flightCodes.Count == 0)
                {
                    return "No flights available to validate.";
                }

                // Search for flight code in the list
                if (flightCodes.Contains(flightCode))
                {
                    return $"Flight {flightCode} is valid.";
                }

                return $"Flight {flightCode} is not valid.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during flight validation
                return $"Error validating flight code due to: {ex.Message}";
            }
        }

        // 12. Generates booking ID
        public static string GenerateBookingID(string passengerName)
        {
            try
            {
                // Check if passenger name is empty
                if (string.IsNullOrEmpty(passengerName))
                {
                    return "Passenger name cannot be empty.";
                }

                // Create a random number generator
                Random random = new Random();

                // Generate random number
                int randomNumber = random.Next(001, 500);

                // Create a booking ID using the passenger name and random number
                string bookingID = $"{passengerName.ToUpper()}-{randomNumber}";

                return bookingID;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during booking ID generation
                return $"Error generating booking ID due to: {ex.Message}";
            }
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