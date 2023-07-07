using System;
using System.Collections.Generic;
using System.IO;
using Assignment3.Pages;

namespace Assignment3.Data
{
    public class Flight
    {
        public string FlightId { get; set; }
        public string AirlineName { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public int Passengers { get; set; }
        public decimal Cost { get; set; }


        public Flight(string flightId, string airlineName, string departureAirport, string arrivalAirport, string day, string time, int passengers, decimal cost)
        {
            FlightId = flightId;
            AirlineName = airlineName;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            Day = day;
            Time = time;
            Passengers = passengers;
            Cost = cost;
      
        }
    }
}
