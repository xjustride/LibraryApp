using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace WpfApp1
{
	public partial class MainWindow : Window
	{
		private List<Contact> contacts;

		public MainWindow()
		{
			InitializeComponent();
			contacts = new List<Contact>();
		}
		private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			var textBox = (TextBox)sender;
			var text = textBox.Text + e.Text;
			if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z ]{1,50}$"))
			{
				e.Handled = true;
			}
		}


		private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			var textBox = (TextBox)sender;
			var text = textBox.Text + e.Text;
			if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]{1,20}$"))
			{
				e.Handled = true;
			}
		}

		private void EmailTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			var textBox = (TextBox)sender;
			var text = textBox.Text + e.Text;
			if (text.Length > 30)
			{
				e.Handled = true;
				return;
			}
		}
		private void AddContactButton_Click(object sender, RoutedEventArgs e)
		{
			// Pobierz dane wprowadzone do TextBox'a
			string imie = FirstNameTextBox.Text;
			string numerTelefonu = PhoneNumberTextBox.Text;
			string adresEmail = EmailTextBox.Text;
			string nazwisko = SecondNameTextBox.Text;

			// Utwórz połączenie z bazą danych
			string connectionString = "Server=MSI;Database=PhoneBook;Trusted_Connection=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Dodaj dane do tabeli Imiona
					string insertImionaQuery = "INSERT INTO imiona (imie) VALUES (@imie)";
					using (SqlCommand command = new SqlCommand(insertImionaQuery, connection))
					{
						command.Parameters.AddWithValue("@imie", imie);
						command.ExecuteNonQuery();
					}

					// Dodaj dane do tabeli Nazwiska
					string insertNazwiskaQuery = "INSERT INTO nazwiska (nazwisko) VALUES (@nazwisko)";
					using (SqlCommand command = new SqlCommand(insertNazwiskaQuery, connection))
					{
						command.Parameters.AddWithValue("@nazwisko", nazwisko);
						command.ExecuteNonQuery();
					}

					// Dodaj dane do tabeli Telefony
					string insertTelefonyQuery = "INSERT INTO nrtelefonow (nrtelefonu) VALUES (@nrtelefonu)";
					using (SqlCommand command = new SqlCommand(insertTelefonyQuery, connection))
					{
						command.Parameters.AddWithValue("@nrtelefonu", numerTelefonu);
						command.ExecuteNonQuery();
					}

					// Dodaj dane do tabeli Emaile
					string insertEmaileQuery = "INSERT INTO emaile (email) VALUES (@email)";
					using (SqlCommand command = new SqlCommand(insertEmaileQuery, connection))
					{
						command.Parameters.AddWithValue("@email", adresEmail);
						command.ExecuteNonQuery();
					}

					MessageBox.Show("Kontakt został dodany do bazy danych.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Wystąpił błąd podczas dodawania kontaktu: " + ex.Message);
				}
			}
		}

		private void BrowseContactsButton_Click(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1();
			window1.Show();
			this.Close();
		}

		


		private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			var textBox = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(textBox.Text))
			{
				textBox.Tag = "placeholder";
			}
			else
			{
				textBox.Tag = null;
			}
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}

	public class Contact
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public Contact(string firstName, string lastName, string phoneNumber)
		{
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
		}
	}
}
