using System.Diagnostics;

namespace PoruTelApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	public List<Produs> produse = MenuSingleton.Meniu.produse;

	public MainPage()
	{
		InitializeComponent();
	
        MenuSingleton.Meniu.loadFromJson();
        MenuSingleton.Meniu.AfiseazaProdouse(); 

        MenuSingleton.Meniu.produse.Sort((p, q) => p.id.Value.CompareTo(q.id.Value));
		
		produseMeniu.ItemsSource=MenuSingleton.Meniu.produse;
       // dataGridView1.DataSource = MenuSingleton.Meniu.produse;
    
    }
	private async void adaugaProdus(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Comanda");
		
	}


}

