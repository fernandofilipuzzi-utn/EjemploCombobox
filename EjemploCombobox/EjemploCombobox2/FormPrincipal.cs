using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCombobox2
{
    public partial class FormPrincipal : Form
    {
        //no uso una clase para gestionar y contener
        //no la necesito para esta situación
        RegistroConducir[] registros = new RegistroConducir[100];
        int cant = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            #region inicializo el contenedor
            registros[cant++] = new RegistroConducir("Romina", "A");
            registros[cant++] = new RegistroConducir("Sabrina", "B");
            registros[cant++] = new RegistroConducir("Juan", "B");
            registros[cant++] = new RegistroConducir("GPT", "C");
            #endregion

            #region inicializando el combo!
            for (int n = 0; n < cant; n++)
                comboBox1.Items.Add(registros[n].Nombre);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                RegistroConducir selected = registros[comboBox1.SelectedIndex];

                listBox1.Items.Add(selected.Nombre+"("+selected.Categoria+")");
            }
            else
            {
                MessageBox.Show("seleccione uno!");
            }
        }


    }
}
