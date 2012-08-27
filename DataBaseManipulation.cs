using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Movie_Maniacs;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace Movie_Maniacs
{
    class DataBaseManipulation
    {
        static public OleDbConnection DBCon = new OleDbConnection();

        static public int InsertMovie(MovieClass Movie)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Directory.GetCurrentDirectory()+"\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                new OleDbCommand("INSERT INTO Movies ([Name]) VALUES('Google.txt')", DBCon).ExecuteNonQuery();

                OleDbDataReader reader = MovieDBReader("Google.txt");

                reader.Read();

                UpdateMovie(Movie, int.Parse(reader["Index"].ToString()));

                /*string command = "INSERT INTO Movies VALUES(";
                command += (int.Parse(reader["Index"].ToString())+1).ToString();
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Movie_Name) + "'";
                command += ",'" + Movie.Get_Year() + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Get_Mark()) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Adress()) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Month().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Day().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Year().ToString()) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Get_Review()) + "'";
                command += ",'" + Movie.Runtime + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Name()) + "'";
                command += ",'" + Movie.Get_IMDB_Mark() + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Director) + "'";
                command += ",'" + Movie.DirectorLink + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Genre())) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Stars())) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_StarsLink())) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Genre())) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Tags())) + "'";
                command += ",'" + WorkerClass.ListToString(Movie.Get_Language()) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.Storyline) + "'";
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.MovieTrailer) + "'";
                command += "," + (Movie.Default ? 1 : 0).ToString();
                command += ",'" + WorkerClass.StringWithoutApostrophe(Movie.MPAA_Rating) + "')";
                OleDbCommand DBCom = new OleDbCommand(command, DBCon);
                //OleDbDataReader reader =  DBCom.ExecuteReader();

                DBCom.ExecuteNonQuery();

                //MessageBox.Show(Movie.Movie_Name + " Successfully Updated!", "Updated");

                //for (; reader.Read(); )
                //MessageBox.Show("Command : " + reader["Name"].ToString() + " was executed !!!", "Executed");
                return 1;*/

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        static public OleDbDataReader MovieDBReader(string Movie_Name)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                string command = "SELECT * FROM Movies WHERE Name='" + WorkerClass.StringWithoutApostrophe(Movie_Name) + "'";

                OleDbCommand DBCom = new OleDbCommand(command, DBCon);
                OleDbDataReader reader = DBCom.ExecuteReader();

                return reader;
            }
            catch
            {
                return null;
            }
        }

        static public void UpdateMovie(MovieClass Movie)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                OleDbDataReader reader = MovieDBReader(WorkerClass.StringWithoutApostrophe(Movie.Movie_Name)+"");

                reader.Read();

                string command = "UPDATE Movies SET ";
                command += "Name = '" + WorkerClass.StringWithoutApostrophe(Movie.Movie_Name) + "',";
                command += "[Year] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Year()) + "',";
                command += "[Mark] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Mark()) + "',";
                command += " IMDb_Adress = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Adress()) + "',";
                command += " [Date] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Month().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Day().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Year().ToString()) + "',";
                command += " [Review] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Review()) + "',";
                command += " RunTime = '" + Movie.Runtime + "',";
                command += " IMDb_Name = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Name()) + "',";
                command += " IMDb_Mark = '" + Movie.Get_IMDB_Mark() + "',";
                command += " DirectorName = '" + WorkerClass.StringWithoutApostrophe(Movie.Director) + "',";
                command += " DirectorWebLink = '" + Movie.DirectorLink + "',";
                command += " [Country] = '" + WorkerClass.StringWithApostrophe(WorkerClass.ListToString(Movie.Get_Country())) + "',";
                command += " Stars = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Stars())) + "',";
                command += " StarsLink = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_StarsLink())) + "',";
                command += " Genres = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Genre())) + "',";
                command += " [Language] = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Language())) + "',";
                command += " Tags = '" + WorkerClass.StringWithApostrophe(WorkerClass.ListToString(Movie.Get_Tags())) + "',";
                command += " StoryLine = '" + WorkerClass.StringWithoutApostrophe(Movie.Storyline) + "',";
                command += " TrailerMovie = '" + WorkerClass.StringWithoutApostrophe(Movie.MovieTrailer) + "',";
                command += " DefaultMovie = " + (Movie.Default ? 1 : 0).ToString() + ",";
                command += " MPAA = '" + WorkerClass.StringWithoutApostrophe(Movie.MPAA_Rating) + "',";
                command += " Prizes = '" + WorkerClass.StringWithoutApostrophe(Movie.Prize) + "'";
                command += " WHERE Index = " + reader["Index"].ToString();

                OleDbCommand DBCom = new OleDbCommand(command, DBCon);
                DBCom.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(Movie.Movie_Name + " dsa das " + ex.ToString(), ex.ToString());
            }
        }

        static public void UpdateMovie(MovieClass Movie,int LastIndex)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                string command = "UPDATE Movies SET ";
                command += "Name = '" + WorkerClass.StringWithoutApostrophe(Movie.Movie_Name) + "',";
                command += "[Year] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Year()) + "',";
                command += "[Mark] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Mark()) + "',";
                command += " IMDb_Adress = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Adress()) + "',";
                command += " [Date] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Month().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Day().ToString()) + "/" + WorkerClass.StringWithoutApostrophe(Movie.Get_Date_Year().ToString()) + "',";
                command += " [Review] = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_Review()) + "',";
                command += " RunTime = '" + Movie.Runtime + "',";
                command += " IMDb_Name = '" + WorkerClass.StringWithoutApostrophe(Movie.Get_IMDB_Name()) + "',";
                command += " IMDb_Mark = '" + Movie.Get_IMDB_Mark() + "',";
                command += " DirectorName = '" + WorkerClass.StringWithoutApostrophe(Movie.Director) + "',";
                command += " DirectorWebLink = '" + Movie.DirectorLink + "',";
                command += " [Country] = '" + WorkerClass.StringWithApostrophe(WorkerClass.ListToString(Movie.Get_Country())) + "',";
                command += " Stars = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Stars())) + "',";
                command += " StarsLink = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_StarsLink())) + "',";
                command += " Genres = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Genre())) + "',";
                command += " [Language] = '" + WorkerClass.StringWithoutApostrophe(WorkerClass.ListToString(Movie.Get_Language())) + "',";
                command += " Tags = '" + WorkerClass.StringWithApostrophe(WorkerClass.ListToString(Movie.Get_Tags())) + "',";
                command += " StoryLine = '" + WorkerClass.StringWithoutApostrophe(Movie.Storyline) + "',";
                command += " TrailerMovie = '" + WorkerClass.StringWithoutApostrophe(Movie.MovieTrailer) + "',";
                command += " DefaultMovie = " + (Movie.Default ? 1 : 0).ToString() + ",";
                command += " MPAA = '" + WorkerClass.StringWithoutApostrophe(Movie.MPAA_Rating) + "',";
                command += " Prizes = '" + WorkerClass.StringWithoutApostrophe(Movie.Prize) + "'";
                command += " WHERE Index = " + LastIndex;

                OleDbCommand DBCom = new OleDbCommand(command, DBCon);
                DBCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool ExistMovie(string Movie_Name)
        {
            try
            {
                OleDbDataReader reader = MovieDBReader(WorkerClass.StringWithoutApostrophe(Movie_Name));

                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        static public List<string> MovieDetails(string MovieInfo)
        {
            if (DBCon.ConnectionString == "")
            {
                DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                DBCon.Open();
            }

            string command = "SELECT " + MovieInfo + " FROM Movies";

            OleDbCommand DBCom = new OleDbCommand(command, DBCon);
            OleDbDataReader reader = DBCom.ExecuteReader();

            List<string> Details = new List<string>();

            for (; reader.Read(); )
                Details.Add(WorkerClass.StringWithApostrophe(reader[MovieInfo].ToString()));

            return Details;
        }

        static public int DeleteMovieFromDB(string Name)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                OleDbCommand DBCom = new OleDbCommand("DELETE FROM Movies WHERE Name='"+WorkerClass.StringWithoutApostrophe(Name)+"'",DBCon);

                DBCom.ExecuteNonQuery();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        static public int DeleteMovieFromDB(int Index)
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                OleDbCommand DBCom = new OleDbCommand("DELETE FROM Movies WHERE Index = " + Index, DBCon);

                DBCom.ExecuteNonQuery();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        static public MovieClass DefaultMovie()
        {
            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                OleDbCommand DBCom = new OleDbCommand("SELECT Name FROM Movies WHERE DefaultMovie = 1", DBCon);

                OleDbDataReader reader = DBCom.ExecuteReader();

                reader.Read();

                return new MovieClass(reader["Name"].ToString());
            }
            catch
            {
                return new MovieClass();
            }
        }

        static public int Update_General(string Command)
        {
            //Use it carefully

            try
            {
                if (DBCon.ConnectionString == "")
                {
                    DBCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Movies.mdb;User Id=Admin;Password=;";
                    DBCon.Open();
                }

                OleDbCommand DBCom = new OleDbCommand("UPDATE Movies SET " + Command,DBCon);

                DBCom.ExecuteNonQuery();

                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0 ;
            }
        }
    }
}
