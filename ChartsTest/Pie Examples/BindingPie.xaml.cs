﻿using System.Collections.ObjectModel;
using System.Windows;

namespace ChartsTest.Pie_Examples
{
    /// <summary>
    /// Interaction logic for BindingBar.xaml
    /// </summary>
    public partial class BindingPie
    {
        public BindingPie()
        {
            InitializeComponent();
            Serie1.DataContext = new ObservableCollection<double> { 2, 3, 5, 7 };
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //this is just to see animation everytime you click next
            Chart.ClearAndPlot();
        }
    }
}
