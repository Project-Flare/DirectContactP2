using Project.Views.ViewModel;

namespace Project.Views;

public partial class NewContactPage : ContentPage
{
	public NewContactPage(MainViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
        // asdasd
    }
}