namespace Examen_TercerProgreso;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.Detector_NH), typeof(Views.Detector_NH));
    }
}
