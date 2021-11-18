using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using introALosControlesGraficos.model;

namespace introALosControlesGraficos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> listaP;

        public MainWindow()
        {
            InitializeComponent();
            listaP = new List<Persona>();
        }

        private void buttonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string nombrePersona = textBoxNombre.Text;
            string apellidoPersona = textBoxApellido.Text;
            int edadPersona = int.Parse(textBoxEdad.Text);//Convert.ToInt32
            Persona p = new Persona(nombrePersona, apellidoPersona, edadPersona);
            listaP.Add(p);

            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";

            textBoxNombre.Focus();

            foreach(Persona pe in listaP)
            {
                Debug.WriteLine(pe.Nombre);
                Debug.WriteLine(pe.Apellido);
                Debug.WriteLine(pe.Edad);
                Debug.WriteLine("***");
                    
            }
        }

    }
}
