using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_safronov
{
    public class RacineCarre : Calcul
    {
        public override decimal Calculer()
        {
            decimal Resultat;
            Resultat = (decimal)Math.Sqrt((double) Operande1);
            return Resultat;
        }
    }
}
