using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_safronov
{
    public class Carre : Calcul
    {
        public override decimal Calculer()
        {
            decimal Resultat;
            Resultat = (decimal)Math.Pow((double)Operande1, (double)Operande2);
            return Resultat;
        }
    }
}
