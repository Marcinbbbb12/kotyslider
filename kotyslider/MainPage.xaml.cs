namespace kotyslider
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            UpdateSizeLabel(sizeSlider.Value);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;

            imageToResize.WidthRequest = 200 * value;
            imageToResize.HeightRequest = 200 * value;

            UpdateSizeLabel(value);
        }

        private void UpdateSizeLabel(double value)
        {
            sizeLabel.Text = $"Rozmiar: {value:F2}";
        }

        private void ResetSlider()
        {
            sizeSlider.Value = 0.5; 
            UpdateSizeLabel(sizeSlider.Value); 
        }


        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            ResetSlider();
        }
    }
}