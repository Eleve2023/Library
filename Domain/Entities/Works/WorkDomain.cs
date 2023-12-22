namespace Domain.Entities.Works
{
    public class WorkDomain
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Work> Works { get; set; } = Array.Empty<Work>();
    }

}
