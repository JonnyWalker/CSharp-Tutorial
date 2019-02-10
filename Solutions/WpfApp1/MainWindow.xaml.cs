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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int getIntEingabe1()
        {
            return int.Parse(Input1.Text);
        }

        private int getIntEingabe2()
        {
            return int.Parse(Input2.Text);
        }

        private void ButtonLos_Click(object sender, RoutedEventArgs e)
        {
            string ergebnis = "";
            try
            {
                int ergebnisInt = getIntEingabe1() + getIntEingabe2();
                ergebnis = string.Format("Das Ergebnis lautet {0}", ergebnisInt);
            } catch (FormatException e1)
            {
                ergebnis = "Sie haben ungültige Zahlen angebeben";
            }
            LabelErgebnis.Content = ergebnis;
        }
    }
}
