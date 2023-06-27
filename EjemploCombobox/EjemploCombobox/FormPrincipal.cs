using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCombobox
{
    public partial class FormPrincipal : Form
    {
        //no uso una clase para gestionar y contener
        //no la necesito para esta situación
        RegistroConducir[] registros = new RegistroConducir[100];
        int cant = 0;
        
        RegistroConducir selected = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                //notar que el indice del combobox es congruente con el indice del arreglo
                selected = registros[comboBox1.SelectedIndex];

                #region muestro la info del registro seleccionada
                numericUpDown1.Value = selected.Puntos;
                numericUpDown1.Enabled = true;
                label1.Text = string.Format("{0} ({1})", selected.Nombre, selected.Categoria);
                #endregion
            }
            else
            {
                #region muestro la info del registro seleccionada
                numericUpDown1.Value = 0;
                numericUpDown1.Enabled = false;
                label1.Text = "";
                #endregion
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(selected!=null)
                selected.Puntos= Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
