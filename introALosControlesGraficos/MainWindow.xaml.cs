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

        string[] listaProfesiones = new string[]
        {
            "Odontóloga/o",
            "Ingeniera/o",
            "Contador/a",
            "Periodista"
        };

        List<Profesion> listaProfesiones2 = new List<Profesion>();

        public MainWindow()//constructor
        {
            InitializeComponent();
            listaP = new List<Persona>();

            listaProfesiones2.Add(new Profesion(1, "Odontoga/o", "Profesión de la salud dedicada a la salud bucal."));
            listaProfesiones2.Add(new Profesion(2, "Ingeniera/o", "Profesión dedicada a ser dioses."));
            listaProfesiones2.Add(new Profesion(3, "Contador", "Profesión dedicada a contar."));
            listaProfesiones2.Add(new Profesion(4, "Periodista", "Profesión dedicada a narrar noticias."));

            foreach(Profesion pr in listaProfesiones2)
            {
                Debug.WriteLine(pr);
            }


            //con esta Propiedad, podemos establecer el origen de datos de un combobox
            comboBoxProfesion.ItemsSource = listaProfesiones2;
        }

        private void buttonRegistrar_Click(object sender, RoutedEventArgs e)//funciones o métodos
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

        private void buttonRegistrar_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Estoy encima del botón");
        }

        private void comboBoxProfesion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Esto me permite capturar el item seleccionado
            //Debemos hacer un "casting" para que el valor que viene como 'object' sea transformado a la clase que necesitamos
            //en este caso, profesión
            Profesion itemSeleccionado = (Profesion)comboBoxProfesion.SelectedItem;

            Debug.WriteLine(itemSeleccionado.Descripcion);
        }
    }
}
