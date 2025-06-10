namespace BranchPortal.Model
{
    public class Branch
    {
        public Guid Id { get; set; } 
        public string?Name { get; set; }
        public string?Location { get; set; }
        public string ?ManagerName { get; set; }
    }
}
