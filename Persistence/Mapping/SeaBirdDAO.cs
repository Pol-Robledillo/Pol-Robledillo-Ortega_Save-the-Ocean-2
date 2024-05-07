using Npgsql;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping
{
    public class SeaBirdDAO : ISeaBirdDAO
    {
        private readonly string connectionString;
        public SeaBirdDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddSeaBird(SeaBirdDTO seaBird)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso) VALUES (@nombre, @super_familia, @especie, @grado_aceptacion, @peso)", connection))
                {
                    command.Parameters.AddWithValue("nombre", seaBird.Name);
                    command.Parameters.AddWithValue("super_familia", seaBird.SuperFamily);
                    command.Parameters.AddWithValue("especie", seaBird.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", seaBird.GA);
                    command.Parameters.AddWithValue("peso", seaBird.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSeaBird(SeaBirdDTO seaBird)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("DELETE FROM animal WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", seaBird.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public SeaBirdDTO GetSeaBirdById(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM animal WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SeaBirdDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                SuperFamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                GA = reader.GetInt32(4),
                                Weight = reader.GetDouble(5)
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public List<SeaBirdDTO> GetSeaBirds()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM animal", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<SeaBirdDTO> seaBirds = new List<SeaBirdDTO>();
                        while (reader.Read())
                        {
                            seaBirds.Add(new SeaBirdDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                SuperFamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                GA = reader.GetInt32(4),
                                Weight = reader.GetDouble(5)
                            });
                        }
                        return seaBirds;
                    }
                }
            }
        }

        public void UpdateSeaBird(SeaBirdDTO seaBird)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE animal SET nombre = @nombre, super_familia = @super_familia, especie = @especie, grado_aceptacion = @grado_aceptacion, peso = @peso WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", seaBird.Id);
                    command.Parameters.AddWithValue("nombre", seaBird.Name);
                    command.Parameters.AddWithValue("super_familia", seaBird.SuperFamily);
                    command.Parameters.AddWithValue("especie", seaBird.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", seaBird.GA);
                    command.Parameters.AddWithValue("peso", seaBird.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
