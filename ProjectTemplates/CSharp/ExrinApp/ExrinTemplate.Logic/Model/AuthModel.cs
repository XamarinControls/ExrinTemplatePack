using Exrin.Abstraction;
using $saferootprojectname$.Framework.Abstraction.Model;
using $safeprojectname$.Base;
using $safeprojectname$.ModelState;
using System.Threading.Tasks;

namespace $safeprojectname$.Model
{
    public class AuthModel : BaseModel, IAuthModel
    {
        public AuthModel(IExrinContainer exrinContainer)
            : base(exrinContainer, new AuthModelState()) { }

        public Task<bool> Login()
        {
            return Task.FromResult(true);
        }
    }
}
