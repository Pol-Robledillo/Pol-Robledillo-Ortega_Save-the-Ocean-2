using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Npgsql;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping
{
    public class CetaceanDAO : ICetaceanDAO
    {
        private readonly string connectionString;
        public CetaceanDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddCetacean(CetaceanDTO cetacean)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso) VALUES (@nombre, @super_familia, @especie, @grado_aceptacion, @peso)", connection))
                {
                    command.Parameters.AddWithValue("nombre", cetacean.Name);
                    command.Parameters.AddWithValue("super_familia", cetacean.SuperFamily);
                    command.Parameters.AddWithValue("especie", cetacean.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", cetacean.GA);
                    command.Parameters.AddWithValue("peso", cetacean.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCetacean(CetaceanDTO cetacean)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("DELETE FROM animal WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", cetacean.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public CetaceanDTO GetCetaceanById(int id)
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
                            return new CetaceanDTO
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

        public List<CetaceanDTO> GetCetaceans()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM animal", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<CetaceanDTO> cetaceans = new List<CetaceanDTO>();
                        while (reader.Read())
                        {
                            cetaceans.Add(new CetaceanDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                SuperFamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                GA = reader.GetInt32(4),
                                Weight = reader.GetDouble(5)
                            });
                        }
                        return cetaceans;
                    }
                }
            }
        }

        public void UpdateCetacean(CetaceanDTO cetacean)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE animal SET nombre = @nombre, super_familia = @super_familia, especie = @especie, grado_aceptacion = @grado_aceptacion, peso = @peso WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", cetacean.Id);
                    command.Parameters.AddWithValue("nombre", cetacean.Name);
                    command.Parameters.AddWithValue("super_familia", cetacean.SuperFamily);
                    command.Parameters.AddWithValue("especie", cetacean.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", cetacean.GA);
                    command.Parameters.AddWithValue("peso", cetacean.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
