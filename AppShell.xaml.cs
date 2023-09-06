using AxitHome.Views.Pages;
using AxitHome.Views.Pages.ProfilePages;
using AxitHome.Views.Pages.Reservaciones;
using AxitHome.Views.Pages.StaffRecord;
namespace AxitHome;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
	}

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("CreateAccountPage", typeof(CreateAccountPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(CreateAccountPage), typeof(CreateAccountPage));
        Routing.RegisterRoute(nameof(ReservacionesListPage), typeof(ReservacionesListPage));
        Routing.RegisterRoute(nameof(ReservacionPage), typeof(ReservacionPage));
        Routing.RegisterRoute(nameof(StaffRecordPage), typeof(StaffRecordPage));
        Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        Routing.RegisterRoute(nameof(StaffRecordEditPage), typeof(StaffRecordEditPage));
    }
}