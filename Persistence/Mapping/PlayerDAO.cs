using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using System.Xml.Linq;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping
{
    public class PlayerDAO : IPlayerDAO
    {
        private readonly string XmlPath = "../../../Files/Players.xml";
        public void SavePlayer(PlayerDTO player)
        {
            const string ErrorMsg = "An error occurred: {0}";
            try
            {
                XDocument doc;

                if (File.Exists(XmlPath))
                {
                    doc = XDocument.Load(XmlPath);

                    if (doc.Root == null)
                    {
                        doc.Add(new XElement("Players"));
                    }
                }
                else
                {
                    doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("Players"));
                }
                XElement newPlayer =
                    new XElement("Player",
                    new XElement("Name", player.Name),
                    new XElement("Occupation", player.Occupation),
                    new XElement("Exp", player.Exp)
                    );
                doc.Root?.Add(newPlayer);
                doc.Save(XmlPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ErrorMsg, ex.Message);
            }
        }

        public void UpdatePlayer(PlayerDTO player)
        {
            XDocument doc = XDocument.Load(XmlPath);

            XElement playerToUpdate = doc.Descendants("Player").FirstOrDefault(x => x.Element("Name").Value == player.Name);
            if (playerToUpdate != null)
            {
                playerToUpdate.Element("Occupation").Value = player.Occupation;
                playerToUpdate.Element("Exp").Value = player.Exp.ToString();
            }
            doc.Save(XmlPath);
        }

        public List<PlayerDTO> GetPlayers()
        {
            XDocument doc;

            if (File.Exists(XmlPath))
            {
                doc = XDocument.Load(XmlPath);
                List<PlayerDTO> players = new List<PlayerDTO>();
                foreach (XElement element in doc.Descendants("Player"))
                {
                    PlayerDTO player = new PlayerDTO(
                        element.Element("Name").Value,
                        element.Element("Occupation").Value,
                        int.Parse(element.Element("Exp").Value)
                        );
                    players.Add(player);
                }
                return players;
            }
            else
            {
                return new List<PlayerDTO>();
            }
        }
    }
}
