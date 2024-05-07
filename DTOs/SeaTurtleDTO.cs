using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class SeaTurtleDTO : AAnimal, IHealable, ITransportable
    {
        public bool CalcNewGA()
        {
            return 30 >= (2 * GA + 3) - ((GA - 20) * 2) - 15;
        }
        public bool CalcNewGA(bool transportable)
        {
            return 30 >= (2 * GA + 3) - ((GA - 20) * 2) - 15;
        }
    }
}
