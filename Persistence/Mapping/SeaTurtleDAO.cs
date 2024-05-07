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
    public class SeaTurtleDAO : ISeaTurtleDAO
    {
        private readonly string connectionString;
        public SeaTurtleDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddSeaTurtle(SeaTurtleDTO seaTurtle)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso) VALUES (@nombre, @super_familia, @especie, @grado_aceptacion, @peso)", connection))
                {
                    command.Parameters.AddWithValue("nombre", seaTurtle.Name);
                    command.Parameters.AddWithValue("super_familia", seaTurtle.SuperFamily);
                    command.Parameters.AddWithValue("especie", seaTurtle.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", seaTurtle.GA);
                    command.Parameters.AddWithValue("peso", seaTurtle.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSeaTurtle(SeaTurtleDTO seaTurtle)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("DELETE FROM animal WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", seaTurtle.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public SeaTurtleDTO GetSeaTurtleById(int id)
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
                            return new SeaTurtleDTO
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

        public List<SeaTurtleDTO> GetSeaTurtles()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM animal", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<SeaTurtleDTO> seaTurtles = new List<SeaTurtleDTO>();
                        while (reader.Read())
                        {
                            seaTurtles.Add(new SeaTurtleDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                SuperFamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                GA = reader.GetInt32(4),
                                Weight = reader.GetDouble(5)
                            });
                        }
                        return seaTurtles;
                    }
                }
            }
        }

        public void UpdateSeaTurtle(SeaTurtleDTO seaTurtle)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE animal SET nombre = @nombre, super_familia = @super_familia, especie = @especie, grado_aceptacion = @grado_aceptacion, peso = @peso WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", seaTurtle.Id);
                    command.Parameters.AddWithValue("nombre", seaTurtle.Name);
                    command.Parameters.AddWithValue("super_familia", seaTurtle.SuperFamily);
                    command.Parameters.AddWithValue("especie", seaTurtle.Species);
                    command.Parameters.AddWithValue("grado_aceptacion", seaTurtle.GA);
                    command.Parameters.AddWithValue("peso", seaTurtle.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
