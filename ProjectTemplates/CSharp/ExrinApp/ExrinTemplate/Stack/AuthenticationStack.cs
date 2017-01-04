using Exrin.Abstraction;
using Exrin.Framework;
using $safeprojectname$.Logic.ViewModel;
using $safeprojectname$.Proxy;
using $safeprojectname$.View;
using Xamarin.Forms;

namespace $safeprojectname$.Logic.Stack
{
    using Framework.Locator;
    using Framework.Locator.Views;

    public class AuthenticationStack : BaseStack
    {
        public AuthenticationStack(IViewService viewService)
            : base(new NavigationProxy(new NavigationPage()), viewService, Stacks.Authentication)
        {
            ShowNavigationBar = false;
        }
        protected override void Map()
        {
            base.NavigationMap<LoginView, LoginViewModel>(nameof(Authentication.Login));
        }

        public override string NavigationStartKey
        {
            get
            {
                return nameof(Authentication.Login);
            }
        }
    }
}
