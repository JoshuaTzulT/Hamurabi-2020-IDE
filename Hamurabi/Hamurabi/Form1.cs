using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamurabi
{
    public partial class Hamurabi_Ventana : Form
    {
        int inicio = 0;
        int final = 0;

        public Hamurabi_Ventana()
        {
            InitializeComponent();
            
        }
        


        //Este método se encargar de contar la posición actual del cursor dentro del area de edición de texto.
        public void Contador()
        {//Inicio del método
            int fila = 1 + editorDeTexto.GetLineFromCharIndex(editorDeTexto.GetFirstCharIndexOfCurrentLine());
            int columna = 1 + editorDeTexto.SelectionStart - editorDeTexto.GetFirstCharIndexOfCurrentLine();
            label1.Text = "Fila: " + fila.ToString() + "  Columna: " + columna.ToString();
        }//final del método



        //Este métddo pertenece a toda el area de texto, es decir donde el usuario escribe.
        private void editorDeTexto_TextChanged(object sender, EventArgs e)
        {//Inicio del método
            Contador();

            //Este bucle for calcula la posición inicial de la linea 

            for (inicio = editorDeTexto.SelectionStart - 1; inicio > 0; inicio--)
            {//Inicio bucle for
                if (editorDeTexto.Text[inicio] == '\n')
                {//Inicio condicional if
                    inicio++;
                    break;
                }//Fin condicional if
            }//fin bucle for

            //Este bucle for calcula la posición final de la linea actual
            for (final = editorDeTexto.SelectionStart; final < editorDeTexto.Text.Length; final++)
            {//Inicio bucle for
                if (editorDeTexto.Text[final] == '\n') break;
            }//fin bucle for


            //Esta condicional if, evita un error al quedar el documento en blanco
            if (inicio < 0)
            {//Inicio condicional if
                inicio = 0;
            }//fin condicional if

            //Extrae la linea actual que esta siendo editada
            String linea = editorDeTexto.Text.Substring(inicio, final - inicio);

            //Realiza un respaldo de punto actual de seleccion
            int seleccionInicio = editorDeTexto.SelectionStart;
            int longitudSeleccion = editorDeTexto.SelectionLength;

            //Esta es la expresión regular que se en cargar de Dividir la linea en tokens
            Regex rx = new Regex("([\\s;()])");
            string[] tokens = rx.Split(linea);
            int indice = inicio;

            foreach (string token in tokens)
            {//incicio bucle foreach

                //Establece  el color por defecto de la fuente
                editorDeTexto.SelectionStart = indice;
                editorDeTexto.SelectionLength = token.Length;
                editorDeTexto.SelectionColor = Color.White;
                editorDeTexto.SelectionFont = new Font("Verdana", 14, FontStyle.Regular);


                ///Revisa si hay un comentario
                if (token == "//" || token.StartsWith("//"))
                {//Inicio condicional if
                    //Encuentra el inicio del comentario y extra el comentario completo.
                    int longi = linea.Length - (indice - inicio);
                    string comentarTexto = editorDeTexto.Text.Substring(indice, longi);
                    editorDeTexto.SelectionStart = indice;
                    editorDeTexto.SelectionLength = longi;
                    editorDeTexto.SelectionColor = Color.Red;
                    editorDeTexto.SelectionFont = new Font("Calibri", 14, FontStyle.Italic);
                    break;
                }//fin condicional if

                //Revisa si hay un comentario 
                if (token.StartsWith("/*") && token.EndsWith("*/"))
                {//Inicio condicional if
                    int longi = linea.Length - (indice - inicio);
                    string comentarTexto = editorDeTexto.Text.Substring(indice, longi);
                    editorDeTexto.SelectionStart = indice;
                    editorDeTexto.SelectionLength = longi;
                    editorDeTexto.SelectionColor = Color.Red;
                    break;
                }//fin condicional if

                // Comprueba si el token es una Keyword 
                String[] reconocimiento = {"Entero","entero", "Decimal","decimal", "Cadena", "cadena", "Boolean", "booleano", "caracter", "Chart", 
                                            "+", "-", "*", "*", "/", "!", "<", ">", ">=", "<=",  "==",
                                           "||", "&&", "(", ")", "=", ";",  "!=", "++", "--",
                                           "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE",
                                           "HASTA", "INCREMENTO",};

                for (int i = 0; i < reconocimiento.Length; i++)
                {
                    if (reconocimiento[i] == token && token == "Entero"  || reconocimiento[i] == token && token == "entero")
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Purple;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Regular);
                        break;
                    }

                    if (reconocimiento[i] == token && token == "Decimal" || reconocimiento[i] == token && token == "decimal")
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Turquoise;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Bold);
                        break;
                    }


                    if (reconocimiento[i] == token && token == "Cadena"  || reconocimiento[i] == token && token == "cadena")
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Gray;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Bold);
                        break;
                    }


                    if (reconocimiento[i] == token && token == "Boolean"  || reconocimiento[i] == token && token == "booleano")
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Orange;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Bold);
                        break;
                    }


                    if (reconocimiento[i] == token && token == "Chart"  || reconocimiento[i] == token && token == "caracter")
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Brown;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Bold);
                        break;
                    }


                    if (reconocimiento[i] == token && (token == "+" || token == "-" || token == "*" || token == "/"
                        || token == "<" || token == ">" || token == ">=" || token == "<=" || token == "==" || token == "!="
                        || token == "||" || token == "&&" || token == "(" || token == ")" || token == "++" || token == "--"))
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Blue;
                        editorDeTexto.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    }

                    if (reconocimiento[i] == token && (token == "=" || token == ";"))
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.DeepPink;
                        editorDeTexto.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                        break;
                    }

                    if (reconocimiento[i] == token && (token == "SI" || token == "SINO"
                        || token == "SINO_SI" || token == "MIENTRAS" || token == "HACER"
                        || token == "DESDE" || token == "HASTA" || token == "INCREMENTO"))
                    {
                        //Aplica un color y fuente diferente a la keyword.      
                        editorDeTexto.SelectionColor = Color.Green;
                        editorDeTexto.SelectionFont = new Font("Courier New", 14, FontStyle.Bold);
                        break;
                    }
                }
                indice += token.Length;

            }// fin bucle foreach

            //Restaura la selección actual del usuario  
            editorDeTexto.SelectionStart = seleccionInicio;
            editorDeTexto.SelectionLength = longitudSeleccion;

        }//Final del método.

        //Este método esta relacionado con el boton guardar 
        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar";
            sfd.Filter = "Documento de Texto (*.gtE)|*.gtE";
            sfd.DefaultExt = "gtE";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {//inicio condicional if

                StreamWriter txtSalida = new StreamWriter(sfd.FileName);
                txtSalida.Write(editorDeTexto.Text);
                txtSalida.Close();

            }//fin condicional if

        }//Final del método

        //Este método esta relacionado con el boton abrir 
        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método
         //Método del botón para abrir un archivo.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = " ";
            if (ofd.ShowDialog() != DialogResult.OK)
            {//Inicio condicional If
                return;
            }//fin condicional if.
            editorDeTexto.Clear();
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                editorDeTexto.Text = sr.ReadToEnd();
                sr.Close();
            }

        }//Final del método

        //Este método está relacionado con el boton Nuevo
        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método 
            editorDeTexto.Clear();
        }//Final del método

        //Este método está relacionado con el boton Cortar
        private void cortarToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método
            editorDeTexto.Cut();
        }//Fin del método

        //Este método está relacionada con el boton Copiar
        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método 
            editorDeTexto.Copy();
        }//Final del método

        //Este método está relacionado con el botón pegar
        private void pegarToolStripButton_Click(object sender, EventArgs e)
        {//Inicio del método
            editorDeTexto.Paste();
        }//Final del método

        //Este método esta relacionado con el boton Deshacer
        private void botonDeshacer_Click(object sender, EventArgs e)
        {//Inicio del método
            editorDeTexto.Undo();
        }//Final del método

        //Este método está relacionado con el botón Rehacer
        private void botonRehacer_Click(object sender, EventArgs e)
        {//Inicio del método
            editorDeTexto.Redo();
        }//Final del método

        //Este método está relacionado con el boton salir del menu desplegable
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {//Inicio del método
            Application.Exit();
        }//Final del método

        //Este método está relacionado con el boton nuevo del menu desplegable
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {//Inicio del método
            nuevoToolStripButton.PerformClick();
        }//Final del método

        //Este método está relacionado con el boton guardar del menu desplegable
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {//Inicio del método
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar";
            sfd.Filter = "Documento de Texto (*.gtE)|*.gtE";
            sfd.DefaultExt = "gtE";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {//inicio condicional if

                StreamWriter txtSalida = new StreamWriter(sfd.FileName);
                txtSalida.Write(editorDeTexto.Text);
                txtSalida.Close();

            }//fin condicional if
        }//Final del método

        //Este método está relacionado con el boton abrir del menu desplegable
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {//Inicio del método
            //Método del botón para abrir un archivo.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = " ";
            if (ofd.ShowDialog() != DialogResult.OK)
            {//Inicio condicional If
                return;
            }//fin condicional if.
            editorDeTexto.Clear();
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                editorDeTexto.Text = sr.ReadToEnd();
                sr.Close();
            }
        }//final del método
    }
}
