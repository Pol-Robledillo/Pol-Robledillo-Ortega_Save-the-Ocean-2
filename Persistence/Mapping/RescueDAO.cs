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
    public class RescueDAO : IRescueDAO
    {
        private readonly string connectionString;
        public RescueDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddRescue(RescueDTO rescue)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id) VALUES (@num_rescate, @fecha, @super_familia, @localizacion, @animal_id)", connection))
                {
                    command.Parameters.AddWithValue("num_rescate", rescue.NumRescue);
                    command.Parameters.AddWithValue("fecha", rescue.Date);
                    command.Parameters.AddWithValue("super_familia", rescue.SuperFamily);
                    command.Parameters.AddWithValue("localizacion", rescue.Location);
                    command.Parameters.AddWithValue("animal_id", rescue.AnimalId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRescue(RescueDTO rescue)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("DELETE FROM rescat WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", rescue.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public RescueDTO GetRescueById(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM rescat WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RescueDTO
                            {
                                Id = reader.GetInt32(0),
                                NumRescue = reader.GetString(1),
                                Date = reader.GetDateTime(2),
                                SuperFamily = reader.GetString(3),
                                Location = reader.GetString(4),
                                AnimalId = reader.GetInt32(5)
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public List<RescueDTO> GetRescues()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM rescat", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<RescueDTO> rescues = new List<RescueDTO>();
                        while (reader.Read())
                        {
                            rescues.Add(new RescueDTO
                            {
                                Id = reader.GetInt32(0),
                                NumRescue = reader.GetString(1),
                                Date = (DateTime)reader["fecha"],
                                SuperFamily = reader.GetString(3),
                                Location = reader.GetString(4),
                                AnimalId = reader.GetInt32(5)
                            });
                        }
                        return rescues;
                    }
                }
            }
        }

        public void UpdateRescue(RescueDTO rescue)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE rescat SET num_rescate = @num_rescate, fecha = @fecha, localizacion = @localizacion, super_familia = @super_familia, animal_id = @animal_id WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("num_rescate", rescue.NumRescue);
                    command.Parameters.AddWithValue("fecha", rescue.Date);
                    command.Parameters.AddWithValue("super_familia", rescue.SuperFamily);
                    command.Parameters.AddWithValue("localizacion", rescue.Location);
                    command.Parameters.AddWithValue("animal_id", rescue.AnimalId);
                    command.Parameters.AddWithValue("id", rescue.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
