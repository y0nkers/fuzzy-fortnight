using System;
using System.Data;
using System.Data.SqlClient;

namespace RGR
{
    class Constellation
    {
        private static readonly string _selectConstellation = @"SELECT [LatinTitle] FROM [dbo].[Constellations] WHERE [LatinTitle] = @LatinTitle";
        private static readonly string _insertConstellation = @"INSERT INTO [dbo].[Constellations] ([RussianTitle], [LatinTitle], [Abbreviation], [Area], [Brigther6m], [Photo]) VALUES (@RussianTitle, @LatinTitle, @Abbreviation, @Area, @Brigther6m, @Photo)";

        public int Id { get; set; }
        public string RussianTitle { get; set; }
        public string LatinTitle { get; set; }
        public string Abbreviation { get; set; }
        public int Area { get; set; }
        public int Brigther6m { get; set; }
        public byte[] Photo { get; set; }


        public static string Select(SqlConnection connection, String latinTitle)
        {
            String Title = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectConstellation;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@LatinTitle", SqlDbType.NVarChar, 32).Value = latinTitle;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Title = (string)reader["LatinTitle"];
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return Title;
        }
        public static void Insert(SqlConnection connection, Constellation constellation)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertConstellation;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@RussianTitle", SqlDbType.NVarChar, 32).Value = constellation.RussianTitle;
                    command.Parameters.Add("@LatinTitle", SqlDbType.NVarChar, 32).Value = constellation.LatinTitle;
                    command.Parameters.Add("@Abbreviation", SqlDbType.NVarChar, 4).Value = constellation.Abbreviation;
                    command.Parameters.Add("@Area", SqlDbType.Int).Value = constellation.Area;
                    command.Parameters.Add("@Brigther6m", SqlDbType.Int).Value = constellation.Brigther6m;
                    command.Parameters.Add("@Photo", SqlDbType.Image).Value = constellation.Photo ?? Convert.DBNull;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}