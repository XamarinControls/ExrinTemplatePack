using Exrin.Abstraction;
using Exrin.Framework;
using $saferootprojectname$.Framework.Abstraction.Model;
using $safeprojectname$.Base;
using $safeprojectname$.VisualState;

namespace $safeprojectname$.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAuthModel _model;

        public LoginViewModel(IAuthModel model, IExrinContainer exrinContainer) :
           base(exrinContainer, new LoginVisualState(model))
        {
            _model = model;
        }

        public IRelayCommand LoginCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new LoginOperation(_model));
                });
            }
        }

    }
}
