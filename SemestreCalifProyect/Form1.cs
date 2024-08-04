namespace SemestreCalifProyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNumSemestre.SelectedIndex = 0;
        }

        private void btnAgregarSemestre_Click(object sender, EventArgs e)
        {
            Semestre miSemestre = new Semestre();
            miSemestre.NumeroSemestre = Convert.ToInt32(cboNumSemestre.SelectedItem);

            foreach (Semestre i in lstSemestres.Items)
            {
                if (i.NumeroSemestre == miSemestre.NumeroSemestre)
                {
                    MessageBox.Show("Este semestre ya esta agregado", "Error");
                    return;
                }
            }
            lstSemestres.Items.Add(miSemestre);

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Semestre SemestreSeleccionado = new Semestre();
            SemestreSeleccionado = (Semestre)lstSemestres.SelectedItem;

            if (SemestreSeleccionado == null)
            {
                MessageBox.Show("No ha seleccionado ningun semestre", "Error");
                return;
            }

            Materia miMateria = new Materia();
            miMateria.NombreMateria = txtNombreMateria.Text;
            miMateria.Calificacion = Convert.ToDouble(txtCalificacion.Text);

            SemestreSeleccionado.AgregarMateria(miMateria);

            SemestreSeleccionado.OrdenEscogido((radAscendente.Checked) ? SemestreSeleccionado.Ascendente : SemestreSeleccionado.Descendente);

            limpiarCampos();

            dgtDatosMaterias.Rows.Clear();

            foreach (Materia x in SemestreSeleccionado)
            {
                dgtDatosMaterias.Rows.Add(x.NombreMateria, x.Calificacion);
            }
            dgtDatosMaterias.Rows.Add("Total", SemestreSeleccionado.PromedioMaterias());
        }

        private void lstSemestres_Click(object sender, EventArgs e)
        {
            double SumaPromedio = 0, numDatos = 0;
            Semestre SemestreSeleccionado = new Semestre();
            SemestreSeleccionado = (Semestre)lstSemestres.SelectedItem;

            if (SemestreSeleccionado == null)
            {
                MessageBox.Show("No ha seleccionado ningun semestre", "Error");
                return;
            }

            SemestreSeleccionado.OrdenEscogido((radAscendente.Checked) ? SemestreSeleccionado.Ascendente : SemestreSeleccionado.Descendente);

            dgtDatosMaterias.Rows.Clear();

            foreach (Materia x in SemestreSeleccionado)
            {
                dgtDatosMaterias.Rows.Add(x.NombreMateria, x.Calificacion);
            }
            dgtDatosMaterias.Rows.Add("Total", SemestreSeleccionado.PromedioMaterias());

        }

        private void limpiarCampos()
        {
            cboNumSemestre.SelectedIndex = 0;
            foreach (Control x in grpMateria.Controls)
                if (x is TextBox)
                    x.Text = "";
        }

        private void btnEliminarSemestre_Click(object sender, EventArgs e)
        {
            Semestre SemestreSeleccionado = new Semestre();
            SemestreSeleccionado = (Semestre)lstSemestres.SelectedItem;
            if (SemestreSeleccionado == null)
            {
                MessageBox.Show("No ha seleccionado ningun semestre", "Error");
                return;
            }


            DialogResult Respuesta = MessageBox.Show($"Desea eliminar el semestre {SemestreSeleccionado.NumeroSemestre}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                lstSemestres.Items.Remove(SemestreSeleccionado);
                MessageBox.Show("Se ha Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Se ha cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            Semestre SemestreSeleccionado = new Semestre();
            SemestreSeleccionado = (Semestre)lstSemestres.SelectedItem;
            if (dgtDatosMaterias.CurrentRow != null)
            {
                DataGridViewRow FilaSeleccionada = dgtDatosMaterias.CurrentRow;
                Materia MateriaEliminar = new Materia();
                MateriaEliminar.Calificacion = Convert.ToDouble(FilaSeleccionada.Cells["Calificacion"].Value);
                MateriaEliminar.NombreMateria = FilaSeleccionada.Cells["Nombre"].Value.ToString();
                SemestreSeleccionado.EliminarMateria(MateriaEliminar);
                MessageBox.Show("Se ha eliminado la materia");

                dgtDatosMaterias.Rows.Clear();
                foreach (Materia unaMateria in SemestreSeleccionado)
                {
                    dgtDatosMaterias.Rows.Add(unaMateria.NombreMateria, unaMateria.Calificacion);
                }
            }
            else
            {
                MessageBox.Show("Usted no ha seleccionado ninguna materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}