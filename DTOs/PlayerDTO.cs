using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs
{
    public class PlayerDTO
    {
        public string? Name { get; set; }
        public string? Occupation { get; set; }
        public int Exp { get; set; }
        public PlayerDTO(string name, string occupation, int exp)
        {
            Name = name;
            Occupation = occupation;
            Exp = exp;
        }
        public PlayerDTO()
        {
        }
    }
}
