﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NbfcClient.UserControls
{
    /// <summary>
    /// Interaction logic for FanController.xaml
    /// </summary>
    public partial class FanController : UserControl
    {
        public FanController()
        {
            InitializeComponent();
        }

        private void FanSpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
