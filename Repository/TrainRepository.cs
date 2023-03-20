using Dapper;
using NuGet.Versioning;
using System.Data;
using System.Data.SqlClient;
using Trains.Models;

namespace Trains.Repository
{
    public class TrainRepository : ITrainRepository
    {
        private IDbConnection db;
        

        public TrainRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public List<TrainStation> FindAllTrains(Input input)
        {
            var sql = "select TrainData.Train_Id,Station_Id,Station_Name,Arrival_Time,Departure_Time,Running_Days,Train_Name,Moving_Towards from StationData join TrainData on StationData.Train_Id = TrainData.Train_Id join TrainMovement on TrainData.Train_Id = TrainMovement.Train_Id join TrainRunningDays on TrainMovement.Train_Id = TrainRunningDays.Train_Id where Station_Id = @station_id and Arrival_Time > @Arrival_Time and Running_Days = 'Daily' or Running_Days = @Running_Days ";
           
            var trains = db.Query<TrainStation>(sql,
                new
                {
                    @Station_Id = input.Station_Id,
                    @Arrival_Time = input.Time,
                    @Running_Days = input.Day
                });
            return trains.ToList();
            
        }

        public List<TrainStation> GetAllTrains()
        {
            var sql = "select TrainData.Train_Id,Station_Id,Station_Name,Arrival_Time,Departure_Time,Running_Days,Train_Name,Moving_Towards from StationData join TrainData on StationData.Train_Id = TrainData.Train_Id join TrainMovement on TrainData.Train_Id = TrainMovement.Train_Id join TrainRunningDays on TrainMovement.Train_Id = TrainRunningDays.Train_Id" ;
            return (db.Query<TrainStation>(sql)).ToList();
            
        }
    }
}
