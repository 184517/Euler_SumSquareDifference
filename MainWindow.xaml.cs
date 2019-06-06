/* Jordan Ross
 * June 5, 2019
 * Sum of the squares from one to one hundred minus the square of the sum from one to one hunred
 */
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

namespace Euler_SumSquareDifference
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double SumOfSquares;
        double SquareOfSum = 0;
        double finalSum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            double sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                SumOfSquares += i * i;
                SquareOfSum += i;
            }

            result = SquareOfSum;
            sum = result * result;
            finalSum = sum -SumOfSquares;
            MessageBox.Show(finalSum.ToString());



        }
    }
}
