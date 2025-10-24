using HoteL;

HotelSystem Hotel = new HotelSystem() { HotelName = "MooN"};

Room Room1 = new Room("A1",101,2,20.000M,true);
Room Room2 = new Room("B2",202,4,40.000M,true);
Room Room3 = new Room("C3",303,1,5.000M,true);

User U1 =  new User("Ali",590);
User U2 =  new User("Amir",008);
User U3 =  new User("Aman",007);

Room2.Reserve();

Hotel.rooms.AddRange(new[] { Room1, Room2, Room3 });

//Hotel.RoomReserve(U1, Room2);
//Hotel.RoomReserve(U1, Room1);
//Hotel.RoomReserve(U3, Room2);

//U1.ShowReservations();

//Hotel.CancelReseve(U1, Room2);
//Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,");
//U1.ShowReservations();

Hotel.EmptyRooms();

//foreach (var room in Hotel.EmptyRooms())
//    room.ShowInfo();