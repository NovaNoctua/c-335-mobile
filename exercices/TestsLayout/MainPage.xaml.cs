namespace TestsLayout
{
    public partial class MainPage : ContentPage
    {
        bool clicked = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!clicked)
            {
                button.Text = "Cliqué !";

                btnClickMe.BackgroundColor = Colors.Green;

                clicked = true;
            } else
            {
                button.Text = "Cliquez-moi !";

                btnClickMe.BackgroundColor = Colors.Purple;

                clicked = false;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

            if (newText.Length >= 3)
            {
                txtName.BackgroundColor = Colors.LightGreen;
            } else
            {
                txtName.BackgroundColor = Colors.LightPink;
            }
        }

        private void OnTextCompleted(object sender, EventArgs e)
        {
            Entry entry = (Entry)sender;
            DisplayAlert("Info", $"Text saisi : {entry.Text}", "OK");
        }

        private void OnCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            bool isChecked = e.Value;

            if (isChecked)
            {
                DisplayAlert("Confirmé", "Conditions acceptées", "OK");
            }
        }
    }
}
