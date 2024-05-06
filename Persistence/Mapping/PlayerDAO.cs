using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using System.Xml.Linq;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping
{
    public class PlayerDAO : IPlayerDAO
    {
        private readonly string XmlPath = "../../../Files/Players.xml";
        public void SavePlayer(Player player)
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

        public void UpdatePlayer(Player player)
        {
            XDocument doc = XDocument.Load(XmlPath);
            foreach (XElement element in doc.Descendants("Player"))
            {
                if (element.Element("Name").Value == player.Name)
                {
                    element.Element("Exp").Value = player.Exp.ToString();
                }
            }
        }

        public List<Player> GetPlayers()
        {
            XDocument doc;

            if (File.Exists(XmlPath))
            {
                doc = XDocument.Load(XmlPath);
                List<Player> players = new List<Player>();
                foreach (XElement element in doc.Descendants("Player"))
                {
                    Player player = new Player(
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
                return new List<Player>();
            }
        }
    }
}
