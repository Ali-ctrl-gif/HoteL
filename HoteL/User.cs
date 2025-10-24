using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteL
{
    public class User
    {
        public List<Room> reservations;
        public string Name { get; set; }
        public int Id { get; set; }

        public User(string name,int id)
        {
            this.Name = name;
            this.Id = id;
            reservations = new List<Room>();
        }
        public void ShowReservations()
        {
            foreach (var item in reservations)
            {
                Console.WriteLine(item.RoomName);
            }

        }
    }
}
