namespace RecGestion;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btn_configuracion(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ConfiguracionApp());
    }
}