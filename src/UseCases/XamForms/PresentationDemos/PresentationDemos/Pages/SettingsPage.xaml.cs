﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationDemos.ViewModels;
using ReactiveUI;
using Xamarin.Forms;

namespace PresentationDemos.Pages
{
    public partial class SettingsPage : ContentPage, IViewFor<SettingsViewModel>
    {
        public SettingsPage()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                
            });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (SettingsViewModel)value; }
        }

        public SettingsViewModel ViewModel { get; set; }
    }
}
