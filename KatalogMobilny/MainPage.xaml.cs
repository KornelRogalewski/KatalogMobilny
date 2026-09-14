namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Kliknięto {count} raz";
            else
                CounterBtn.Text = $"Kliknięto {count} razy";
        }
    }
}
