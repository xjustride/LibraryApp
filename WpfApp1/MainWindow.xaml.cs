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
		}

		private void AddContactButton_Click(object sender, RoutedEventArgs e)
		{
			//string firstName = FirstNameTextBox.Text;
			//string lastName = LastNameTextBox.Text;
			//string phoneNumber = PhoneNumberTextBox.Text;

			//Contact newContact = new Contact(firstName, lastName, phoneNumber);
			//contacts.Add(newContact);
			//ContactsGrid.ItemsSource = null;
			//ContactsGrid.ItemsSource = contacts;
		}

		private void BrowseContactsButton_Click(object sender, RoutedEventArgs e)
		{
			//ContactsWindow contactsWindow = new ContactsWindow(contacts);
			//contactsWindow.ShowDialog();
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
