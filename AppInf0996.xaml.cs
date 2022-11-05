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

namespace FuncionamentoBasico
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AppInf0996 : Window
    {
        public AppInf0996()
        {
            InitializeComponent();
        }

        public void MenuSuperior_Click(object sender, RoutedEventArgs e) {
            this.Hide();
        }
    }
}
