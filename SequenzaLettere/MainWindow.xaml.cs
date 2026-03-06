using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SequenzaLettere
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

        private char _letteraSorteggiata;

        private async void giramentoLettere()
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int tmp = 0;
            while(true)
            {
                tmp++;
                if(tmp > 25)
                {
                    tmp = 0;
                }
                await Task.Delay(150);
                _letteraSorteggiata = alfabeto[tmp];
                lblLettere.Content = _letteraSorteggiata;
            }
        }

        private string _frase;

        private void btnSorteggia_Click(object sender, RoutedEventArgs e)
        {
            giramentoLettere();
            btnSorteggia.Content = "Sorteggia";
            _frase += _letteraSorteggiata;
            lblFrase.Content = _frase;
        }
    }
}