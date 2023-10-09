namespace MAUIApp3;

public partial class MainPage : ContentPage
{
    string phoneNumHolder = "";
    bool isNumeric;

	public MainPage()
	{
		InitializeComponent();
	}

	public async void OnDial(object sender, EventArgs e)
	{
        phoneNumHolder = PhoneNum.Text;
        isNumeric = long.TryParse(phoneNumHolder, out _);


        if (isNumeric == false)
		{
            await DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");

        } else
        {
            try
            {
                PhoneDialer.Default.Open(phoneNumHolder);
            }
            catch (Exception ex)
            {
                await DisplayAlert(ex.Message, "Please enter a valid phone number", "OK");
            }
        }
	}
}


