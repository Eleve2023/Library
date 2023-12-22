namespace Application.Dtos.Ouvrages
{
    public class WorkDomainDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<WorkDto> Works { get; set; } = Array.Empty<WorkDto>();
    }

}
