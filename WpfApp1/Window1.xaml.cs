using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Logika interakcji dla klasy Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		private void MainMenu_Click(object sender, RoutedEventArgs e)
		{
			MainWindow window = new MainWindow();
			window.Show();
			this.Close();
		}
		private void BrowseContactsButton_Click(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1();
			window1.Show();
			this.Close();
			string connectionString = "Server=MSI;Database=PhoneBook;Trusted_Connection=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Pobierz dane z tabeli PhoneBook
					string selectQuery = "SELECT imie, numer_telefonu, adres_email FROM PhoneBook ORDER BY imie";
					using (SqlCommand command = new SqlCommand(selectQuery, connection))
					{
						using (SqlDataReader reader = command.ExecuteReader())
						{
							// Utwórz listę dla przechowywania danych kontaktowych
							List<string> contacts = new List<string>();

							// Odczytaj dane kontaktowe i dodaj je do listy
							while (reader.Read())
							{
								string imie = reader.GetString(0);
								string numerTelefonu = reader.GetString(1);
								string adresEmail = reader.GetString(2);
								string contactInfo = $"Imię: {imie}, Numer telefonu: {numerTelefonu}, Adres email: {adresEmail}";
								contacts.Add(contactInfo);
							}

							// Wyświetl dane w kontrolce ListBox
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
				}
			}

		}
	}
}
