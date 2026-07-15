namespace oop_part_2_task_7
{
    public class Room
    {

        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Parameterless Constructor
        public Room()
        {

        }

        // Parameterized Constructor
        public Room(string roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        public void DisplayRoom()
        {
            Console.WriteLine("\n--- Room Details ---");
            Console.WriteLine("Room Number:     " + RoomNumber);
            Console.WriteLine("Room Type:       " + RoomType);
            Console.WriteLine("Price Per Night: $" + PricePerNight);
            Console.WriteLine("Availability:    " + (IsAvailable ? "Available" : "Occupied"));
        }
    }

    public class Guest
    {

        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        //Parameterless Constructor
        public Guest()
        {
        }

        //Parameterized Constructor
        public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }


        public void DisplayGuest()
        {
            Console.WriteLine("\n--- Guest Profile ---");
            Console.WriteLine("Guest ID:      " + GuestId);
            Console.WriteLine("Guest Name:    " + GuestName);
            Console.WriteLine("Assigned Room: #" + RoomNumber);
            Console.WriteLine("Check-in Date: " + CheckInDate);
            Console.WriteLine("Total Nights:  " + TotalNights);
        }


        public double CalculateTotalCost(Room room)
        {
            if (room == null)
            {
                Console.WriteLine("No room reference provided");
                return 0.0;
            }


            if (room.RoomNumber != this.RoomNumber)
            {
                Console.WriteLine("Room not matching, Calculating anyway based on Room " + room.RoomNumber);
            }

            return TotalNights * room.PricePerNight;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            // Pre-load rooms with at least 6 rooms (Single, Double, Suite)
            rooms.Add(new Room("101", "Single", 50.00, true));
            rooms.Add(new Room("102", "Single", 50.00, true));
            rooms.Add(new Room("201", "Double", 85.00, true));
            rooms.Add(new Room("202", "Double", 85.00, true));
            rooms.Add(new Room("301", "Suite", 150.00, true));
            rooms.Add(new Room("302", "Suite", 200.00, true));

            while (true)
            {
                Console.WriteLine("\n================================================");
                Console.WriteLine("     GRAND VISTA HOTEL — MANAGEMENT SYSTEM      ");
                Console.WriteLine("================================================");
                Console.WriteLine("C# OOP — Phase 2 | Hotel Management System");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Select an option (0-15): ");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("--- Add New Room ---");

                        Console.Write("Enter Room Number: ");
                        string newRoomNum = Console.ReadLine();

                        int parsedRoomNum = int.Parse(newRoomNum);
                        if (parsedRoomNum <= 0)
                        {
                            Console.WriteLine("Room number must be positive.");
                            break;
                        }

                        bool roomExists = rooms.Any(r => r.RoomNumber == newRoomNum);
                        if (roomExists)
                        {
                            Console.WriteLine("Room already exists.");
                            break;
                        }

                        Console.Write("Enter Room Type (Single / Double / Suite): ");
                        string newRoomType = Console.ReadLine();

                        Console.Write("Enter Price Per Night: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        if (newPrice <= 0)
                        {
                            Console.WriteLine("Price must be positive.");
                            break;
                        }

                        Room newlyCreatedRoom = new Room(newRoomNum, newRoomType, newPrice, true);
                        rooms.Add(newlyCreatedRoom);

                        Console.WriteLine();
                        newlyCreatedRoom.DisplayRoom();
                        Console.WriteLine("Total rooms in inventory: " + rooms.Count);
                        break;

                    case 2:
               
                        Console.WriteLine("--- Register New Guest ---");

                        Console.Write("Enter Guest Name: ");
                        string gName = Console.ReadLine();

                        Console.Write("Enter Check-in Date: ");
                        string cDate = Console.ReadLine();

                        Console.Write("Enter Number of Nights: ");
                        int nights = int.Parse(Console.ReadLine());
                        if (nights <= 0)
                        {
                            Console.WriteLine("Number of nights must be positive.");
                            break;
                        }

                        int nextIdNumber = guests.Count + 1;
                        string formattedId = "G00" + nextIdNumber;

                        Guest newGuest = new Guest(formattedId, gName,"Not Assigned", cDate, nights);
                        guests.Add(newGuest);

                        newGuest.DisplayGuest();
                        break;
                        
                    case 3:
                        Console.WriteLine("--- Book a Room for a Guest ---");

                        Console.Write("Enter Guest ID: ");
                        string lookupGuestId = Console.ReadLine();

                        Console.Write("Enter Room Number: ");
                        string lookupRoomNum = Console.ReadLine();

                        Guest foundGuest = guests.FirstOrDefault(g => g.GuestId == lookupGuestId);
                        if (foundGuest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        Room foundRoom = rooms.FirstOrDefault(r => r.RoomNumber == lookupRoomNum);
                        if (foundRoom == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        if (!foundRoom.IsAvailable)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }

                        foundGuest.RoomNumber = foundRoom.RoomNumber;
                        foundRoom.IsAvailable = false;

                        double totalCost = foundGuest.CalculateTotalCost(foundRoom);

                       
                        Console.WriteLine("Booking Confirmation:");
                        foundGuest.DisplayGuest();
                        foundRoom.DisplayRoom();
                        Console.WriteLine("Total Booking Cost: $" + totalCost);


                        break;

                    case 4:
                        Console.WriteLine("--- View All Rooms ---");

                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }

                        int totalRooms = rooms.Count();
                        Console.WriteLine("Total Rooms: " + totalRooms);

                        List<Room> sortedRooms = rooms
                            .OrderBy(r => r.RoomNumber)
                            .Select(r => r)
                            .ToList();

                        foreach (Room r in sortedRooms)
                        {
                            r.DisplayRoom();
                        }
                        break;

                    case 5:
                        Console.WriteLine("--- View All Guests ---");

                        if (guests.Count == 0)
                        {
                            Console.WriteLine("No guests have been registered yet.");
                            break;
                        }

                        int totalGuests = guests.Count();
                        Console.WriteLine("Total Guests: " + totalGuests);

                        List<Guest> sortedGuests = guests
                            .OrderBy(g => g.GuestName)
                            .Select(g => g)
                            .ToList();

                        foreach (Guest g in sortedGuests)
                        {
                            g.DisplayGuest();
                        }
                        break;

                    case 6:


                        Console.WriteLine("--- Room Search & Analysis ---");
                        Console.WriteLine("1. Show all available rooms");
                        Console.WriteLine("2. Filter by room type");
                        Console.WriteLine("3. Filter by max price");
                        Console.WriteLine("4. Room price statistics");
                        Console.WriteLine("0. Back");
                        Console.Write("Enter your choice: ");
                        string subChoice = Console.ReadLine();

                        if (subChoice == "1")
                        {
                            List<Room> availableRooms = rooms
                                .Where(r => r.IsAvailable)
                                .OrderBy(r => r.PricePerNight)
                                .Select(r => r)
                                .ToList();

                           
                            Console.WriteLine("Available Rooms Count: " + availableRooms.Count);
                            if (availableRooms.Count == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                foreach (Room r in availableRooms)
                                {
                                    r.DisplayRoom();
                                }
                            }
                        }
                        else if (subChoice == "2")
                        {
                            Console.Write("Enter Room Type (Single / Double / Suite): ");
                            string searchType = Console.ReadLine();

                            List<Room> typeRooms = rooms
                                .Where(r => r.RoomType.ToLower() == searchType.ToLower())
                                .Select(r => r)
                                .ToList();

                           
                            Console.WriteLine("Rooms Found: " + typeRooms.Count);
                            if (typeRooms.Count == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                foreach (Room r in typeRooms)
                                {
                                    r.DisplayRoom();
                                }
                            }
                        }
                        else if (subChoice == "3")
                        {
                            Console.Write("Enter Maximum Price: ");
                            double maxPrice = double.Parse(Console.ReadLine());

                            List<Room> budgetRooms = rooms
                                .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                                .OrderBy(r => r.PricePerNight)
                                .Select(r => r)
                                .ToList();

                           
                            Console.WriteLine("Rooms Found: " + budgetRooms.Count);
                            if (budgetRooms.Count == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                foreach (Room r in budgetRooms)
                                {
                                    r.DisplayRoom();
                                }
                            }
                        }
                        else if (subChoice == "4")
                        {
                            
                            Console.WriteLine("--- Room Statistics ---");

                            if (rooms.Count == 0)
                            {
                                Console.WriteLine("No rooms in the system to calculate statistics.");
                            }
                            else
                            {
                              
                                int availableRoomsCount = rooms.Count(r => r.IsAvailable);
                                double avgPrice = rooms.Average(r => r.PricePerNight);
                                double minPrice = rooms.Min(r => r.PricePerNight);
                                double maxPriceInSystem = rooms.Max(r => r.PricePerNight);

                                Console.WriteLine("Total Rooms: " + rooms.Count());
                                Console.WriteLine("Available Rooms: " + availableRoomsCount);
                                Console.WriteLine("Average Price: $" + avgPrice.ToString("F2"));
                                Console.WriteLine("Cheapest Price: $" + minPrice.ToString("F2"));
                                Console.WriteLine("Most Expensive Price: $" + maxPriceInSystem.ToString("F2"));
                            }
                        }
                        break;

                    case 7:
                        Console.WriteLine("--- Occupancy & Revenue Report ---");

                        int totalRegGuests = guests.Count();
                        int activeBookedGuestsCount = guests.Where(g => g.RoomNumber != "Not Assigned").Count();

                        int totalRoomsCount = rooms.Count();
                        int bookedRoomsCount = rooms.Where(r => !r.IsAvailable).Count();

                        Console.WriteLine("Total Registered Guests: " + totalRegGuests);
                        Console.WriteLine("Guests with Active Bookings: " + activeBookedGuestsCount);
                        Console.WriteLine("Total Rooms: " + totalRoomsCount);
                        Console.WriteLine("Booked Rooms: " + bookedRoomsCount);

                        if (!guests.Any(g => g.RoomNumber != "Not Assigned"))
                        {
                            Console.WriteLine("\nNo active bookings recorded.");
                            break;
                        }

                        double avgNights = guests
                            .Where(g => g.RoomNumber != "Not Assigned")
                            .Average(g => g.TotalNights);

                        Console.WriteLine("Average Nights of Booked Guests: " + avgNights.ToString("F2"));

                     
                        Console.WriteLine("--- Top 3 Highest-Spending Guests ---");

                        List<string> topGuestsLines = guests
                            .Where(g => g.RoomNumber != "Not Assigned")
                            .OrderByDescending(g => g.CalculateTotalCost(rooms.Where(r => r.RoomNumber == g.RoomNumber).FirstOrDefault()))
                            .Take(3)
                            .Select(g => "Guest: " + g.GuestName + " | Room: " + g.RoomNumber + " | Total Cost: OMR " + g.CalculateTotalCost(rooms.Where(r => r.RoomNumber == g.RoomNumber).FirstOrDefault()).ToString("F2"))
                            .ToList();

                        foreach (string line in topGuestsLines)
                        {
                            Console.WriteLine(line);
                        }

                       
                        Console.WriteLine("--- Booked Guests Summary ---");

                        List<string> summaryLines = guests
                            .Where(g => g.RoomNumber != "Not Assigned")
                            .Select(g => g.GuestName + " — Room " + g.RoomNumber + " — " + g.TotalNights + " nights — OMR " + g.CalculateTotalCost(rooms.Where(r => r.RoomNumber == g.RoomNumber).FirstOrDefault()).ToString("F2"))
                            .ToList();

                        foreach (string line in summaryLines)
                        {
                            Console.WriteLine(line);
                        }
                        break;

                    case 8:
                        Console.WriteLine("--- Update Room Price ---");

                        Console.Write("Enter Room Number: ");
                        string searchRoomNum = Console.ReadLine();

                        Room targetRoom = rooms.FirstOrDefault(r => r.RoomNumber == searchRoomNum);
                        if (targetRoom == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        Console.Write("Enter New Price Per Night: ");
                        double newPriceInput = double.Parse(Console.ReadLine());
                        if (newPriceInput <= 0)
                        {
                            Console.WriteLine("Price must be positive.");
                            break;
                        }

                        double oldPrice = targetRoom.PricePerNight;
                        targetRoom.PricePerNight = newPriceInput;

                        
                        Console.WriteLine("Price updated successfully!");
                        Console.WriteLine("Room Number: " + targetRoom.RoomNumber);
                        Console.WriteLine("Old Price: $" + oldPrice.ToString("F2"));
                        Console.WriteLine("New Price: $" + targetRoom.PricePerNight.ToString("F2"));
                        break;

                    case 9:
                        Console.WriteLine("--- Search Guest by Name ---");

                        Console.Write("Enter name or partial name: ");
                        string searchText = Console.ReadLine();

                        List<Guest> matchingGuests = guests
                            .Where(g => g.GuestName.ToLower().Contains(searchText.ToLower()))
                            .ToList();

                        Console.WriteLine("Matches Found: " + matchingGuests.Count());

                        if (matchingGuests.Count() == 0)
                        {
                            Console.WriteLine("No guests matched that search.");
                        }
                        else
                        {
                            foreach (Guest g in matchingGuests)
                            {
                                g.DisplayGuest();
                            }
                        }
                        break;

                    case 10:

                        Console.WriteLine("--- Inventory & Pricing Breakdown ---");

                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms in the system to analyze.");
                            break;
                        }

                        int singleCount = rooms.Count(r => r.RoomType.ToLower() == "single");
                        string singleAvgStr = singleCount > 0
                            ? "OMR " + rooms.Where(r => r.RoomType.ToLower() == "single").Average(r => r.PricePerNight).ToString("F2")
                            : "N/A";

                        int doubleCount = rooms.Count(r => r.RoomType.ToLower() == "double");
                        string doubleAvgStr = doubleCount > 0
                            ? "OMR " + rooms.Where(r => r.RoomType.ToLower() == "double").Average(r => r.PricePerNight).ToString("F2")
                            : "N/A";

                        int suiteCount = rooms.Count(r => r.RoomType.ToLower() == "suite");
                        string suiteAvgStr = suiteCount > 0
                            ? "OMR " + rooms.Where(r => r.RoomType.ToLower() == "suite").Average(r => r.PricePerNight).ToString("F2")
                            : "N/A";

                        double overallAvg = rooms.Average(r => r.PricePerNight);

                        Console.WriteLine("Single Rooms Count: " + singleCount + " | Average Price: " + singleAvgStr);
                        Console.WriteLine("Double Rooms Count: " + doubleCount + " | Average Price: " + doubleAvgStr);
                        Console.WriteLine("Suite Rooms Count: " + suiteCount + " | Average Price: " + suiteAvgStr);
                        Console.WriteLine("Overall Average Price: OMR " + overallAvg.ToString("F2"));
                        break;

                    case 11:

                        Console.WriteLine("--- Guest Checkout ---");

                        Console.Write("Enter Guest ID to check out: ");
                        string checkoutId = Console.ReadLine();

                        Guest checkoutGuest = guests.FirstOrDefault(g => g.GuestId == checkoutId);
                        if (checkoutGuest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        if (checkoutGuest.RoomNumber == "Not Assigned")
                        {
                            Console.WriteLine("This guest has no active booking.");
                            break;
                        }

                        Room linkedRoom = rooms.FirstOrDefault(r => r.RoomNumber == checkoutGuest.RoomNumber);
                        if (linkedRoom == null)
                        {
                            Console.WriteLine("Error: Assigned room not found in the system.");
                            break;
                        }

                        double tCost = checkoutGuest.CalculateTotalCost(linkedRoom);

                        
                        Console.WriteLine("--- Final Bill ---");
                        Console.WriteLine("Guest Name: " + checkoutGuest.GuestName);
                        Console.WriteLine("Room Number: " + linkedRoom.RoomNumber);
                        Console.WriteLine("Room Type: " + linkedRoom.RoomType);
                        Console.WriteLine("Check-in Date: " + checkoutGuest.CheckInDate);
                        Console.WriteLine("Total Nights: " + checkoutGuest.TotalNights);
                        Console.WriteLine("Price Per Night: OMR " + linkedRoom.PricePerNight.ToString("F2"));
                        Console.WriteLine("Total Cost: OMR " + tCost.ToString("F2"));
                        

                        Console.Write("Confirm checkout (Y/N): ");
                        string confirm = Console.ReadLine();

                        if (confirm.ToLower() == "y")
                        {
                            linkedRoom.IsAvailable = true;
                            guests.Remove(checkoutGuest);

                            
                            Console.WriteLine("Checkout completed successfully.");
                            Console.WriteLine("Total Registered Guests Now: " + guests.Count);
                            Console.WriteLine("Total Rooms in System: " + rooms.Count);

                            bool isRoomFreeNow = rooms.Any(r => r.RoomNumber == linkedRoom.RoomNumber && r.IsAvailable);
                            Console.WriteLine("Room " + linkedRoom.RoomNumber + " is now available: " + isRoomFreeNow);
                        }
                        else
                        {
                            Console.WriteLine("Checkout cancelled. No changes were made.");
                        }
                        break;

                    case 12:

                       
                        Console.WriteLine("--- Decommission Rooms ---");

                       
                        List<Room> removableRooms = rooms
                            .Where(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber))
                            .OrderBy(r => r.RoomNumber)
                            .ToList();

                        
                        if (removableRooms.Count == 0)
                        {
                            Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                            break;
                        }

                        
                        Console.WriteLine("Safely Removable Rooms (Unavailable but Unoccupied):");
                        foreach (Room r in removableRooms)
                        {
                            r.DisplayRoom();
                        }

                        
                        
                        Console.Write("Found " + removableRooms.Count + " removable room(s). Confirm decommissioning? (Y/N): ");
                        string confirmInput = Console.ReadLine();

                        if (confirmInput.ToLower() == "y")
                        {
                            
                            rooms.RemoveAll(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber));

                           
                            Console.WriteLine("Rooms decommissioned successfully!!!!!!!!!!!!!!");
                            Console.WriteLine("Updated Total Room Count: " + rooms.Count);

                            Console.WriteLine("\nRemaining Rooms in System:");
                            rooms
                                .Select(r => "Room #" + r.RoomNumber + " (" + r.RoomType + ")")
                                .ToList()
                                .ForEach(Console.WriteLine);
                        }
                        else
                        {
                            Console.WriteLine("Operation cancelled. No rooms were removed.");
                        }
                        break;

                    case 13:

                        Console.WriteLine("--- Extend Guest Stay ---");

                        Console.Write("Enter Guest ID: ");
                        string searchGuestId = Console.ReadLine();

                        Guest extendGuest = guests.FirstOrDefault(g => g.GuestId == searchGuestId);
                        if (extendGuest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        if (extendGuest.RoomNumber == "Not Assigned")
                        {
                            Console.WriteLine("This guest has no active booking to extend.");
                            break;
                        }

                        Console.Write("Enter number of additional nights: ");
                        int additionalNights = int.Parse(Console.ReadLine());
                        if (additionalNights <= 0)
                        {
                            Console.WriteLine("Invalid input. Additional nights must be a positive integer.");
                            break;
                        }

                        Room guestRoom = rooms.FirstOrDefault(r => r.RoomNumber == extendGuest.RoomNumber);
                        if (guestRoom == null)
                        {
                            Console.WriteLine("Error: Assigned room not found in the system.");
                            break;
                        }

                        extendGuest.TotalNights += additionalNights;
                        double newCost = extendGuest.CalculateTotalCost(guestRoom);

                        Console.WriteLine("Stay extended successfully!");
                        Console.WriteLine("Updated Total Nights: " + extendGuest.TotalNights);
                        Console.WriteLine("New Total Cost: OMR " + newCost.ToString("F2"));
                        break;

                    case 14:

                        Console.WriteLine("--- Highest-Revenue Booking ---");

                        if (!guests.Any(g => g.RoomNumber != "Not Assigned"))
                        {
                            Console.WriteLine("No active bookings recorded.");
                            break;
                        }

                       
                        List<Guest> highestGuestList = guests
                            .Where(g => g.RoomNumber != "Not Assigned")
                            .OrderByDescending(g => g.CalculateTotalCost(rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber)))
                            .Take(1)
                            .ToList();

                        if (highestGuestList.Count > 0)
                        {
                            Guest highestGuest = highestGuestList[0];
                            Room highestGuestRoom = rooms.FirstOrDefault(r => r.RoomNumber == highestGuest.RoomNumber);
                            double finalCost = highestGuest.CalculateTotalCost(highestGuestRoom);

                            Console.WriteLine("Top Earning Booking:");
                            Console.WriteLine("Guest Name: " + highestGuest.GuestName);
                            Console.WriteLine("Room Number: " + highestGuest.RoomNumber);
                            Console.WriteLine("Total Revenue: OMR " + finalCost.ToString("F2"));
                        }
                        break;

                    case 15:

                        Console.WriteLine("--- Paginated Guest List ---");

                        if (guests.Count == 0)
                        {
                            Console.WriteLine("No guests in the system to display.");
                            break;
                        }

                        int pageSize = 3;
                         totalGuests = guests.Count;

                        
                        int totalPages = (totalGuests + pageSize - 1) / pageSize;

                        Console.Write("Enter page number (1 to " + totalPages + "): ");
                        int pageNumber = int.Parse(Console.ReadLine());

                        if (pageNumber < 1 || pageNumber > totalPages)
                        {
                            Console.WriteLine("That page does not exist.");
                            break;
                        }
                        List<Guest> pagedGuests = guests
                            .Skip((pageNumber - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
                        Console.WriteLine("--- Page " + pageNumber + " of " + totalPages + " ---");
                        foreach (Guest g in pagedGuests)
                        {
                            g.DisplayGuest();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting the system. Thank you for using Grand Vista Hotel Management!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 0 and 15.");
                        break;
                }
            }



        }
    }


}

