namespace Layouts;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
    {
        InitializeComponent();
	}
    private async void GoToFlexLayout_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }
}