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

    public class MainStack : BaseStack
    {

        public MainStack(IViewService viewService)
            : base(new NavigationProxy(new NavigationPage()), viewService, Stacks.Main)
        {
            ShowNavigationBar = false;
        }

        protected override void Map()
        {
            base.NavigationMap<MainView, MainViewModel>(nameof(Main.Main));
        }

        public override string NavigationStartKey
        {
            get
            {
                return nameof(Main.Main);
            }
        }

    }
}
