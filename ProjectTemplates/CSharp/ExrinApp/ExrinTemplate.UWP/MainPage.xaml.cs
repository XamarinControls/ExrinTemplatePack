﻿namespace $safeprojectname$
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new ExrinMobileApp.App(new Bootstrapper()));
        }
    }
}
