using System.ComponentModel.DataAnnotations;

namespace T_grow.Models
{
    public class TreatMentModel
    {
        [Key]
        public int Id { get; set; }
        public string ? Title { get; set; }
        public string? Description { get; set; }
        public byte[] ?Img { get; set; }
    }
}
