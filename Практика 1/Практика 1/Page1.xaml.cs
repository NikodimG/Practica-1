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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = A.Text;
            string b = B.Text;
            string c = C.Text;
            int a_1 = Convert.ToInt32(a);
            int b_1 = Convert.ToInt32(b);
            int c_1 = Convert.ToInt32(c);
            int volume = a_1 * b_1 * c_1;
            int surfaceArea = 2 * (a_1 * b_1 + b_1 * c_1 + a_1 * c_1);
            V.Text = volume.ToString();
            S.Text = surfaceArea.ToString();
        }

    }
}
