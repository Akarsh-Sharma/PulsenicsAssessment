
namespace PulsenicsAssessment.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<FileEntity> AssignedFiles { get; set; } = new List<FileEntity>();
    }
}
