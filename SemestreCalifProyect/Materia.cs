using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestreCalifProyect
{
	[Serializable]
    internal class Materia:IComparable<Materia>,IEquatable<Materia>
    {
		private string _strNombreMateria;

		public string NombreMateria
		{
			get { return _strNombreMateria; }
			set 
			{
				if(value == "")
				{
					throw new Exception("No ha escrito nada en este campo");
				}
				else
				{
					_strNombreMateria = value;	
				}
				
			}
		}

		private double _dblCalificacion;

		public double Calificacion
		{
			get { return _dblCalificacion; }
			set
			{
				if (value < 0)
				{
					throw new Exception("No se permite valores menor a 0 en la calificacion");
				}
				else
				{
					_dblCalificacion = value;
				}

			}
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
