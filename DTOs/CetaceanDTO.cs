using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class CetaceanDTO : AAnimal, IHealable
    {
        public bool CalcNewGA()
        {
            return 30 >= GA - (GA / 5) - 50;
        }
    }
}
