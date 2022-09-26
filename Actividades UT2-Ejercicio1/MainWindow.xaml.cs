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

namespace Actividades_UT2_Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random semilla = new Random();
            int numeroRandom = semilla.Next(0, 101);
            Button_Comprobar(numeroRandom);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Reiniciar(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Comprobar(int numSecret)
        {
            if (int.Parse(NumeroUsuario.Text) == numSecret)
                
        }
    }
}
