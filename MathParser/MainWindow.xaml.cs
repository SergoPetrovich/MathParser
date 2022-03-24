using System.Windows;
using org.mariuszgromada.math.mxparser;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace MathParser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            Expression ex = new Expression(stro.Text);
            stro.Text = ex.calculate().ToString().Replace(",",".");


        }
    }
}
