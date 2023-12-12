namespace RecGestion;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
    }

    private void btn_access_clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Pulsado", "Usuario: " + user.Text + " - Password: " + password.Text, "Salir");
        //await Shell.Current.GoToAsync("principal");
        App.Current.MainPage = new NavigationPage(new Principal());
    }

}

