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

                    
                        Console.WriteLine("--- Room Search---");
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
                                .Where(r => r.RoomType.Equals(searchType, StringComparison.OrdinalIgnoreCase))
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

                            Console.WriteLine();
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
                                int totalRoomsCount = rooms.Count();
                                int availableRoomsCount = rooms.Count(r => r.IsAvailable);
                                double avgPrice = rooms.Average(r => r.PricePerNight);
                                double minPrice = rooms.Min(r => r.PricePerNight);
                                double maxPriceInSystem = rooms.Max(r => r.PricePerNight);

                                Console.WriteLine("Total Rooms: " + totalRoomsCount);
                                Console.WriteLine("Available Rooms: " + availableRoomsCount);
                                Console.WriteLine("Average Price: $" + avgPrice);
                                Console.WriteLine("Cheapest Price: $" + minPrice);
                                Console.WriteLine("Most Expensive Price: $" + maxPriceInSystem);
                            }
                        }
                        break;

                    case 7:
                        // TODO: Guest & Booking Statistics
                        break;

                    case 8:
                        // TODO: Update Room Price
                        break;

                    case 9:
                        // TODO: Guest Lookup by Name
                        break;

                    case 10:
                        // TODO: Room Type Breakdown Report
                        break;

                    case 11:
                        // TODO: Check Out a Guest
                        break;

                    case 12:
                        // TODO: Remove Unavailable Rooms
                        break;

                    case 13:
                        // TODO: Extend Guest Stay
                        break;

                    case 14:
                        // TODO: Highest Revenue Booking
                        break;

                    case 15:
                        // TODO: Guest Pagination Viewer
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

