

namespace kotyslider
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;


            kot.WidthRequest = 200 * value;
            kot.HeightRequest = 200 * value;
        }


        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/says/hello?fontSize=50&fontColor=red";

            kot.Source = link;
        }


    }
}
