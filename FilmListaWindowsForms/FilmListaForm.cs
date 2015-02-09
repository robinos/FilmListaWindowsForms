using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace FilmListaWindowsForms
{
	/// <summary>
	/// FilmListaForm visar upp en av tre filmer beroende på vilken är vald från comboxen.
	/// Det alltid börjar på kungens återkomst.
	/// </summary>
	public partial class FilmListaForm : Form
	{
		private Dictionary<string, Film> filmer;

		/// <summary>
		/// Constructor för FilmListaForm
		/// </summary>
		public FilmListaForm()
		{
			filmer = new Dictionary<string, Film>();
			initialiseraFilmer();

			InitializeComponent();
			fyllFilmBox();
		}

		/// <summary>
		/// Lägger tre filmer i Dictionary filmer.
		/// </summary>
		private void initialiseraFilmer()
		{
			filmer.Add("Sagan om kungens återkomst", new Film(1, "Sagan om kungens återkomst", 2003, 201, "återkomst.jpg"));
			filmer.Add("The Dark Knight", new Film(2, "The Dark Knight", 2008, 152, "thedarkknight.jpg"));
			filmer.Add("Rymdimperiet slår tillbaka", new Film(3, "Rymdimperiet slår tillbaka", 1980, 124, "rymdimperiet.jpg"));
		}

		/// <summary>
		/// Fyll combobox FilmBox med filmer från Dictionary filmer och börjar visar upp den
		/// första.
		/// </summary>
		private void fyllFilmBox()
		{
			foreach (string title in filmer.Keys)
				FilmBox.Items.Add(title);

			FilmBox.SelectedIndex = 0;
		}

		/// <summary>
		/// När en ny index är vald, ändrar vilken filminformation som visas.
		/// </summary>
		/// <param name="sender">objekten som skickar (FilmBox)</param>
		/// <param name="e">argument för händelsen</param>
		private void FilmBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Items är en array av element i FilmBox
			string valdFilmNamn = FilmBox.Items[FilmBox.SelectedIndex].ToString();
			Film valdFilm = filmer[valdFilmNamn];

			Årtal.Text = valdFilm.UtgivningsÅr.ToString();
			Längd.Text = valdFilm.Längd.ToString();
			//FilmBild.Image = Image.FromFile(valdFilm.Bild);  //FilmBild har SizeMode: Autosize
			//FilmBild.ImageLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)+@"\"+valdFilm.Bild;
		}
	}
}
