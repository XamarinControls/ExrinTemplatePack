using Exrin.Abstraction;

namespace $safeprojectname$.Base
{
    public class BaseModel : Exrin.Framework.Model
    {
        public BaseModel(IExrinContainer exrinContainer, IModelState modelState)
            : base(exrinContainer, modelState)
        {
        }
    }
}
