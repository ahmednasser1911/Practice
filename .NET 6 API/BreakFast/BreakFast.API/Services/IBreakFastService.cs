using BreakFast.API.Model;

namespace BreakFast.API.Services
{
    public interface IBreakFastService
    {
        void CreateBreakFast(BreakFastModel request);
        BreakFastModel GetBreakFast(Guid id);
        List<BreakFastModel> GetBreakFastList();
        void RemoveBreakFast(Guid id);
        void UpsertBreakFast(BreakFastModel request);

    }
}
