namespace Hamurabi
{
    partial class Hamurabi_Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hamurabi_Ventana));
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraHerramientas = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pegarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botonDeshacer = new System.Windows.Forms.ToolStripButton();
            this.botonRehacer = new System.Windows.Forms.ToolStripButton();
            this.editorDeTexto = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.botonIniciar = new System.Windows.Forms.ToolStripButton();
            this.barraMenu.SuspendLayout();
            this.barraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.Olive;
            this.barraMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(799, 25);
            this.barraMenu.TabIndex = 0;
            this.barraMenu.Text = "barraMenu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.guardarcomoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarcomoToolStripMenuItem.Image")));
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.deshacerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deshacerToolStripMenuItem.Image")));
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.rehacerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rehacerToolStripMenuItem.Image")));
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cortarToolStripMenuItem.Text = "Cor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.personalizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personalizarToolStripMenuItem.Image")));
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // barraHerramientas
            // 
            this.barraHerramientas.BackColor = System.Drawing.Color.Black;
            this.barraHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraHerramientas.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.abrirToolStripButton,
            this.guardarToolStripButton,
            this.toolStripSeparator,
            this.cortarToolStripButton,
            this.copiarToolStripButton,
            this.pegarToolStripButton,
            this.toolStripSeparator1,
            this.botonDeshacer,
            this.botonRehacer,
            this.toolStripSeparator2,
            this.botonIniciar});
            this.barraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.barraHerramientas.Name = "barraHerramientas";
            this.barraHerramientas.Size = new System.Drawing.Size(799, 25);
            this.barraHerramientas.TabIndex = 1;
            this.barraHerramientas.Text = "barraHerramientas";
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripButton.Image")));
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuevoToolStripButton.Text = "&Nuevo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // guardarToolStripButton
            // 
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton.Image")));
            this.guardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.guardarToolStripButton.Text = "&Guardar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cortarToolStripButton
            // 
            this.cortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripButton.Image")));
            this.cortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripButton.Name = "cortarToolStripButton";
            this.cortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cortarToolStripButton.Text = "Cort&ar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            this.pegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripButton.Image")));
            this.pegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripButton.Name = "pegarToolStripButton";
            this.pegarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // botonDeshacer
            // 
            this.botonDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("botonDeshacer.Image")));
            this.botonDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonDeshacer.Name = "botonDeshacer";
            this.botonDeshacer.Size = new System.Drawing.Size(23, 22);
            this.botonDeshacer.Text = "Deshacer";
            // 
            // botonRehacer
            // 
            this.botonRehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonRehacer.Image = ((System.Drawing.Image)(resources.GetObject("botonRehacer.Image")));
            this.botonRehacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonRehacer.Name = "botonRehacer";
            this.botonRehacer.Size = new System.Drawing.Size(23, 22);
            this.botonRehacer.Text = "Rehacer";
            // 
            // editorDeTexto
            // 
            this.editorDeTexto.BackColor = System.Drawing.SystemColors.MenuText;
            this.editorDeTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorDeTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorDeTexto.ForeColor = System.Drawing.Color.Gold;
            this.editorDeTexto.Location = new System.Drawing.Point(0, 50);
            this.editorDeTexto.Name = "editorDeTexto";
            this.editorDeTexto.Size = new System.Drawing.Size(799, 401);
            this.editorDeTexto.TabIndex = 2;
            this.editorDeTexto.Text = "";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // botonIniciar
            // 
            this.botonIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonIniciar.Image = ((System.Drawing.Image)(resources.GetObject("botonIniciar.Image")));
            this.botonIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(23, 22);
            this.botonIniciar.Text = "Iniciar";
            // 
            // Hamurabi_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.editorDeTexto);
            this.Controls.Add(this.barraHerramientas);
            this.Controls.Add(this.barraMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraMenu;
            this.Name = "Hamurabi_Ventana";
            this.Text = "Hamurabi";
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraHerramientas;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton pegarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botonDeshacer;
        private System.Windows.Forms.ToolStripButton botonRehacer;
        private System.Windows.Forms.RichTextBox editorDeTexto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton botonIniciar;
    }
}

