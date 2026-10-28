namespace Cachirula
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        // Construptor
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Me picaste {count} vez";
            else
                CounterBtn.Text = $"Me picaste {count} veces, que rico!";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
