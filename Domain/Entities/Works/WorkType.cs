namespace Domain.Entities.Works
{
    public class WorkType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Work> Works { get; set; } = Array.Empty<Work>();
    }

}
