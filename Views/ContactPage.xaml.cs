namespace Project.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}

    private void btnEditContact_Clicked(object sender, EventArgs e)
    {

    }

    private void btnAddContact_Clicked(object sender, EventArgs e)
    {
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {

    }
    private void Button2_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(CurrentContactPage));
    }
    private void Button3_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(NewContactPage));
    }
    private void Button4_Clicked(object sender, EventArgs e)
    {

    }
}