using Project.Views;

namespace Project
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
            Routing.RegisterRoute(nameof(CurrentContactPage), typeof(CurrentContactPage));
            Routing.RegisterRoute(nameof(NewContactPage), typeof(NewContactPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }
    }
}
