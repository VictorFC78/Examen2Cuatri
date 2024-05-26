using Examen5BPJ;
using System.Collections.ObjectModel;
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

namespace Examen2Cuatri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contenedor> contenedores;
        public MainWindow()
        {
            InitializeComponent();
            contenedores=LogicaNegocio.GetAllContenedores();
            btn.IsEnabled = false;
            this.DataContext = contenedores;

        }

        private void validar(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<Contenedor> lista = LogicaNegocio.GetAllContenedores();
            Boolean correcto = false;
            for(int i = 0; i < lista.Count && correcto == false; i++)
            {
                if (lista[i].TipoContenido.Equals(txt.Text.ToString()))
                {
                    correcto = true;
                    btn.IsEnabled = true;
                }
                else
                {
                    btn.IsEnabled = false;
                }
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            contenedores=LogicaNegocio.GetContenedoresTipoContenido(txt.Text);
            this.DataContext = contenedores;
            double pesoMedio=LogicaNegocio.pesomedio(contenedores);
            pm.Text = pesoMedio.ToString();
        }
    }
}