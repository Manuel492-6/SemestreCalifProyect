using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestreCalifProyect
{
    internal class Materia:IComparable<Materia>,IEquatable<Materia>
    {
		private string _strNombreMateria;

		public string NombreMateria
		{
			get { return _strNombreMateria; }
			set { _strNombreMateria = value; }
		}

		private double _dblCalificacion;

		public double Calificacion
		{
			get { return _dblCalificacion; }
			set { _dblCalificacion = value; }
		}

		public int CompareTo(Materia otraMateria)
		{
			return this.Calificacion.CompareTo(otraMateria.Calificacion);
		}

		public bool Equals(Materia otraMateria)
		{
			return this.Calificacion.Equals(otraMateria.Calificacion);
		}



	}
}
