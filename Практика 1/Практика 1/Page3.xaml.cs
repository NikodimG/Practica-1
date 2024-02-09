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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string xx = X.Text;
            string yy = Y.Text;
            string aa = A.Text;
            string bb = B.Text;
            int x = Convert.ToInt32(xx);
            int y = Convert.ToInt32(yy);
            int a = Convert.ToInt32(aa);
            int b = Convert.ToInt32(bb);
            int Kg1_konfed = a / x;
            int Kg1_irisok = b / y;
            double Otlishie = Kg1_konfed / Kg1_irisok;
            Kg_konfed.Text = Kg1_konfed.ToString();
            Kg_irisok.Text = Kg1_irisok.ToString();
            Rashica.Text = Otlishie.ToString();
        }
    }
}
