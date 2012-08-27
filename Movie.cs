using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;

namespace Movie_Maniacs
{
    public class MovieClass
    {
        private string Name = null;
        private string Year;
        private string Mark;
        private string IMDB_Adress;
        private int DateDay;
        private int DateMonth;
        private int DateYear;
        private string Review;
        private string budget;
        private string RunTime;
        private string IMDB_Name;
        private string IMDB_Mark;
        private string DirectorName;
        private string DirectorWebLink;
        private List<string> Stars = new List<string>();
        private List<string> StarsLink = new List<string>();
        private List<string> Genres = new List<string>();
        private List<string> Country = new List<string>();
        private List<string> Language = new List<string>();
        private List<string> Tags = new List<string>();
        private string StoryLine;
        private string TrailerMovie;
        private string Prizes;
        private bool DefaultMovie;
        private string MPAA;
        private bool Dynamic;
        private int IndexInDatabase;

        public MovieClass()
        {
        }

        public MovieClass(bool isdynamic)
        {
            Dynamic = isdynamic;
        }

        public MovieClass(string Name_Movie)
        {
            try
            {
                Name_Movie = WorkerClass.StringWithoutApostrophe(Name_Movie);

                OleDbDataReader reader = DataBaseManipulation.MovieDBReader(Name_Movie);
                reader.Read();

                IndexInDatabase = int.Parse(reader["Index"].ToString());
                Name = WorkerClass.StringWithApostrophe(reader["Name"].ToString());
                Year = WorkerClass.StringWithApostrophe(reader["Year"].ToString());
                Mark = WorkerClass.StringWithApostrophe(reader["Mark"].ToString());
                IMDB_Adress = WorkerClass.StringWithApostrophe(reader["IMDb_Adress"].ToString());
                Review = WorkerClass.StringWithApostrophe(reader["Review"].ToString());

                DateTime Date = new DateTime();

                try
                {
                    Date = DateTime.Parse(reader["Date"].ToString());
                    DateDay = Date.Day;
                    DateMonth = Date.Month;
                    DateYear = Date.Year;
                }
                catch
                {
                    DateDay = DateMonth = DateYear = 0;
                }


                TrailerMovie = WorkerClass.StringWithApostrophe(reader["TrailerMovie"].ToString());

                IMDB_Name = WorkerClass.StringWithApostrophe(reader["IMDb_Name"].ToString());
                IMDB_Mark = WorkerClass.StringWithApostrophe(reader["IMDb_Mark"].ToString());
                DirectorName = WorkerClass.StringWithApostrophe(reader["DirectorName"].ToString());
                DirectorWebLink = WorkerClass.StringWithApostrophe(reader["DirectorWebLink"].ToString());
                StoryLine = WorkerClass.StringWithApostrophe(reader["StoryLine"].ToString());
                RunTime = WorkerClass.StringWithApostrophe(reader["RunTime"].ToString());

                Genres = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["Genres"].ToString()));

