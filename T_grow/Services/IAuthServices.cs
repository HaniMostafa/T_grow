using System.Threading.Tasks;
using T_grow.Models;

namespace T_grow.Services
{
    public interface IAuthServices
    {
       Task<AuthModel> RgisterAsync(RegisterModel model);
       Task<AuthModel> GetTokenAsync(TokingRequstModel model);
    }
}
