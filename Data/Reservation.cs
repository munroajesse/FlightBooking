using System;

namespace Assignment3.Data
{
    public class Reservation
    {
        public string ReservationCode { get; set; }
        public Flight SelectedFlight { get; set; }
        public string FullName { get; set; }
        public string Citizenship { get; set; }
        public string Status { get; set; }


        public Reservation(string reservationCode, Flight selectedFlight, string fullName, string citizenship, string status)
        {
            ReservationCode = reservationCode;
            SelectedFlight = selectedFlight;
            FullName = fullName;
            Citizenship = citizenship;
            Status = status;
        }
    }
}
