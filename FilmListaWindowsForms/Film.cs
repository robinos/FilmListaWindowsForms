using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmListaWindowsForms
{
	/// <summary>
	/// Film är en behållare för filminformation.
	/// </summary>
	public class Film
	{
		private int filmID;
		private string filmNamn;
		private int utgivningsÅr;
		private int längd;
		private string bild;

		public int FilmID { get { return filmID; } set { filmID = value;  } }
		public string FilmNamn { get { return filmNamn; } set { filmNamn = value; } }
		public int UtgivningsÅr { get { return utgivningsÅr; } set { utgivningsÅr = value; } }
		public int Längd { get { return längd; } set { längd = value; } }
		public string Bild { get { return bild; } set { bild = value;  } }

		/// <summary>
		/// Constructor för Film för att göra det snabbare att skapa nya.
		/// </summary>
		/// <param name="id">film id</param>
		/// <param name="namn">film namn</param>
		/// <param name="year">året filmen kom ut</param>
		/// <param name="längd">längd på filmen</param>
		/// <param name="bild">bild associerat med filmen</param>
		public Film(int id, string namn, int year, int längd, string bild)
		{
			filmID = id;
			filmNamn = namn;
			utgivningsÅr = year;
			this.längd = längd;
			this.bild = bild;
		}
	}
}
