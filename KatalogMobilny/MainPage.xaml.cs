namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazClicked(object? sender, EventArgs e)
        {
            EtykietaWyniku.Text = "W";

            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Kliknięto {count} raz";
            //else
            //    CounterBtn.Text = $"Kliknięto {count} razy";
        }
    }
}
