using Exrin.Abstraction;

namespace $safeprojectname$.VisualState
{
    public class LoginVisualState : Exrin.Framework.VisualState
    {
        public LoginVisualState(IBaseModel model) : base(model)
        {
        }

        public string Username
        {
            get
            {
                return Get<string>();
            }
            set
            {
                Set(value);
            }
        }

    }
}

