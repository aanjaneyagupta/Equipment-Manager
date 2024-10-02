using EquipmentManager_Assignment1.Models;
namespace EquipmentManager_Assignment1.Repositories
{
    public class RequestRepository
    {
        private static List<Request> requests = new List<Request>();
        private static int id = 1;

        public void AddRequest(Request request)
        {
            request.Id = id++;
            requests.Add(request);
        }

        public List<Request> GetAllRequests()
        {
            return requests;
        }
    }
}
