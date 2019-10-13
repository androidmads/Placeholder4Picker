using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace PickerPlaceholder
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<string> items = new List<string>();
            items.Add("Item 1");
            items.Add("Item 2");
            picker.ItemsSource = items;
            plpicker.ItemsSource = items;
        }

private void PLPIndex1Clicked(object sender, EventArgs e)
{
    plpicker.SelectedIndex = 1;
}

private void PLPIndex2Clicked(object sender, EventArgs e)
{
    plpicker.SelectedIndex = -1;
}

        private void Index1Clicked(object sender, EventArgs e)
        {
            picker.SelectedIndex = 1;
        }

        private void Index2Clicked(object sender, EventArgs e)
        {
            picker.SelectedIndex = -1;
        }
    }
}
