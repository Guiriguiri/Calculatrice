using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_safronov
{
    public abstract class Calcul
    {
        public abstract decimal Calculer();
        public decimal? Operande1 { get; set; }
        public decimal? Operande2 { get; set; }

    }
}
