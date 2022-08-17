namespace BreakFast.API.Model
{
    public class BreakFastModel
    {
        public BreakFastModel(Guid id, string? name, string description, DateTime startDate, DateTime endDate, List<string>? savory, List<string>? sweet)
        {
            this.id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Savory = savory;
            Sweet = sweet;
        }

        public Guid id { get; }
        public string? Name { get; } = null;
        public string Description { get;  } = null!;
        public DateTime StartDate { get; } = DateTime.Now;
        public DateTime EndDate { get; } = DateTime.Now;
        public List<string>? Savory { get; }
        public List<string>? Sweet { get; }

    }
}
