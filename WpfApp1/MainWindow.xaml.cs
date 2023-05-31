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
		public MainWindow()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			loginpage lp = new loginpage();
			lp.Show();
			this.Close();
		}

		private void DodajKsiazke(object sender, RoutedEventArgs e)
		{

		}

		private void Ksiazki(object sender, RoutedEventArgs e)
		{
			KsiazkiWindow ks = new KsiazkiWindow();
			ks.Show();
			this.Close();
		}

		private void Autorzy(object sender, RoutedEventArgs e)
		{

		}

		private void Gatunki(object sender, RoutedEventArgs e)
		{

		}

		private void Wypozyczenia(object sender, RoutedEventArgs e)
		{

		}


	}
}
