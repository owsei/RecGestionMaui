namespace RecGestion;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("principal", typeof(MainPage));
        Routing.RegisterRoute("configuracionApp", typeof(ConfiguracionApp));
    }

    private void btn_configuracion(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ConfiguracionApp());
    }
}

