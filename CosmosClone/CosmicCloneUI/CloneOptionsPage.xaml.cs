﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CosmicCloneUI
{
    /// <summary>
    /// Interaction logic for CloneOptionsPage.xaml
    /// </summary>
    public partial class CloneOptionsPage : Page
    {
        public CloneOptionsPage()
        {
            InitializeComponent();
        }


        public bool TestCloneOptions()
        {
            var result = true;
            if (!int.TryParse(OfferThroughput.Text, out int RU))
                result = false;

            if (RU < 400) result = false;
            if (RU % 100 != 0) result = false;

            if (result)
            {
                var connectionIcon = (Image)this.FindName("ConnectionIcon");
                ConnectionIcon.Source = new BitmapImage(new Uri("/Images/success.png", UriKind.Relative));
                ConnectionTestMsg.Text = "Validation Passed";
            }
            else
            {
                var connectionIcon = (Image)this.FindName("ConnectionIcon");
                ConnectionIcon.Source = new BitmapImage(new Uri("/Images/fail.png", UriKind.Relative));
                ConnectionTestMsg.Text = "Invalid Throughput provided. Make sure it's a number greater than 400 and multiple of 100.";
            }

            return result;
        }
    }
}
