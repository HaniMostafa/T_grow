using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using T_grow.Data;
using T_grow.Models;
using T_grow.Models.Dto;
using T_grow.Services;

namespace T_grow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatment _treat;
        private readonly IMapper _Maper;

        public TreatmentController( IMapper maper, ITreatment treat)
        {
            _Maper = maper;
            _treat = treat;
        }
        private List<string> AllowExtention = new List<string> { ".jpg", ".png",".gif",".svg","jpeg"};

        [HttpPost]
        public async Task<IActionResult> CreateTreatment([FromForm] CreateTreatmentDto dto)
        {

            if (dto.Img == null)
                return BadRequest(error: "Poster is Required");

            if (!AllowExtention.Contains(Path.GetExtension(dto.Img.FileName).ToLower()))
                return BadRequest(error: "only .jpg and png are allowed!");



            using var dataStream = new MemoryStream();
            await dto.Img.CopyToAsync(dataStream);

            var Treat = _Maper.Map<TreatMentModel>(dto);
            Treat.Img = dataStream.ToArray();

         await _treat.Add(Treat);
            return Ok(Treat);





        }
        [HttpGet]
        public async Task<IActionResult> GetALLAsync()
        {
            var Treat = await _treat.GetAll();

            return Ok(Treat);
        }


    }
}
