using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace XFRgPopupsSample
{
    public partial class MyPopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopupPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopPopupAsync();
        }

        void PopupPage_BackgroundClicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Stop!", "Did you subscribe yet?", "OK!");
        }
    }
}
