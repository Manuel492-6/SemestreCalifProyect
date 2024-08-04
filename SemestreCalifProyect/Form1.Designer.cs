namespace SemestreCalifProyect
{
    partial class Form1
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
            grpDatosSemestre.SuspendLayout();
            grpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtDatosMaterias).BeginInit();
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosSemestre
            // 
            grpDatosSemestre.Controls.Add(btnAgregarSemestre);
            grpDatosSemestre.Controls.Add(cboNumSemestre);
            grpDatosSemestre.Controls.Add(label1);
            grpDatosSemestre.Location = new Point(30, 21);
            grpDatosSemestre.Name = "grpDatosSemestre";
            grpDatosSemestre.Size = new Size(430, 95);
            grpDatosSemestre.TabIndex = 0;
            grpDatosSemestre.TabStop = false;
            grpDatosSemestre.Text = "Datos Semestre";
            // 
            // btnAgregarSemestre
            // 
            btnAgregarSemestre.Location = new Point(314, 15);
            btnAgregarSemestre.Name = "btnAgregarSemestre";
            btnAgregarSemestre.Size = new Size(94, 69);
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
            cboNumSemestre.Location = new Point(167, 39);
            cboNumSemestre.Name = "cboNumSemestre";
            cboNumSemestre.Size = new Size(129, 28);
            cboNumSemestre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
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
            grpMateria.Location = new Point(30, 139);
            grpMateria.Name = "grpMateria";
            grpMateria.Size = new Size(430, 174);
            grpMateria.TabIndex = 1;
            grpMateria.TabStop = false;
            grpMateria.Text = "Datos Materia";
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(118, 119);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(193, 43);
            btnAgregarMateria.TabIndex = 4;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(207, 76);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(89, 27);
            txtCalificacion.TabIndex = 3;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(173, 33);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(235, 27);
            txtNombreMateria.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 76);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 1;
            label3.Text = "Calificacion de la materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 36);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre de la materia";
            // 
            // lstSemestres
            // 
            lstSemestres.FormattingEnabled = true;
            lstSemestres.ItemHeight = 20;
            lstSemestres.Location = new Point(513, 44);
            lstSemestres.Name = "lstSemestres";
            lstSemestres.Size = new Size(258, 244);
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
            dgtDatosMaterias.Location = new Point(30, 360);
            dgtDatosMaterias.Name = "dgtDatosMaterias";
            dgtDatosMaterias.ReadOnly = true;
            dgtDatosMaterias.RowHeadersWidth = 51;
            dgtDatosMaterias.RowTemplate.Height = 29;
            dgtDatosMaterias.Size = new Size(439, 204);
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
            grpOrden.Location = new Point(521, 347);
            grpOrden.Name = "grpOrden";
            grpOrden.Size = new Size(250, 125);
            grpOrden.TabIndex = 4;
            grpOrden.TabStop = false;
            grpOrden.Text = "Orden De La Calificacion";
            // 
            // radDescendente
            // 
            radDescendente.AutoSize = true;
            radDescendente.Location = new Point(13, 78);
            radDescendente.Name = "radDescendente";
            radDescendente.Size = new Size(116, 24);
            radDescendente.TabIndex = 1;
            radDescendente.TabStop = true;
            radDescendente.Text = "Descendente";
            radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAscendente
            // 
            radAscendente.AutoSize = true;
            radAscendente.Checked = true;
            radAscendente.Location = new Point(13, 31);
            radAscendente.Name = "radAscendente";
            radAscendente.Size = new Size(107, 24);
            radAscendente.TabIndex = 0;
            radAscendente.TabStop = true;
            radAscendente.Text = "Ascendente";
            radAscendente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSemestre
            // 
            btnEliminarSemestre.Location = new Point(522, 494);
            btnEliminarSemestre.Name = "btnEliminarSemestre";
            btnEliminarSemestre.Size = new Size(232, 29);
            btnEliminarSemestre.TabIndex = 5;
            btnEliminarSemestre.Text = "Eliminar Semestre";
            btnEliminarSemestre.UseVisualStyleBackColor = true;
            btnEliminarSemestre.Click += btnEliminarSemestre_Click;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Location = new Point(522, 535);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(232, 29);
            btnEliminarMateria.TabIndex = 6;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 631);
            Controls.Add(btnEliminarMateria);
            Controls.Add(btnEliminarSemestre);
            Controls.Add(grpOrden);
            Controls.Add(dgtDatosMaterias);
            Controls.Add(lstSemestres);
            Controls.Add(grpMateria);
            Controls.Add(grpDatosSemestre);
            Name = "Form1";
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
            ResumeLayout(false);
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
    }
}