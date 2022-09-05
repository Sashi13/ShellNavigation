using Android.Media;

namespace ShellNavigation;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
	}

    void RegisterRoutes()
    {
        Routes.Add(nameof(Page1), typeof(Page1));
        Routes.Add(nameof(Page2), typeof(Page2));
        Routes.Add(nameof(Page3), typeof(Page3));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }
}
