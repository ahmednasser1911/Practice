using BreakFast.API.Model;

namespace BreakFast.API.Services
{
    public class BreakFastService : IBreakFastService
    {
        private static Dictionary<Guid, BreakFastModel> breakFasts = new();
        public void CreateBreakFast(BreakFastModel request)
        {
            breakFasts.Add(request.id , request);
        }

        public BreakFastModel GetBreakFast(Guid id)
        {
            return breakFasts[id];
        }

        public List<BreakFastModel> GetBreakFastList()
        {
            return breakFasts.Values.ToList();
        }

        public void RemoveBreakFast(Guid id)
        {
            breakFasts.Remove(id);
        }

        public void UpsertBreakFast(BreakFastModel request)
        {
            breakFasts[request.id] = request;
        }
    }
}
