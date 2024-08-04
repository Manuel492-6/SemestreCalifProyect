using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestreCalifProyect
{
	internal class Semestre
	{
		private int _intNumeroSemestre;

		public int NumeroSemestre
		{
			get { return _intNumeroSemestre; }
			set { _intNumeroSemestre = value; }
		}

		List<Materia> _ListaMaterias = new List<Materia>();

		~Semestre()
		{
			_ListaMaterias.Clear();
		}

		public IEnumerator<Materia> GetEnumerator()
		{
			return _ListaMaterias.GetEnumerator();
		}

		public void AgregarMateria(Materia unaMateria)
		{
			_ListaMaterias.Add(unaMateria);
		}

		public override string ToString()
		{
			return this.NumeroSemestre.ToString();
		}

		public delegate void Orden();

		public void OrdenEscogido(Orden miOrden)
		{
			miOrden();
		}

		public void Ascendente()
		{
			_ListaMaterias.Sort();
		}

		public void Descendente()
		{
			_ListaMaterias.Sort(delegate (Materia Materia1, Materia Materia2)  { return Materia2.CompareTo(Materia1);	});
		}

		public void EliminarMateria(Materia MateriaEliminar)
		{
			_ListaMaterias.Remove(MateriaEliminar);
		}
		
		public double PromedioMaterias()
		{
			double Suma = 0;
			foreach(Materia x in _ListaMaterias)
			{
				Suma += x.Calificacion;
			}
			return Math.Round(Suma / _ListaMaterias.Count,2);
		}

    }
}
