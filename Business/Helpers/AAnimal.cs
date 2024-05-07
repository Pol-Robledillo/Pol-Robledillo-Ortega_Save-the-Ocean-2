using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers
{
    public abstract class AAnimal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SuperFamily { get; set; }
        public string? Species { get; set; }
        public int GA { get; set; }
        public double? Weight { get; set; }
    }
}
