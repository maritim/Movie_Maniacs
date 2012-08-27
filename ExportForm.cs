using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Movie_Maniacs;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Xml;

namespace Movie_Maniacs
{
    public partial class ExportForm : Form
    {
        private int ExportOption;

        public ExportForm(int export)
        {
            InitializeComponent();

            string[] OptionsText = new string[] {"", "XML", "File"};

            ExportOption = export;

            this.Text += " to " + OptionsText[ExportOption];
        }

        public class DateComparer : IComparer
        {

            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object c, Object d)
            {
                MovieClass x = (MovieClass)c;
                MovieClass y = (MovieClass)d;

                DateTime a = new DateTime(1970,1,1);
                DateTime b = new DateTime(1970,1,1);

                if(x.Get_Date_Year() != 0)
                    a = new DateTime(x.Get_Date_Year(),x.Get_Date_Month(),x.Get_Date_Day());
                if(y.Get_Date_Year() != 0)
                    b = new DateTime(y.Get_Date_Year(),y.Get_Date_Month(),y.Get_Date_Day());

                return DateTime.Compare(a, b);
            }
        }

        private string SelectFile()
        {
            string[] ExportOptionFilter = new string[] { "", "XML file|*.xml", "Text file|*.txt" };

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = ExportOptionFilter[ExportOption];

            sfd.Title = "Export to file";
            sfd.ShowDialog();

            if (sfd.FileName != "")
                return sfd.FileName;

            return null;
        }

        private void SaveInFileXML(string fileName, List<string> movies)
        {
            try
            {
                MovieClass[] Movies = new MovieClass[movies.Count];

                int i = 0;

                foreach(string movie in movies)
                    Movies[i++] = (new MovieClass(movie));

                Array.Sort(Movies,new DateComparer());

                XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);

                writer.WriteStartDocument();

                writer.WriteStartElement("movielist");

                foreach(MovieClass Movie in Movies)
                {
                    writer.WriteStartElement("movie");
                    
                    writer.WriteStartElement("name");
                    writer.WriteString(Movie.Movie_Name);
                    writer.WriteEndElement();

                    if (YearBox.Checked == true)
                    {
                        writer.WriteStartElement("year");
                        writer.WriteString(Movie.Get_Year());
                        writer.WriteEndElement();
                    }

                    if (MarkBox.Checked == true)
                    {
                        writer.WriteStartElement("mark");
                        writer.WriteString(Movie.Get_Mark());
                        writer.WriteEndElement();
                    }

                    if (DateBox.Checked == true)
                    {
                        writer.WriteStartElement("date");
                        writer.WriteString(Movie.Get_Date_Day() + "/" + Movie.Get_Date_Month() + "/" + Movie.Get_Date_Year());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement(); //movie
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();
            }
            catch
            { 
            }
        }

        private void SaveInFile(string fileName, List<string> movies)
        {
            StreamWriter f = new StreamWriter(fileName);

            try
            {
                MovieClass[] Movies = new MovieClass[movies.Count];

                int i = 0;

                foreach(string movie in movies)
                    Movies[i++] = new MovieClass(movie);

                Array.Sort(Movies, new DateComparer());

                foreach(MovieClass Movie in Movies)
                {
                    if (NameBox.Checked == true)
                        f.Write(Movie.Movie_Name + " ");
                    if (YearBox.Checked == true)
                        f.Write("(" + Movie.Get_Year() + ") ");
                    if (MarkBox.Checked == true)
                        f.Write("- " + Movie.Get_Mark()+"/10");
                    if (DateBox.Checked == true)
                        f.Write(" (" + Movie.Get_Date_Day() + "/" + Movie.Get_Date_Month() + "/" + Movie.Get_Date_Year() + ")");

                    f.WriteLine();
                    f.WriteLine();
                }
            }
            catch
            {
                f.Close();
            }

            f.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> movies;
            string fileName;

            try
            {
                movies = DataBaseManipulation.MovieDetails("Name");

                fileName = SelectFile();
                if (fileName != null)
                {
                    if (ExportOption == 2)
                        SaveInFile(fileName, movies);
                    else if (ExportOption == 1)
                        SaveInFileXML(fileName,movies);

                    Process.Start(fileName);
                    this.Close();
                }
            }
            catch
            {
 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
