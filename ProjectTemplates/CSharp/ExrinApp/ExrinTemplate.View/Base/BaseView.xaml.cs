﻿using Exrin.Abstraction;
using System;
using Xamarin.Forms;

namespace $safeprojectname$.Base
{
    public partial class BaseView : ContentPage, IView
    {
        public BaseView()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return ((IView)this).OnBackButtonPressed();
        }

        Func<bool> IView.OnBackButtonPressed { get; set; }
    }
}
