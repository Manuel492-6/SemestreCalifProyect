using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNivelacionArchivos
{
    public delegate void Operacion();
    public delegate void NotificarCreacionEventHandler(Operacion miOperacion);
    internal class miArchivo<Tipo>
    {
        public event NotificarCreacionEventHandler NotificarCreacion;

        private string _strNombreArchivo;

        public string NombreArchivo
        {
            get { return _strNombreArchivo; }
            set { _strNombreArchivo = value; }
        }

        public bool FinArchivo
        {
            get
            {
                if (Flujo.Position >= Flujo.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        FileStream Flujo;
        BinaryFormatter Serializable = new BinaryFormatter();

        private void Crear()
        {
            this.Flujo = new FileStream(NombreArchivo, FileMode.Create);
        }

        public miArchivo(string strArchivo)
        {
            this.NombreArchivo = strArchivo;
        }

        ~miArchivo()
        {
            if (Flujo != null)
            {
                Flujo.Close();
            }
        }

        public void HacerModoEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                Flujo = new FileStream(NombreArchivo, FileMode.Append);
            }
            else
            {
                Crear();
            }


        }

        public void HacerModoLectura()
        {
            if (File.Exists(NombreArchivo))
            {
                Flujo = new FileStream(NombreArchivo, FileMode.Open);
            }
            else
            {
                //this.NotificarCreacion(Crear);
                Crear();
                
            }

        }

        public void AgregarObjeto(Tipo Objeto)
        {
            Serializable.Serialize(Flujo, Objeto);
        }

        public Tipo LeerObjeto()
        {
            return (Tipo)Serializable.Deserialize(Flujo);
        }
        public void CerrarArchivo()
        {
            if (Flujo != null)
            {
                Flujo.Close();
            }
        }
        public void EliminarArchivo()
        {
            if (Flujo != null)
            {
                File.Delete(NombreArchivo);
            }
            else
            {
                throw new Exception("No se puede eliminar porque no existe");
            }
        }

    }

}
