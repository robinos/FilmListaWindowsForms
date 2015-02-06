using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmListaWindowsForms
{
	/// <summary>
	/// FilmListaProgram är en program för att visa information om 3 olika filmer
	/// med hjälp av en combobox.
	/// </summary>
	static class FilmListaProgram
	{
		/// <summary>
		/// Main metoden startar FilmListaForm.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FilmListaForm());
		}
	}
}
