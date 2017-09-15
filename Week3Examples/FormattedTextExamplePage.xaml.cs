using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week3Examples
{
    public partial class FormattedTextExamplePage : ContentPage
    {
        public FormattedTextExamplePage()
        {
            InitializeComponent();
        }

        void Handle_Appearing(object sender, System.EventArgs e)
        {
			GlobalTextLabel.Text = Globals.XAMARIN_STRING;
        }

        void Handle_Disappearing(object sender, System.EventArgs e)
        {
            // Called when leaving page
        }
    }
}
