using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteL
{
    public class HotelSystem
    {
        public List<Room> rooms;
        public string HotelName { get; set; }

        public HotelSystem()
        {
            rooms = new List<Room>();
        }
        public List<Room> EmptyRooms()
        {
            var empty = rooms.Where(r => r.IsAvailable).ToList();

            if (empty.Count == 0)
                Console.WriteLine("There are no empty rooms.");
            else
            {
                Console.WriteLine("Rooms Empty : ");
                foreach (var room in empty)
                    room.ShowInfo();
            }

            return empty;
        }

        public void RoomReserve(User user,Room room)
        {
            if (room.IsAvailable)
            {
                user.reservations.Add(room);
                room.IsAvailable = false;
                Console.WriteLine("reserve ba movaffaghiat anjam shod");
            }
            else
            {
                Console.WriteLine("room ghablan reserve shodeh ast");
            }
        }
        public void CancelReseve(User user, Room room)
        {
            user.reservations.Remove(room);
            room.IsAvailable=false;
        }
        public void ShowReserves(User user)
        {
            user.ShowReservations();
        }
    }
}
