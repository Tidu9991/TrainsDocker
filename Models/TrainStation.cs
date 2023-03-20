namespace Trains.Models
{
    public class TrainStation
    {
        public int Train_Id { get; set; }
        public string Train_Name { get; set; }
        public string Station_Id { get; set; }
        public string Station_Name { get; set; }
        public TimeSpan Arrival_Time { get; set; }
        public TimeSpan Departure_Time { get; set; }
        public string Running_Days { get; set; }
        public string Moving_Towards { get; set; }


    }
}
