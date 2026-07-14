namespace oop_part_2_task_7
{
    public class Room
    {

        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Parameterless Constructor
        public Room()
        {

        }

        // Parameterized Constructor
        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
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

        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        //Parameterless Constructor
        public Guest()
        {
        }

        //Parameterized Constructor
        public Guest(int guestId, string guestName, int roomNumber, string checkInDate, int totalNights)
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
            Console.WriteLine("Hello, World!");
        }
    }


}

