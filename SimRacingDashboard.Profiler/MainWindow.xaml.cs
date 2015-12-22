﻿using SimRacingDashboard.DataAccess;
using SimRacingDashboard.Profiler.ViewModels;
using System.ComponentModel;
using System.Windows;

namespace SimRacingDashboard.Profiler
{
    public partial class MainWindow : Window
    {
        private ICarStateGateway gateway;
        
        public MainWindow()
        {
            InitializeComponent();

            this.gateway = new DataAccess.PCars.CarStateGateway();
            var viewModel = new MainViewModel();
            this.DataContext = viewModel;

            this.gateway.CarStateChanged += (sender, data) =>
            {
                Dispatcher.Invoke(() => viewModel.Add(data));
            };

            this.gateway.StartReading();
        }

        protected override void OnClosing(CancelEventArgs args)
        {
            this.gateway.Shutdown();
        }
    }
}
