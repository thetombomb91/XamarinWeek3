using System;
using Xamarin.Forms;

namespace Week3Examples
{
    public partial class Week3ExamplesPage : ContentPage
    {
        public Week3ExamplesPage()
        {
            InitializeComponent();
        }

        public Week3ExamplesPage(string date)
        {
            InitializeComponent();
            TimePageAppearedLabel.Text = date;
        }

        void Handle_Appearing(object sender, System.EventArgs e)
        {
            TimePageAppearedLabel.Text = DateTime.Now.ToString("u");
        }

        async void Handle_NavigateToGridExample(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GridExample());
        }

		async void Handle_NavigateToFormattedTextExample(object sender, System.EventArgs e)
		{
            await Navigation.PushAsync(new FormattedTextExamplePage());
		}

        async void Handle_NavigateToDisplayUserTextPage(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DisplayUserTextPage(UserTextEntry.Text));
		}
    }
}
