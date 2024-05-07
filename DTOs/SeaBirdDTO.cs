using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class SeaBirdDTO : AAnimal, IHealable, ITransportable
    {
        public bool CalcNewGA()
        {
            return 30 >= (GA - 5) / 5;
        }
        public bool CalcNewGA(bool transportable)
        {
            return 30 >= (GA - 0) / 5;
        }
    }
}
