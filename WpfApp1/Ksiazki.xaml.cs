using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
	public partial class KsiazkiWindow : Window
	{
		public KsiazkiWindow()
		{
			InitializeComponent();

			LoadKsiazkiFromDatabase();
		}

		private void LoadKsiazkiFromDatabase()
		{
			using (var context = new LibraryEntities1())
			{
				List<Ksiazki> ksiazki = context.Ksiazki.ToList();
				KsiazkiDataGrid.ItemsSource = ksiazki;
			}
		}
	}

	public class Ksiazka
	{
		public int Id { get; set; }
		public string Tytul { get; set; }
		public string Autor { get; set; }
		public int RokWydania { get; set; }
		public string Gatunek { get; set; }
		public string StatusWypozyczenia { get; set; }
	}
}
