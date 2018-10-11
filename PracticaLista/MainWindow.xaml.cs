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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumnos = new List<Alumno>();
        public MainWindow()
        {
            InitializeComponent();
            alumnos.Add(new Alumno("Juan Perez","179165","Lic. en Derecho"));
            alumnos.Add(new Alumno("Pedro Lopez", "176134", "Lic. en Psicologia"));
            alumnos.Add(new Alumno("Maria Garcia", "186154", "Lic. en Finanzas"));
            alumnos.Add(new Alumno("Ana Valenzuela", "145128", "Ing. Civil"));

            foreach(Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(
                    new ListBoxItem()
                    {
                           Content = alumno.Nombre
                    }
                    );
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
