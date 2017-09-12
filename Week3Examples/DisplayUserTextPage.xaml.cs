using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week3Examples
{
    public partial class DisplayUserTextPage : ContentPage
    {
        public DisplayUserTextPage()
        {
            InitializeComponent();
        }

        public DisplayUserTextPage(string userText)
        {
            InitializeComponent();

            if (userText == null || userText == string.Empty)
            {
                DisplayUserTextLabel.Text = "User did not enter anything 8(";
            }
            else
            {
                DisplayUserTextLabel.Text = userText;
            }
		}

        void Handle_GoBackClicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
