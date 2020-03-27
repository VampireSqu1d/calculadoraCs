using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow(){
			InitializeComponent();
		}

		public void TextBoxPasting(object sendder, RoutedEventArgs eventArgs){



		}

		private void ValidacionInput(object sender, TextCompositionEventArgs e){
			Regex regex = new Regex("[A-Za-z\\s]");
			e.Handled = regex.IsMatch(e.Text);
		}

		private void EjecutarOperacion(object sender, KeyEventArgs e)
		{
			if(e.Key == Key.Return) {
				
				operacion.Text = Calcular(operacion.Text); ;
				

			}
		}

		private string Calcular(string churro)
		{
			churro.Replace(" ", "");
			
			String senuelo = churro;
			String[] nums = senuelo.Split('+', '-', '/', '*');
			int[] myInts = Array.ConvertAll(nums, int.Parse);
			int uno = myInts[0];
			int dos = myInts[1];

			if (churro.Contains("+"))
			{

				return (uno + dos).ToString();
			}
			else if (churro.Contains("-"))
			{
				return (uno - dos).ToString();
			}
			else if (churro.Contains("/"))
			{
				return (uno / dos).ToString();
			}
			else if (churro.Contains("*"))
			{
				return (uno * dos).ToString();
			}

			return null;

		}
		
		
	}
}
