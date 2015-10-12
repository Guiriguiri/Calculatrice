using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_safronov
{
    class Diviser : Calcul
    {
        public override decimal Calculer()
        {
            return this.Operande1.Value / this.Operande2.Value;
        }
    }
}
