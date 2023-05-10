namespace PoruTelApp;

public partial class Comanda : ContentPage
{
	public int ContorKurtos = 0;
	public int ContorLimonada = 0;
	public int ContorInghetata = 0;
	public int ContorKurtosInghetata = 0;
	public Comanda()
	{
		InitializeComponent();
	}

	private void Kurtosplus_Clicked(object sender, EventArgs e)
	{
		ContorKurtos++;
		labelKurtos.Text="KURTOS : "+ContorKurtos.ToString();

	}

	private void Kurtosminus_Clicked(object sender, EventArgs e)
	{
		ContorKurtos--;
		labelKurtos.Text = "KURTOS : " + ContorKurtos.ToString();
	}

	private void Limoplus_Clicked(object sender, EventArgs e)
	{
		ContorLimonada++;
		labelLimonada.Text="Limnoanda: "+ContorLimonada.ToString();	
	}

	private void LimoMINUS_Clicked(object sender, EventArgs e)
	{
		ContorLimonada--;
		labelLimonada.Text = "Limnoanda: " + ContorLimonada.ToString();
	}

	private void Inghetataplus_Clicked(object sender, EventArgs e)
	{
		ContorInghetata++;
		LabelInghetata.Text="Inghetata : "+ContorInghetata.ToString();
	}

	private void InghetataMinus_Clicked(object sender, EventArgs e)
	{
		ContorInghetata--;
		LabelInghetata.Text = "Inghetata : " + ContorInghetata.ToString();
	}

	private void ResetCounter_Clicked(object sender, EventArgs e)
	{
		ContorInghetata = 0;
		ContorKurtos = 0;
		ContorLimonada = 0;
		ContorKurtosInghetata = 0;
		LabelInghetata.Text = "Inghetata : " + ContorInghetata.ToString();
		labelLimonada.Text = "Limnoanda: " + ContorLimonada.ToString();
		labelKurtos.Text = "KURTOS : " + ContorKurtos.ToString();
		KurtosInghetata.Text = "Kurtos cu Inghetata : " + ContorKurtosInghetata.ToString();
	}

	private void KurtosInghetataplus_Clicked(object sender, EventArgs e)
	{
		ContorKurtosInghetata++;
		KurtosInghetata.Text = "Kurtos cu Inghetata: " + ContorKurtosInghetata.ToString();

	}

	private void KurtosInghetataMinus_Clicked(object sender, EventArgs e)
	{
		ContorKurtosInghetata--;
		KurtosInghetata.Text = "Kurtos cu Inghetata: " + ContorKurtosInghetata.ToString();
	}
}