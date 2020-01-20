using System;
using System.Collections.Generic;
using System.IO;
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

namespace EsercizioNatale2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(txt1.Text);
                double b = double.Parse(txt2.Text);

                if (combooperazione.SelectedIndex == 0)
                {
                    double r = a + b;
                    txtrisultato.Text = r.ToString();

                }
                else if (combooperazione.SelectedIndex == 1)
                {
                    double r = a - b;
                    txtrisultato.Text = r.ToString();

                }
                else if (combooperazione.SelectedIndex == 2)
                {
                    double r = a * b;
                    txtrisultato.Text = r.ToString();

                }
                else if (combooperazione.SelectedIndex == 3)
                {
                    if (b != 0)
                    {
                        double r = a / b;
                        txtrisultato.Text = r.ToString();
                    }
                    else
                        txtrisultato.Text = "L'operazione non è possibile";

                }

                string risultato = txtrisultato.Text;
                StreamWriter sw = new StreamWriter("storicooperazioni.txt", true, Encoding.UTF8);
                sw.WriteLine(risultato);
                sw.Flush();
                sw.Close();
            }

            catch
            {
                MessageBox.Show("Non hai inserito numeri all'interno delle textbox","Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
            
            
    }
}


