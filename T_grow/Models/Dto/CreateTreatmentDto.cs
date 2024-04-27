using Microsoft.AspNetCore.Http;

namespace T_grow.Models.Dto
{
    public class CreateTreatmentDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile? Img { get; set; }

    }
}
