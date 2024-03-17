using Project.Views.ViewModel;

namespace Project.Views;

public partial class CurrentContactPage : ContentPage
{
	public CurrentContactPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		
	}
}