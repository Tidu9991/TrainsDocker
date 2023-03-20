using Trains.Models;

namespace Trains.Repository
{
    public interface ITrainRepository
    {
        public List<TrainStation> GetAllTrains();
        public List<TrainStation> FindAllTrains(Input input);

    }
}
