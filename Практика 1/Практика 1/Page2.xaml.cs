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

namespace Практика_1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string X1 = X_1.Text;
            string Y1 = Y_1.Text;
            string X2 = X_2.Text;
            string Y2 = Y_2.Text;
            int x1= Convert.ToInt32(X1);
            int y1 = Convert.ToInt32(Y1);
            int x2 = Convert.ToInt32(X2);
            int y2 = Convert.ToInt32(Y2);
            int a = Math.Abs(x2 - x1);
            int b = Math.Abs(y2 - y1);
            int s = a * b;
            int p = 2 * (a + b);
            S.Text = s.ToString();
            P.Text = p.ToString();
        }
    }
}
