using AutoMapper;
using T_grow.Models;
using T_grow.Models.Dto;

namespace T_grow.Helper
{
	public class MappingProfile:Profile
	{
        public MappingProfile()
        {
            CreateMap<CreateTreatmentDto, TreatMentModel>().ForMember(src => src.Img, option => option.Ignore());
        }
    }
}
