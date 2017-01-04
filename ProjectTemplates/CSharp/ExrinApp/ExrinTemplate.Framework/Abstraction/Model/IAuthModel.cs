using Exrin.Abstraction;
using System.Threading.Tasks;

namespace $safeprojectname$.Abstraction.Model
{
    public interface IAuthModel : IBaseModel
    {
        Task<bool> Login();
    }
}