                Country = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["Country"].ToString()));

                Language = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["Language"].ToString()));

                Stars = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["Stars"].ToString()));

                StarsLink = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["StarsLink"].ToString()));

                Tags = WorkerClass.StringToList(WorkerClass.StringWithApostrophe(reader["Tags"].ToString()));

                MPAA = WorkerClass.StringWithApostrophe(reader["MPAA"].ToString());

                Prizes = WorkerClass.StringWithApostrophe(reader["Prizes"].ToString());
            }
            catch 
            {
                return;
            }
        }

        public string Movie_Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string Get_Year()
        {
            return Year;
        }

        public string Get_Mark()
        {
            return Mark;
        }

        public string Get_IMDB_Adress()
        {
            return IMDB_Adress;
        }

        public int Get_Date_Day()
        {
            return DateDay;
        }

        public int Get_Date_Month()
        {
            return DateMonth;
        }

        public int Get_Date_Year()
        {
            return DateYear;
        }

        public string Get_Review()
        {
            return Review;
        }

        public string Get_IMDB_Name()
        {
            return IMDB_Name;
        }

        public string Get_IMDB_Mark()
        {
            return IMDB_Mark;
        }

        public void Set_IMDB_Name(string New_IMDB_Name)
        {
            IMDB_Name = New_IMDB_Name;
        }

        public void Set_Year(string New_Year)
        {
            Year = New_Year;
        }

        public void Set_IMDB_Mark(string New_IMDB_Mark)
        {
            IMDB_Mark = New_IMDB_Mark;
        }

        public List<string> Get_Stars()
        {
            return Stars;
        }

        public void Set_Star(string Star, int index)
        {
            Stars[index] = Star;
        }

        public void Set_Date(string New_Day, string New_Month, string New_Year)
        {
            try
            {
                DateDay = int.Parse(New_Day);
                DateMonth = int.Parse(New_Month);
                DateYear = int.Parse(New_Year);
            }
            catch
            {
                DateDay = DateMonth = DateYear = 0;
            }
        }

        public void Set_IMDB_Adress(string link)
        {
            IMDB_Adress = link;
            if (IMDB_Adress.IndexOf("http://") < 0)
                IMDB_Adress = "http://" + IMDB_Adress;
        }

        public void Set_Mark(string mark)
        {
            Mark = mark;
        }

        public List<string> Get_StarsLink()
        {
            return StarsLink;
        }

        public string Get_StarsLink(int index)
        {
            if(StarsLink.Count-1 >= index)
                return StarsLink[index];

            return "Unknown";
        }

        public void Set_StarsLink(string[] new_StarsLink)
        {
            for (int i = 0; i <= 4; i++)
                StarsLink[i] = new_StarsLink[i];
        }

        public void Set_StarsLink(string New_Star, int index)
        {
            StarsLink[index] = New_Star;
        }

        public void Set_Review(string New_Review)
        {
            Review = New_Review.Replace("\r","\\r").Replace("\n","\\n");
        }

        public int ActorDetailsNumber
        {
            get
            {
                return Stars.Count;
            }
        }

        public string Director
        {
            get
            {
                return DirectorName;
            }

            set
            {
                DirectorName = value;
            }
        }

        public string Storyline
        {
            get
            {
                return StoryLine;
            }

            set
            {
                StoryLine = value;
            }
        }

        public int GenreNumber
        {
            get
            {
                return Genres.Count;
            }
        }

        public List<string> Get_Genre()
        {
            return Genres;
        }

        public string Get_Genre(int index)
        {
            if(Genres.Count-1 >= index)
                return Genres[index];

            return "Unknown";
        }

        public string Budget
        {
            get
            {
                return budget;
            }

            set
            {
                budget = value;
            }
        }

        public string Runtime
        {
            get
            {
                return RunTime;
            }

            set
            {
                RunTime = value;
            }
        }

        public string Get_Star(int index)
        {
            if(Stars.Count-1 >= index)
                return Stars[index];

            return "Unknown";
        }

        public int CountryNumber
        {
            get
            {
                return Country.Count;
            }
        }

        public void Set_Country(string country, int index)
        {
            Country[index] = country;
        }

        public void Set_Country(List<string> country)
        {
            Country = country;
        }

        public List<string> Get_Country()
        {
            return Country;
        }

        public string Get_Country(int index)
        {
            if(Country.Count-1 >= index)
                return Country[index];

            return "Unknown";
        }

        public int LanguageNumber
        {
            get
            {
                return Language.Count;
            }
        }

        public void Set_Language(List<string> language)
        {
            Language = language;
        }

        public void Set_Language(string language, int index)
        {
            Language.Add(language);
        }

        public List<string> Get_Language()
        {
            return Language;
        }

        public string Get_Language(int index)
        {
            if(Language.Count-1 >= index)
                return Language[index];

            return "Unknown";
        }

        public List<string> Get_Tags()
        {
            return Tags;
        }

        public string Get_Tag(int index)
        {
            try
            {
                return Tags[index];
            }
            catch
            {
                return null;
            }
        }

        public void Set_Tags(List<string> tags)
        {
            Tags = tags;
        }

        public void Add_Tag(string tag)
        {
            Tags.Add(tag);
        }

        public string DirectorLink
        {
            get
            {
                return DirectorWebLink;
            }
            set
            {
                DirectorWebLink = value;
            }
        }

        public bool Default
        {
            get
            {
                return DefaultMovie;
            }
            set
            {
                DefaultMovie = value;
            }
        }

        public string MPAA_Rating
        {
            get
            {
                return MPAA;
            }
            set
            {
                MPAA = value;
            }
        }

        public string MovieTrailer
        {
            get
            {
                return TrailerMovie;
            }
            set
            {
                TrailerMovie = value;
            }
        }

        public bool IsDynamic
        {
            get
            {
                return Dynamic;
            }
            set
            {
                Dynamic = value;
            }
        }

        public string Prize
        {
            get
            {
                if (Prizes == null)
                    return "";
                return Prizes;
            }
            set
            {
                Prizes = value.ToString();
            }
        }

        public int Index
        {
            get
            {
                try
                {
                    return IndexInDatabase;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public void Update_Informations()
        {
            try
            {
                if (Name == null)
                    return;

                if (DataBaseManipulation.ExistMovie(Name))
                {
                    OleDbDataReader reader = DataBaseManipulation.MovieDBReader(Name);
                    reader.Read(); Default = reader["DefaultMovie"].ToString() == "0" ? false : true;

                    DataBaseManipulation.UpdateMovie(this);
                }
                else
                    DataBaseManipulation.InsertMovie(this);
            }
            catch
            {
                return;
            }
        }

        public void Take_Plot_Keywords()
        {
            try
            {
                string sourceCode = WorkerClass.GetSourceCode(IMDB_Adress + "keywords");

                if (sourceCode == null)
                    return;

                int startIndex = sourceCode.IndexOf("class=\"keyword\"") + 15;
                int endIndex;

                Tags.Clear();

                startIndex = sourceCode.IndexOf("href=\"/keyword/", startIndex);

                for (; startIndex >= 0; startIndex = sourceCode.IndexOf("href=\"/keyword/", startIndex))
                {
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);

                    Tags.Add(sourceCode.Substring(startIndex, endIndex - startIndex));
                }
            }
            catch
            {
                return;
            }
        }

        public void Take_MPAA()
        {
            try
            {
                string sourceCode = WorkerClass.GetSourceCode(IMDB_Adress + "parentalguide");

                if (sourceCode == null) 
                    return;

                int startIndex = sourceCode.IndexOf("<div class=\"info-content\">")+27;
                int endIndex = sourceCode.IndexOf("<",startIndex)-1;

                if (startIndex >= 0 && startIndex < endIndex)
                    MPAA = sourceCode.Substring(startIndex, endIndex - startIndex);
                else
                    MPAA = "Unknown";
            }
            catch
            {
                return;
            }
        }

        public void Update_Movie()
        {
            //Update Functions

            Take_Plot_Keywords();
            Take_MPAA();

            //Update Manually

            string sourceCode = WorkerClass.GetSourceCode(IMDB_Adress);

            if (sourceCode == null)
            {
                //MessageBox.Show("Selected URL couldn't be accessed! Please check you interner connection or your URL again!", "Could not acces the selected URL");
                return ;
            }

            int startIndex = sourceCode.IndexOf("<meta name=\"title\" content=") + 28;
            int StartIndex;
            int endIndex = sourceCode.IndexOf("(", startIndex) - 1;

            string title = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex).Replace("IMDb", "").Replace(" - ", ""));

            try
            {
                //Take the real year of the movie
                startIndex = sourceCode.IndexOf("<title>");
                startIndex = sourceCode.IndexOf("(", startIndex) + 1;
                endIndex = sourceCode.IndexOf(")", startIndex);
                string year = sourceCode.Substring(startIndex, endIndex - startIndex);

                //Modify the real year in movie informations
                Year = year;

                //Take the IMDB mark
                startIndex = sourceCode.IndexOf("ratingValue") + 13;
                endIndex = sourceCode.IndexOf("<", startIndex);
                IMDB_Mark = sourceCode.Substring(startIndex, endIndex - startIndex);

                //Take the Director
                startIndex = sourceCode.IndexOf("itemprop=\"director\"", startIndex);
                startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                endIndex = sourceCode.IndexOf("<", startIndex);
                Director = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));
                startIndex = sourceCode.IndexOf("href=\"/", startIndex - 100)+7;
                endIndex = sourceCode.IndexOf("/\"", startIndex);
                DirectorWebLink = sourceCode.Substring(startIndex, endIndex - startIndex);

                //Take the nominations and winnings
                try
                {
                    Prizes = null;

                    StartIndex = startIndex;
                    StartIndex = sourceCode.IndexOf("class=\"article highlighted\"", startIndex);
                    StartIndex = sourceCode.IndexOf(">", StartIndex) + 1;

                    int SpecialPrize = sourceCode.IndexOf("<b>", StartIndex);

                    if (SpecialPrize > -1 && SpecialPrize - StartIndex < 100)
                    {
                        StartIndex = sourceCode.IndexOf("<b>", StartIndex) + 3;
                        endIndex = sourceCode.IndexOf("</b>",StartIndex);
                        Prizes = sourceCode.Substring(StartIndex, endIndex - StartIndex) + Environment.NewLine;
                        StartIndex = endIndex + 4;
                    }
                    endIndex = sourceCode.IndexOf("<", StartIndex);
                    Prizes += WorkerClass.StringWithoutHtmlFormat(WorkerClass.String_Whitout_New_Lines(sourceCode.Substring(StartIndex, endIndex - StartIndex))).TrimStart();
                }
                catch
                {
                    Prizes = "";
                }

                //Take IMDb Actors
                Stars.Clear();
                StarsLink.Clear();

                startIndex = sourceCode.IndexOf("<table class=\"cast_list\">");
                endIndex = sourceCode.IndexOf("</table>", startIndex);
                string Actor = sourceCode.Substring(startIndex, endIndex - startIndex);
                StartIndex = 0;
                if (Directory.Exists("images\\" + IndexInDatabase.ToString() + " Stars") == false)
                    Directory.CreateDirectory("images\\" + IndexInDatabase.ToString() + " Stars");
                for (; Actor.IndexOf("alt", StartIndex) > 0;)
                {
                    //Take the actor name
                    StartIndex = Actor.IndexOf("alt", StartIndex) + 5;
                    int EndIndex = Actor.IndexOf("title", StartIndex) - 2;
                    string star = WorkerClass.StringWithoutHtmlFormat(Actor.Substring(StartIndex, EndIndex - StartIndex));

                    //Take the actor image
                    EndIndex = Actor.IndexOf("</a>", StartIndex);
                    string Actorlink = Actor.Substring(StartIndex, EndIndex - StartIndex);
                    if (Actorlink.IndexOf(".jpg") >= 0)
                    {
                        StartIndex = Actor.IndexOf("loadlate=\"", StartIndex) + 10;
                        EndIndex = Actor.IndexOf(".jpg", StartIndex) + 4;
                        WorkerClass.Download_Actor_Image(IndexInDatabase, star, Actor.Substring(StartIndex, EndIndex - StartIndex));
                    }
                    else
                    {
                        Image a = Image.FromFile("sample.jpg");
                        if (File.Exists("images\\" + IndexInDatabase.ToString() + " Stars\\" + star + ".jpg") == false)
                            a.Save("images\\" + IndexInDatabase.ToString() + " Stars\\" + star + ".jpg");
                    }

                    //Take the actor IMDb link
                    StartIndex = Actor.IndexOf("href=\"", StartIndex) + 6;
                    EndIndex = Actor.IndexOf("\"", StartIndex);
                    StarsLink.Add(Actor.Substring(StartIndex, EndIndex - StartIndex));

                    //Take the actor role
                    StartIndex = Actor.IndexOf("<div>", StartIndex) + 5;
                    if (StartIndex == 4)
                        break;
                    EndIndex = Actor.IndexOf("</div>", StartIndex);
                    string ActorRole = Actor.Substring(StartIndex, EndIndex - StartIndex);
                    if (ActorRole.IndexOf("onclick") != -1)
                    {
                        StartIndex = Actor.IndexOf(">", StartIndex) + 1;
                        EndIndex = Actor.IndexOf("<", StartIndex);
                        star = star + "/" + WorkerClass.StringWithoutHtmlFormat(Actor.Substring(StartIndex, EndIndex - StartIndex).Replace("\\n", "").Replace("\n", "").Replace(Environment.NewLine, "").Replace("  ", "").Replace("(", " ("));
                    }
                    else
                        star = star + "/" + WorkerClass.StringWithoutHtmlFormat(Actor.Substring(StartIndex + 12, EndIndex - StartIndex - 12).Replace("\\n", "").Replace("\n", "").Replace(Environment.NewLine, "").Replace("  ", "").Replace("</div>", "").Replace("(", " ("));

                    Stars.Add(star);
                }

                //UpdateBar.Value = 70;

                //Take the storyline
                startIndex = sourceCode.IndexOf("<h2>Storyline</h2>");
                startIndex = sourceCode.IndexOf("<p>", startIndex) + 3;
                endIndex = sourceCode.IndexOf("<", startIndex);
                StoryLine = WorkerClass.String_Whitout_New_Lines(WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex)));

                //Take the genres
                Genres.Clear();

                for (; sourceCode.IndexOf("itemprop=\"genre\"",startIndex) > 0;)
                {
                    startIndex = sourceCode.IndexOf("itemprop=\"genre\"",startIndex);
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    Genres.Add(sourceCode.Substring(startIndex, endIndex - startIndex));
                }

                //Take the countries
                Country.Clear();

                for (; sourceCode.IndexOf("href=\"/country/", startIndex) > 0;)
                {
                    startIndex = sourceCode.IndexOf("href=\"/country/", startIndex);
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    Country.Add(sourceCode.Substring(startIndex, endIndex - startIndex));
                }

                Language.Clear();

                for (; sourceCode.IndexOf("itemprop=\"inLanguage\"", startIndex) > 0;)
                {
                    startIndex = sourceCode.IndexOf("itemprop=\"inLanguage\"", startIndex);
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    Language.Add(sourceCode.Substring(startIndex, endIndex - startIndex));
                }

                //Take the runtime
                startIndex = sourceCode.IndexOf("itemprop=\"duration\"", startIndex);
                if (startIndex != -1)
                {
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    RunTime = sourceCode.Substring(startIndex, endIndex - startIndex);
                }

                IMDB_Name = title;
                if (Dynamic == false)
                {
                    this.Update_Informations();

                    string ImageUrl = sourceCode.Substring(0, sourceCode.IndexOf("317_.jpg") + 9);
                    ImageUrl = ImageUrl.Substring(ImageUrl.IndexOf("article title-overview"), ImageUrl.Length - ImageUrl.IndexOf("article title-overview"));
                    ImageUrl = ImageUrl.Substring(ImageUrl.IndexOf("<img src=") + 10, ImageUrl.Length - ImageUrl.IndexOf("<img src=") - 10);

                    //UpdateBar.Value = 100;

                    WorkerClass.Download_Image(Index, ImageUrl);
                }

                return ;
            }
            catch
            {
                return ;
                //Error_Message();
            }
        }
    }
}
