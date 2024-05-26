namespace sqlprueba
{
    partial class Form1
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
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.CREAR = new System.Windows.Forms.Button();
            this.NivelDePoder = new System.Windows.Forms.NumericUpDown();
            this.RazaList = new System.Windows.Forms.ComboBox();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.labelfecha_creacion = new System.Windows.Forms.Label();
            this.textBoxhistoria = new System.Windows.Forms.TextBox();
            this.labelhistoria = new System.Windows.Forms.Label();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelDePoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(609, 279);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(110, 37);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Boron prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(61, 218);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(496, 153);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(609, 228);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(110, 28);
            this.Cargar.TabIndex = 2;
            this.Cargar.Text = "Cargar datos";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Powe";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(162, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(127, 20);
            this.Id.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(165, 71);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(123, 20);
            this.Nombre.TabIndex = 8;
            // 
            // CREAR
            // 
            this.CREAR.Location = new System.Drawing.Point(609, 335);
            this.CREAR.Name = "CREAR";
            this.CREAR.Size = new System.Drawing.Size(110, 26);
            this.CREAR.TabIndex = 10;
            this.CREAR.Text = "Crear";
            this.CREAR.UseVisualStyleBackColor = true;
            this.CREAR.Click += new System.EventHandler(this.CREAR_Click);
            // 
            // NivelDePoder
            // 
            this.NivelDePoder.Location = new System.Drawing.Point(163, 153);
            this.NivelDePoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NivelDePoder.Name = "NivelDePoder";
            this.NivelDePoder.Size = new System.Drawing.Size(125, 20);
            this.NivelDePoder.TabIndex = 11;
            this.NivelDePoder.ValueChanged += new System.EventHandler(this.NivelDePoder_ValueChanged);
            // 
            // RazaList
            // 
            this.RazaList.FormattingEnabled = true;
            this.RazaList.Location = new System.Drawing.Point(160, 110);
            this.RazaList.Name = "RazaList";
            this.RazaList.Size = new System.Drawing.Size(127, 21);
            this.RazaList.TabIndex = 12;
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.Enabled = false;
            this.dateTimePickerfecha.Location = new System.Drawing.Point(436, 34);
            this.dateTimePickerfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(264, 20);
            this.dateTimePickerfecha.TabIndex = 18;
            this.dateTimePickerfecha.Value = new System.DateTime(2024, 5, 22, 10, 19, 17, 0);
            this.dateTimePickerfecha.ValueChanged += new System.EventHandler(this.dateTimePickerfecha_ValueChanged);
            // 
            // labelfecha_creacion
            // 
            this.labelfecha_creacion.AutoSize = true;
            this.labelfecha_creacion.Location = new System.Drawing.Point(326, 34);
            this.labelfecha_creacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfecha_creacion.Name = "labelfecha_creacion";
            this.labelfecha_creacion.Size = new System.Drawing.Size(96, 13);
            this.labelfecha_creacion.TabIndex = 17;
            this.labelfecha_creacion.Text = "Fecha de creacion";
            // 
            // textBoxhistoria
            // 
            this.textBoxhistoria.Location = new System.Drawing.Point(388, 71);
            this.textBoxhistoria.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxhistoria.Name = "textBoxhistoria";
            this.textBoxhistoria.Size = new System.Drawing.Size(129, 20);
            this.textBoxhistoria.TabIndex = 20;
            // 
            // labelhistoria
            // 
            this.labelhistoria.AutoSize = true;
            this.labelhistoria.Location = new System.Drawing.Point(332, 77);
            this.labelhistoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelhistoria.Name = "labelhistoria";
            this.labelhistoria.Size = new System.Drawing.Size(42, 13);
            this.labelhistoria.TabIndex = 19;
            this.labelhistoria.Text = "Historia";
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(746, 335);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(78, 22);
            this.buttoneliminar.TabIndex = 23;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(746, 279);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(78, 37);
            this.buttonActualizar.TabIndex = 22;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(746, 233);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(71, 23);
            this.buttonbuscar.TabIndex = 21;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBoxhistoria);
            this.Controls.Add(this.labelhistoria);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.labelfecha_creacion);
            this.Controls.Add(this.RazaList);
            this.Controls.Add(this.NivelDePoder);
            this.Controls.Add(this.CREAR);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelDePoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button CREAR;
        private System.Windows.Forms.NumericUpDown NivelDePoder;
        private System.Windows.Forms.ComboBox RazaList;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.Label labelfecha_creacion;
        private System.Windows.Forms.TextBox textBoxhistoria;
        private System.Windows.Forms.Label labelhistoria;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonbuscar;
    }
}

