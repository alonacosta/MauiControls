namespace MauiControls.Pages;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();
        // Define o binding context
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked; 
	}

    private async void BtnLogin_Clicked(object? sender, EventArgs e)
    {
        // Ativa ActivityIndicator
        this.IsBusy = true;

        //Code for Login
        await Task.Delay(8000);
        Application.Current.MainPage = new NavigationPage(new MainPage());

    }

    //private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string textOld = e.OldTextValue;
    //    string textNew = e.NewTextValue;
    //    string myText = entry1.Text;

    //    await DisplayAlert("Entry1 - TextChanged", $"{ textOld} - {textNew} - {myText}", "OK" );
    //}

    private async void entry1_Completed(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
        await DisplayAlert("Entry1 - Completed", text, "OK");
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await progressBar.ProgressTo(0.90, 2000, Easing.Linear);
    //}
}