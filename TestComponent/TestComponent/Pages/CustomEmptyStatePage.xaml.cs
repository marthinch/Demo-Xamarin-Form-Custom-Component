﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestComponent.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestComponent.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEmptyStatePage : ContentPage
    {
        public CustomEmptyStatePage()
        {
            InitializeComponent();

            BindingContext = new EmptyStateViewModel();
        }
    }
}