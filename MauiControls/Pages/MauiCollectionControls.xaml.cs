using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new PhotoViewModel();
	}

    private void BeltAlert_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Seat belt alert", "You select/unselect this task", "Ok");
    }

    //  private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //  {
    //if(e.CurrentItem != null && e.PreviousItem != null)
    //{
    //          Photo previous = e.PreviousItem as Photo;
    //          Photo current = e.CurrentItem as Photo;
    //	await DisplayAlert("CarouselView", $"Previous={previous.Name} \n\ncurrent={current.Name}", "Ok");
    //      }

    //  }
}