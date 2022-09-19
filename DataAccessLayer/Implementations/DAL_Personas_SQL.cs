﻿using DataAccessLayer.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class DAL_Personas_SQL : IDAL_Personas
    {
        private string sqlConnection = "Server=localhost,14330;Database=Practico3;User Id=sa;Password=Tisj*2022;";

        public Persona AddPersona(Persona x)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PERSONAS VALUES(@nombre, @documento)", connection);
                {
                    cmd.Parameters.Add(new SqlParameter("nombre", x.Nombre));
                    cmd.Parameters.Add(new SqlParameter("documento", x.Documento));
                    connection.Open();

                    int result = cmd.ExecuteNonQuery();
                }   
            }

            return x;
        }

        public Persona Get(string documento)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
