using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestreCalifProyect
{
    [Serializable]
    internal class Configuraciones
    {
		private bool blnGuardadoAutomatico;

		public bool GuardadoAutomatico
		{
			get { return blnGuardadoAutomatico; }
			set { blnGuardadoAutomatico = value; }
		}

		private char blnOrden;

		public char Orden
		{
			get { return blnOrden; }
			set { blnOrden = value; }
		}

	}
}
