using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
	public partial class MainWindow : Window
	{
		private List<Contact> contacts;

		public MainWindow()
		{
			InitializeComponent();
			contacts = new List<Contact>();
			InitializeContacts();
			ContactsGrid.ItemsSource = contacts;
		}

		private void InitializeContacts()
		{
			// Przykładowe dane kontaktów
			contacts.Add(new Contact { FirstName = "Jan", LastName = "Kowalski", PhoneNumber = "123456789", Email = "jan.kowalski@example.com" });
			contacts.Add(new Contact { FirstName = "Anna", LastName = "Nowak", PhoneNumber = "987654321", Email = "anna.nowak@example.com" });
			// Dodaj więcej kontaktów lub pobierz z bazy danych
		}

		private void AddContactButton_Click(object sender, RoutedEventArgs e)
		{
			// Logika dodawania nowego kontaktu
			// Możesz otworzyć nowe okno dialogowe lub formularz do wprowadzania danych
			// Po dodaniu kontaktu, zaktualizuj listę kontaktów i odśwież widok DataGrid
		}

		private void EditContactButton_Click(object sender, RoutedEventArgs e)
		{
			// Logika edycji istniejącego kontaktu
			// Możesz otworzyć okno dialogowe lub formularz z wybranymi danymi kontaktu do edycji
			// Po zapisaniu zmian, zaktualizuj listę kontaktów i odśwież widok DataGrid
		}

		private void DeleteContactButton_Click(object sender, RoutedEventArgs e)
		{
			// Logika usuwania kontaktu
			// Pobierz zaznaczony kontakt z DataGrid i usuń go z listy kontaktów
			// Po usunięciu, odśwież widok DataGrid
		}
	}

	public class Contact
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}
}
