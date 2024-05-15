namespace Layouts;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();

	}
    private void OnGoToAbsoluteLayoutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutPage());
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}