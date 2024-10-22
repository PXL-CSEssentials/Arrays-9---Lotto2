using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arrays_9___Lotto2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            const int NumberOfLottoNumbers = 6;
            const int MinLottoNumber = 1;
            const int MaxLottoNumber = 45;

            Random _random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            int[] numbers = new int[NumberOfLottoNumbers];

            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = _random.Next(1, 46); // willekeurig getal van 1 t.e.m. 45
                for (int k = 0; k < j; k++) //Loop through array until current number
                {
                    if (numbers[k] == numbers[j]) //Is number already in array
                    {
                        numbers[j] = _random.Next(1, 46); //Generate new number
                    }
                }
                stringBuilder.AppendLine($"Getal {j + 1} : {numbers[j]}");
            }
            resultTextBox.Text = stringBuilder.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            //resultTextBox.Text = string.Empty;
            startButton.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
