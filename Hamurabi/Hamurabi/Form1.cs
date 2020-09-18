using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamurabi
{
    public partial class Hamurabi_Ventana : Form
    {
        public Hamurabi_Ventana()
        {
            InitializeComponent();
        }

        private void editorDeTexto_TextChanged(object sender, EventArgs e)
        {
            //Se calcula la posición inicial de la linea 
            int inicio = 0, final = 0;

            for (inicio = editorDeTexto.SelectionStart - 1; inicio > 0; inicio--)
            {
                if (editorDeTexto.Text[inicio] == '\n')
                {
                    inicio++;
                    break;
                }
            } 
            //Calcula la posición final de la linea actual
            for (final = editorDeTexto.SelectionStart; final < editorDeTexto.Text.Length; final++)
            {
                if (editorDeTexto.Text[final] == '\n') break;
            }
            //Extrae la linea actual que esta siendo editada
            String linea = editorDeTexto.Text.Substring(inicio, final - inicio);
            //Realiza un respaldo de punto actual de seleccion
            int seleccionInicio = editorDeTexto.SelectionStart;
            int longitudSeleccion = editorDeTexto.SelectionLength;

            //Divide la linea en tokens
            Regex rx = new Regex("([ \\t{}();])");
            string[] tokens = rx.Split(linea);
            int indice = inicio;
            foreach (string token in tokens)
            {

                //Estable el color por defecto de la fuente
                editorDeTexto.SelectionStart = indice;
                editorDeTexto.SelectionLength = token.Length;
                editorDeTexto.SelectionColor = Color.Yellow;
               // editorDeTexto.SelectionFont = new Font("Verdana", 13, FontStyle.Regular);


                ///Revisa si hay un comentario
                if (token == "//" || token.StartsWith("//"))
                {
                    //Encuentra el inicio del comentario y extra el comentario completo.
                    int longi = linea.Length - (indice - inicio);
                    string comentarTexto = editorDeTexto.Text.Substring(indice, longi);
                    editorDeTexto.SelectionStart = indice;
                    editorDeTexto.SelectionLength = longi;
                    editorDeTexto.SelectionColor = Color.Red;
                   // editorDeTexto.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                    break;
                }

                if (token.StartsWith("/*") && token.EndsWith("*/"))
                {
                    int longi = linea.Length - (indice - inicio);
                    string comentarTexto = editorDeTexto.Text.Substring(indice, longi);
                    editorDeTexto.SelectionStart = indice;
                    editorDeTexto.SelectionLength = longi;
                    editorDeTexto.SelectionColor = Color.Red;
                 //   editorDeTexto.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);

                    // richTextBox1.SelectionColor = Color.Yellow;
                    break;

                }

            }
            //Restaura la selección actual del usuario  
            editorDeTexto.SelectionStart = seleccionInicio;
            editorDeTexto.SelectionLength = longitudSeleccion;

        }
    }

}