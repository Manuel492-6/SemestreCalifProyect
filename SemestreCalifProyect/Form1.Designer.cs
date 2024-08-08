namespace SemestreCalifProyect
{
    partial class FormCapturaDeCalificaciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosSemestre = new GroupBox();
            btnAgregarSemestre = new Button();
            cboNumSemestre = new ComboBox();
            label1 = new Label();
            grpMateria = new GroupBox();
            btnAgregarMateria = new Button();
            txtCalificacion = new TextBox();
            txtNombreMateria = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lstSemestres = new ListBox();
            dgtDatosMaterias = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            grpOrden = new GroupBox();
            radDescendente = new RadioButton();
            radAscendente = new RadioButton();
            btnEliminarSemestre = new Button();
            btnEliminarMateria = new Button();
            tabOrganizador = new TabControl();
            tabDatos = new TabPage();
            tabArchivo = new TabPage();
            groupBox1 = new GroupBox();
            btnGuardarArchivo = new Button();
            btnEliminarArchivo = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            grpDatosSemestre.SuspendLayout();
            grpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtDatosMaterias).BeginInit();
            grpOrden.SuspendLayout();
            tabOrganizador.SuspendLayout();
            tabDatos.SuspendLayout();
            tabArchivo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosSemestre
            // 
            grpDatosSemestre.Controls.Add(btnAgregarSemestre);
            grpDatosSemestre.Controls.Add(cboNumSemestre);
            grpDatosSemestre.Controls.Add(label1);
            grpDatosSemestre.Location = new Point(6, 24);
            grpDatosSemestre.Margin = new Padding(3, 2, 3, 2);
            grpDatosSemestre.Name = "grpDatosSemestre";
            grpDatosSemestre.Padding = new Padding(3, 2, 3, 2);
            grpDatosSemestre.Size = new Size(376, 71);
            grpDatosSemestre.TabIndex = 0;
            grpDatosSemestre.TabStop = false;
            grpDatosSemestre.Text = "Datos Semestre";
            // 
            // btnAgregarSemestre
            // 
            btnAgregarSemestre.Location = new Point(275, 11);
            btnAgregarSemestre.Margin = new Padding(3, 2, 3, 2);
            btnAgregarSemestre.Name = "btnAgregarSemestre";
            btnAgregarSemestre.Size = new Size(82, 52);
            btnAgregarSemestre.TabIndex = 2;
            btnAgregarSemestre.Text = "Agregar Semestre";
            btnAgregarSemestre.UseVisualStyleBackColor = true;
            btnAgregarSemestre.Click += btnAgregarSemestre_Click;
            // 
            // cboNumSemestre
            // 
            cboNumSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumSemestre.FormattingEnabled = true;
            cboNumSemestre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cboNumSemestre.Location = new Point(146, 29);
            cboNumSemestre.Margin = new Padding(3, 2, 3, 2);
            cboNumSemestre.Name = "cboNumSemestre";
            cboNumSemestre.Size = new Size(113, 23);
            cboNumSemestre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Semestre";
            // 
            // grpMateria
            // 
            grpMateria.Controls.Add(btnAgregarMateria);
            grpMateria.Controls.Add(txtCalificacion);
            grpMateria.Controls.Add(txtNombreMateria);
            grpMateria.Controls.Add(label3);
            grpMateria.Controls.Add(label2);
            grpMateria.Location = new Point(6, 125);
            grpMateria.Margin = new Padding(3, 2, 3, 2);
            grpMateria.Name = "grpMateria";
            grpMateria.Padding = new Padding(3, 2, 3, 2);
            grpMateria.Size = new Size(376, 130);
            grpMateria.TabIndex = 1;
            grpMateria.TabStop = false;
            grpMateria.Text = "Datos Materia";
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(103, 89);
            btnAgregarMateria.Margin = new Padding(3, 2, 3, 2);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(169, 32);
            btnAgregarMateria.TabIndex = 4;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(181, 57);
            txtCalificacion.Margin = new Padding(3, 2, 3, 2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(78, 23);
            txtCalificacion.TabIndex = 3;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(151, 25);
            txtNombreMateria.Margin = new Padding(3, 2, 3, 2);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(206, 23);
            txtNombreMateria.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 57);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 1;
            label3.Text = "Calificacion de la materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de la materia";
            // 
            // lstSemestres
            // 
            lstSemestres.FormattingEnabled = true;
            lstSemestres.ItemHeight = 15;
            lstSemestres.Location = new Point(458, 35);
            lstSemestres.Margin = new Padding(3, 2, 3, 2);
            lstSemestres.Name = "lstSemestres";
            lstSemestres.Size = new Size(226, 184);
            lstSemestres.Sorted = true;
            lstSemestres.TabIndex = 2;
            lstSemestres.Click += lstSemestres_Click;
            // 
            // dgtDatosMaterias
            // 
            dgtDatosMaterias.AllowUserToAddRows = false;
            dgtDatosMaterias.AllowUserToDeleteRows = false;
            dgtDatosMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtDatosMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosMaterias.Columns.AddRange(new DataGridViewColumn[] { Nombre, Calificacion });
            dgtDatosMaterias.Location = new Point(15, 273);
            dgtDatosMaterias.Margin = new Padding(3, 2, 3, 2);
            dgtDatosMaterias.Name = "dgtDatosMaterias";
            dgtDatosMaterias.ReadOnly = true;
            dgtDatosMaterias.RowHeadersWidth = 51;
            dgtDatosMaterias.RowTemplate.Height = 29;
            dgtDatosMaterias.Size = new Size(384, 153);
            dgtDatosMaterias.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificacion";
            Calificacion.MinimumWidth = 6;
            Calificacion.Name = "Calificacion";
            Calificacion.ReadOnly = true;
            // 
            // grpOrden
            // 
            grpOrden.Controls.Add(radDescendente);
            grpOrden.Controls.Add(radAscendente);
            grpOrden.Location = new Point(458, 242);
            grpOrden.Margin = new Padding(3, 2, 3, 2);
            grpOrden.Name = "grpOrden";
            grpOrden.Padding = new Padding(3, 2, 3, 2);
            grpOrden.Size = new Size(219, 94);
            grpOrden.TabIndex = 4;
            grpOrden.TabStop = false;
            grpOrden.Text = "Orden De La Calificacion";
            // 
            // radDescendente
            // 
            radDescendente.AutoSize = true;
            radDescendente.Location = new Point(11, 58);
            radDescendente.Margin = new Padding(3, 2, 3, 2);
            radDescendente.Name = "radDescendente";
            radDescendente.Size = new Size(93, 19);
            radDescendente.TabIndex = 1;
            radDescendente.TabStop = true;
            radDescendente.Text = "Descendente";
            radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAscendente
            // 
            radAscendente.AutoSize = true;
            radAscendente.Checked = true;
            radAscendente.Location = new Point(11, 23);
            radAscendente.Margin = new Padding(3, 2, 3, 2);
            radAscendente.Name = "radAscendente";
            radAscendente.Size = new Size(87, 19);
            radAscendente.TabIndex = 0;
            radAscendente.TabStop = true;
            radAscendente.Text = "Ascendente";
            radAscendente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSemestre
            // 
            btnEliminarSemestre.Location = new Point(458, 353);
            btnEliminarSemestre.Margin = new Padding(3, 2, 3, 2);
            btnEliminarSemestre.Name = "btnEliminarSemestre";
            btnEliminarSemestre.Size = new Size(203, 22);
            btnEliminarSemestre.TabIndex = 5;
            btnEliminarSemestre.Text = "Eliminar Semestre";
            btnEliminarSemestre.UseVisualStyleBackColor = true;
            btnEliminarSemestre.Click += btnEliminarSemestre_Click;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Location = new Point(458, 390);
            btnEliminarMateria.Margin = new Padding(3, 2, 3, 2);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(203, 22);
            btnEliminarMateria.TabIndex = 6;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // tabOrganizador
            // 
            tabOrganizador.Controls.Add(tabDatos);
            tabOrganizador.Controls.Add(tabArchivo);
            tabOrganizador.Location = new Point(12, 37);
            tabOrganizador.Name = "tabOrganizador";
            tabOrganizador.SelectedIndex = 0;
            tabOrganizador.Size = new Size(727, 483);
            tabOrganizador.TabIndex = 7;
            // 
            // tabDatos
            // 
            tabDatos.Controls.Add(grpDatosSemestre);
            tabDatos.Controls.Add(btnEliminarMateria);
            tabDatos.Controls.Add(lstSemestres);
            tabDatos.Controls.Add(btnEliminarSemestre);
            tabDatos.Controls.Add(grpMateria);
            tabDatos.Controls.Add(grpOrden);
            tabDatos.Controls.Add(dgtDatosMaterias);
            tabDatos.Location = new Point(4, 24);
            tabDatos.Name = "tabDatos";
            tabDatos.Padding = new Padding(3);
            tabDatos.Size = new Size(719, 455);
            tabDatos.TabIndex = 0;
            tabDatos.Text = "Datos";
            tabDatos.UseVisualStyleBackColor = true;
            // 
            // tabArchivo
            // 
            tabArchivo.Controls.Add(groupBox1);
            tabArchivo.Location = new Point(4, 24);
            tabArchivo.Name = "tabArchivo";
            tabArchivo.Padding = new Padding(3);
            tabArchivo.Size = new Size(719, 455);
            tabArchivo.TabIndex = 1;
            tabArchivo.Text = "Archivo Propiedades";
            tabArchivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarArchivo);
            groupBox1.Controls.Add(btnEliminarArchivo);
            groupBox1.Location = new Point(140, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 228);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Propiedades";
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.Location = new Point(124, 47);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(203, 52);
            btnGuardarArchivo.TabIndex = 3;
            btnGuardarArchivo.Text = "Guardar Datos Del  Archivo";
            btnGuardarArchivo.UseVisualStyleBackColor = true;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnEliminarArchivo
            // 
            btnEliminarArchivo.Location = new Point(124, 114);
            btnEliminarArchivo.Name = "btnEliminarArchivo";
            btnEliminarArchivo.Size = new Size(203, 52);
            btnEliminarArchivo.TabIndex = 5;
            btnEliminarArchivo.Text = "Eliminar Archivo";
            btnEliminarArchivo.UseVisualStyleBackColor = true;
            btnEliminarArchivo.Click += btnEliminarArchivo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 8;
            label4.Text = "Semestres Capturados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 19);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 19);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 10;
            label6.Text = "Calificacion Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(624, 19);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // FormCapturaDeCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 545);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tabOrganizador);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCapturaDeCalificaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Captura Calificacion";
            Load += Form1_Load;
            grpDatosSemestre.ResumeLayout(false);
            grpDatosSemestre.PerformLayout();
            grpMateria.ResumeLayout(false);
            grpMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgtDatosMaterias).EndInit();
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            tabOrganizador.ResumeLayout(false);
            tabDatos.ResumeLayout(false);
            tabArchivo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosSemestre;
        private ComboBox cboNumSemestre;
        private Label label1;
        private Button btnAgregarSemestre;
        private GroupBox grpMateria;
        private Button btnAgregarMateria;
        private TextBox txtCalificacion;
        private TextBox txtNombreMateria;
        private Label label3;
        private Label label2;
        private ListBox lstSemestres;
        private DataGridView dgtDatosMaterias;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Calificacion;
        private GroupBox grpOrden;
        private RadioButton radDescendente;
        private RadioButton radAscendente;
        private Button btnEliminarSemestre;
        private Button btnEliminarMateria;
        private TabControl tabOrganizador;
        private TabPage tabDatos;
        private TabPage tabArchivo;
        private Button btnEliminarArchivo;
        private Button btnGuardarArchivo;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}