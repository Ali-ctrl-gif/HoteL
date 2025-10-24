using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteL
{
    public class Room:IBookable
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public decimal Price {  get; set; }
        public bool IsAvailable { get; set; }

        public Room(string roomName, int roomId, int capacity, decimal price, bool IsAvailable)
        {
            RoomName = roomName;
            this.RoomName = roomName;
            this.Capacity = capacity;
            this.Price = price;
            this.IsAvailable = IsAvailable;
        }

        public void Reserve()
        {
            IsAvailable = false;}
        public void Cancel() { IsAvailable = true; }
        public void ShowEmptyRooms() { }

        public void ShowInfo()
        {
            Console.WriteLine($"RoomInformation : RoomName : {RoomName} |   Capacity : {Capacity} |  Price : {Price} |  IsAvailable : {IsAvailable}");
        }
    }
}
