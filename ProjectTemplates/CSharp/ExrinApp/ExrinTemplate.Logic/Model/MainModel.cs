using Exrin.Abstraction;
using $saferootprojectname$.Framework.Abstraction.Model;
using $safeprojectname$.Base;
using $safeprojectname$.ModelState;

namespace $safeprojectname$.Model
{
    public class MainModel : BaseModel, IMainModel
    {
        public MainModel(IExrinContainer exrinContainer)
            : base(exrinContainer, new MainModelState()) { }
    }
}
