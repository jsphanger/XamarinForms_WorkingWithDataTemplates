using System;
using System.ComponentModel;
using WorkingwithDataTemplates.Views;
using Xamarin.Forms;

namespace WorkingwithDataTemplates
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnInline_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InlineDataTemplates());
        }

        async void btnModelType_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModelTypeDataTemplates());
        }

        async void btnBindableLayout_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BindableLayoutTemplates());
        }
    }
}
