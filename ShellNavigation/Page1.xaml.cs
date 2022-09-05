namespace ShellNavigation;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	public void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"{nameof(Page2)}");
	}
}