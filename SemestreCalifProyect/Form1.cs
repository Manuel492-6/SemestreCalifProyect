using ExamenNivelacionArchivos;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace SemestreCalifProyect
{
    public partial class FormCapturaDeCalificaciones : Form
    {
        public static string NombreArchivo = "C:\\Users\\DELL\\Desktop\\Pyts\\Proycto\\Manuel492-6\\SemestreCalifProyect\\Informacion\\I.dat";
        public static string NombreArchivoConfiguracionGuardar = "C:\\Users\\DELL\\Desktop\\Pyts\\Proycto\\Manuel492-6\\SemestreCalifProyect\\Informacion\\informacionConfiguraciones.dat";

        miArchivo<Semestre> miArchivo = new miArchivo<Semestre>(NombreArchivo);
        miArchivo<Configuraciones> miArchivoConfiguraciones = new miArchivo<Configuraciones>(NombreArchivoConfiguracionGuardar);

        private void InicializarArchivo()
        {
            if (File.Exists(NombreArchivo))
            {
                 miArchivo.HacerModoLectura();
                Semestre miSemestre = new Semestre();

                while (!miArchivo.FinArchivo)
                {
                    miSemestre = miArchivo.LeerObjeto();
                   lstSemestres.Items.Add(miSemestre);
                }
                miArchivo.CerrarArchivo();
            }
            else
            {
                miArchivo.HacerModoEscritura();
                miArchivo.CerrarArchivo();
            }

        }

        public FormCapturaDeCalificaciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNumSemestre.SelectedIndex = 0;

            InicializarArchivo();

            SemestreCalificacionTotalLabel();
       
            InicializarConfiguracion();
        }

        public delegate double Operacion();



        private void SemestreCalificacionTotalLabel()
        {
            Operacion Suma = () => { double suma = 0; foreach (Semestre miSemestre in lstSemestres.Items) { suma += miSemestre.PromedioMaterias(); } return Math.Round(suma / lstSemestres.Items.Count, 2); };

            label5.Text = (lstSemestres.Items.Count == 0) ? "" : (lstSemestres.Items.Count.ToString());
            label7.Text = (lstSemestres.Items.Count == 0) ? "" : Suma().ToString();
            label5.Visible = true;
            label7.Visible = true;

        }

        private void btnAgregarSemestre_Click(object sender, EventArgs e)
        {
            Semestre miSemestre = new Semestre();
            miSemestre.NumeroSemestre = Convert.ToInt32(cboNumSemestre.SelectedItem);

            foreach (Semestre i in lstSemestres.Items)
            {
                if (i.NumeroSemestre == miSemestre.NumeroSemestre)
                {
                    DialogResult Mensaje = MessageBox.Show("Este semestre ya esta agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            lstSemestres.Items.Add(miSemestre);
            SemestreCalificacionTotalLabel();
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
            try
            {
                miMateria.NombreMateria = txtNombreMateria.Text;
                miMateria.Calificacion = Convert.ToDouble(txtCalificacion.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Usted a escrito en otro tipo de dato en este campo", "Error");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            SemestreSeleccionado.AgregarMateria(miMateria);

            SemestreSeleccionado.OrdenEscogido((radAscendente.Checked) ? SemestreSeleccionado.Ascendente : SemestreSeleccionado.Descendente);

            limpiarCampos();

            dgtDatosMaterias.Rows.Clear();

            foreach (Materia x in SemestreSeleccionado)
            {
                dgtDatosMaterias.Rows.Add(x.NombreMateria, x.Calificacion);
            }
            dgtDatosMaterias.Rows.Add("Total", SemestreSeleccionado.PromedioMaterias());

            txtNombreMateria.Focus();

            SemestreCalificacionTotalLabel();
        }

        private void lstSemestres_Click(object sender, EventArgs e)
        {
            int Datos = 0;
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
                Datos++;
            }
            if (!(Datos == 0))
            {
                dgtDatosMaterias.Rows.Add("Total", SemestreSeleccionado.PromedioMaterias());
            }


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

            SemestreCalificacionTotalLabel();
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
            SemestreCalificacionTotalLabel();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(NombreArchivo))
                {
                    GuardarArchivoDatosSemestre();
                }
                else
                {
                    miArchivo.HacerModoEscritura();
                    miArchivo.CerrarArchivo();
                    GuardarArchivoDatosSemestre();
                }
                if (File.Exists(NombreArchivoConfiguracionGuardar))
                {
                    GuardarConfiguraciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnEliminarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Mensaje = MessageBox.Show("Deseas Eliminar este archivo?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Mensaje == DialogResult.OK)
                {
                    miArchivo.EliminarArchivo();
                    MessageBox.Show("Se ha eliminado el archivo", "Mensaje");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje");
            }


        }

        private void FormCapturaDeCalificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("Deseas salir del programa", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (Mensaje != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            GuardarConfiguraciones();
            if (chkGuarddoAutomatico.Checked)
            {
                if (File.Exists(NombreArchivo))
                {
                    GuardarArchivoDatosSemestre();
                }
                else
                {
                    miArchivo.HacerModoEscritura();
                    miArchivo.CerrarArchivo();
                    GuardarArchivoDatosSemestre();
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuardarConfiguraciones()
        {
            Configuraciones miConfiguraciones = new Configuraciones();
            miConfiguraciones.GuardadoAutomatico = (chkGuarddoAutomatico.Checked) ? true : false;
            miConfiguraciones.Orden = (radAscendente.Checked) ? 'A' : 'D';

            miArchivoConfiguraciones.EliminarArchivo();
            miArchivoConfiguraciones.HacerModoEscritura();
            miArchivoConfiguraciones.AgregarObjeto(miConfiguraciones);
            miArchivoConfiguraciones.CerrarArchivo();
        }

        private void InicializarConfiguracion()
        {
            try
            {

                if (File.Exists(NombreArchivoConfiguracionGuardar))
                {
                        Configuraciones miConfiguracion = new Configuraciones();
                        miArchivoConfiguraciones.HacerModoLectura();
                        while (!miArchivoConfiguraciones.FinArchivo)
                        {
                            miConfiguracion = miArchivoConfiguraciones.LeerObjeto();
                        }
                        chkGuarddoAutomatico.Checked = miConfiguracion.GuardadoAutomatico;
                        switch (miConfiguracion.Orden)
                        {
                            case 'A':
                                radAscendente.Checked = true;
                                break;
                            case 'D':
                                radDescendente.Checked = true;
                                break;
                        }
                    
                }
                else
                {
                    miArchivoConfiguraciones.HacerModoEscritura();
                }
            }
            catch (Exception ex) { }
            finally { miArchivoConfiguraciones.CerrarArchivo(); }
        }

        private void GuardarArchivoDatosSemestre()
        {
            miArchivo.EliminarArchivo();
            miArchivo.HacerModoEscritura();

            if (lstSemestres.Items.Count == 0) { MessageBox.Show("Usted no tiene ningun dato", "Mensaje"); miArchivo.CerrarArchivo(); return; }

            foreach (Semestre miSemestre in lstSemestres.Items)
            {
                miArchivo.AgregarObjeto(miSemestre);
            }
            DialogResult Mensaje = MessageBox.Show("Se ha guardado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            miArchivo.CerrarArchivo();


        }
    }
}