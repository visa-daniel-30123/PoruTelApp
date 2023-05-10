using System.Diagnostics;

namespace PoruTelApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private void ShellContent_Disappearing(object sender, EventArgs e)
    {
        Debug.WriteLine("Se dispare pagina");
    }
}
