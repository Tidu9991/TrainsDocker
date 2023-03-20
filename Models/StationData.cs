using System;

namespace Trains.Models
{
    public class StationData
    {
        public string Station_Id { get; set; }
        public string Station_Name { get; set; }
        public int Train_Id { get; set; }
        public TimeSpan Arrival_Time { get; set; }
        public TimeSpan Departure_Time { get; set; }

    }
}
