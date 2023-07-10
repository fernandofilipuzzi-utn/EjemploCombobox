using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDetalleEnModal
{
    public partial class Form1 : Form
    {
        Persona[] personas;
        public Form1()
        {
            InitializeComponent();

            personas = new Persona[] {
                new Persona { DNI=32312232, Nombre="Guillermina"},
                new Persona { DNI=42313279, Nombre="Juan Andrés"},
                new Persona { DNI=40992331, Nombre="Julieta"}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDetalle f2 = new FormDetalle();

            #region inicialización de f2
            f2.listBox1.Items.Clear();
            foreach (Persona p in personas)
                f2.listBox1.Items.Add(p.Nombre);
            #endregion

            int idx = -1;
            do
            {
                f2.ShowDialog();

                #region mostrar mayor detalle
                if (f2.DialogResult == DialogResult.Retry)
                {
                    idx = f2.listBox1.SelectedIndex;
                    if (idx > -1)
                    {
                        //podría ser otra modal!
                        MessageBox.Show($"{personas[idx].Nombre}({personas[idx].DNI})");
                    }
                }
                #endregion

            } while (f2.DialogResult == DialogResult.Retry) ;

            if (f2.DialogResult == DialogResult.OK)
            {
                if (idx > -1)
                    Text = $"{personas[idx].Nombre}({personas[idx].DNI})";
                else
                    Text = "no seleccionado";
            }

            f2.Dispose();
        }
    }
}
