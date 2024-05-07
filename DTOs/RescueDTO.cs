using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class RescueDTO
    {
        public int Id { get; set; }
        public string? NumRescue { get; set; }
        public DateTime? Date { get; set; }
        public string? SuperFamily { get; set; }
        public string? Location { get; set; }
        public int AnimalId { get; set; }
        public static string GenerateNumRescue()
        {
            Random random = new Random();
            return "RES" + random.Next(10) + random.Next(10) + random.Next(10);
        }
    }
}
