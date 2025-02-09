﻿using Hotel_Reservation_Manager.Data.Models;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    public class RoomEditViewModel
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }
    }
}
