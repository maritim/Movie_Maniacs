using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Movie_Maniacs
{
    class WorkerClass
    {
        public static string GetSourceCode(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());

                string sourceCode = sr.ReadToEnd();

                sr.Close();
                response.Close();

                return sourceCode;
            }
            catch
            {
                return null;
            }
        }

        public static string GetResponseUri(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                return response.ResponseUri.ToString();
            }
            catch
            {
                return null;
            }
        }

        public static List<string> ReadFile(string Name)
        {
            try
            {
                List<string> lines = new List<string>();

                StreamReader file = new StreamReader(Name);

                for (; file.EndOfStream != true; lines.Add(file.ReadLine())) ;

                file.Close();

                return lines;
            }
            catch
            {
                return null;
            }
        }

        public static string ReadFile(string Name,bool OneLine)
        {
            try
            {
                string line;

                StreamReader file = new StreamReader(Name);

                line = file.ReadToEnd();

                file.Close();

                return line;
            }
            catch
            {
                return null;
            }
        }

        public static void WriteFile(string Name, List<string> lines, bool Append)
        {
            try
            {
                StreamWriter file = new StreamWriter(Name, Append);

                foreach(string line in lines)
                    file.WriteLine(line);

                file.Close();
            }
            catch
            {
                return;
            }
        }

        public static void WriteFile(string Name, string line, bool Append)
        {
            try
            {
                StreamWriter file = new StreamWriter(Name, Append);

                file.WriteLine(line);

                file.Close();
            }
            catch
            {
                return;
            }
        }

        public static void Download_Image(int Index, string url)
        {
            WebClient wc = new WebClient();

            Uri ImageUrl = new Uri(url);

            wc.DownloadFileAsync(ImageUrl,"images//" + Index.ToString() + ".jpg");
        }

        public static void Download_Actor_Image(int Index, string ActorName, string url)
        {
            WebClient wc = new WebClient();

            try
            {
                Uri ImageUrl = new Uri(url);

                wc.DownloadFileAsync(ImageUrl, "images\\" + Index.ToString() + " Stars\\" + WorkerClass.AvailableFolderName(ActorName) + ".jpg");
            }
            catch
            {
                return;
            }
        }

        static public string String_Whitout_New_Lines(string text)
        {
            return text.Replace("\\r", "").Replace("\\n", "").Replace("\r","").Replace("\n","").Replace(Environment.NewLine, "");
        }

        static public string StringWithoutHtmlFormat(string text)
        {
            text = text.Replace("&#x22;", "\"").Replace("&#x27;", "'").Replace("&quot;", "\"").Replace("&#xE0;", "a")
                .Replace("&#xE2;", "a").Replace("&#39;", "'").Replace("&amp;","&");
            return text;
        }

        static public int min(object a, object b,string type)
        {
            switch (type)
            {
                case "int": { int A = (int)a; int B = (int)b; if (A < B) return -1; else if (A > B) return 1; else return 0; }
            }

            return 2;
        }

        static public bool IsMovie(string Movie)
        {
            return (Movie.ToUpper().IndexOf("GAME") < 0 && Movie.ToUpper().IndexOf("PLAY") < 0 && Movie.ToUpper().IndexOf("PS") < 0 && Movie.ToUpper().IndexOf("XBOX") < 0) ;
        }

        static public List<KeyValuePair<string,string>> Movie_Trailer_Link(string Movie_Name)
        {
            List<KeyValuePair<string,string>> Movie = new List<KeyValuePair<string,string>>();

            string sourceCode = WorkerClass.GetSourceCode("http://www.youtube.com/results?search_query=trailer+movie+" + Movie_Name.Replace(" ", "+"));

            string link,name;

            int startIndex = sourceCode.IndexOf("dir=\"ltr\"title=\"");
            int endIndex = 0;

            for (; startIndex >= 0; startIndex = sourceCode.IndexOf("dir=\"ltr\"title=\"", startIndex))
            {
                startIndex += 16;
                endIndex = sourceCode.IndexOf("\"", startIndex);

                name = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));

                startIndex = sourceCode.IndexOf("v=", startIndex) + 2;
                endIndex = sourceCode.IndexOf("\"", startIndex);

                link = sourceCode.Substring(startIndex, endIndex - startIndex);

                if(link.IndexOf("&amp") < 0 && IsMovie(name))
                    Movie.Add(new KeyValuePair<string, string>(link + "&amp;fs=1", name));
            }

            return Movie;
        }

        static public string ValidYouTubeLink(string link)
        {
            if (link.IndexOf("www.youtube.com") >= 0)
            {
                if (link.IndexOf("http://") != 0)
                    link = "http://" + link;
                link = link.Replace("http://www.youtube.com/watch?v=", "");
            }

            if(link.IndexOf("&") >= 0)
                link = link.Substring(0, link.IndexOf("&"));

            link += "&amp;fs=1";

            return link;
        }

        static public string MovieNameOnYouTube(string link)
        {
            string sourceCode = WorkerClass.GetSourceCode(link);

            int startIndex = sourceCode.IndexOf("itemprop=\"name\" content=") + 25;
            int endIndex = sourceCode.IndexOf("\"",startIndex);

            return WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));
        }

        static public Image MovieTumbnailOnYouTube(string link)
        {
            try
            {
                link = WorkerClass.GetSourceCode(link);

                int startIndex = link.IndexOf("image\" content=\"") + 16;
                int endIndex = link.IndexOf("\">", startIndex);

                link = link.Substring(startIndex, endIndex - startIndex);

                WebRequest requestTumbnail = WebRequest.Create(link);
                requestTumbnail.Timeout = 5000;
                return Image.FromStream(requestTumbnail.GetResponse().GetResponseStream());
            }
            catch
            {
                return null;
            }
        }

        static public Image WebImage(string link)
        {
            try
            {
                WebRequest request = WebRequest.Create(link);
                request.Timeout = 5000;
                return Image.FromStream(request.GetResponse().GetResponseStream());
            }
            catch
            {
                return null;
            }
        }

        static public string MoviePoster(string link)
        {
            try
            {
                link = WorkerClass.GetSourceCode(link);

                int startIndex = link.IndexOf("src=\"http://ia.media-imdb.com") + 5;
                int endIndex = link.IndexOf("\"", startIndex);

                link = link.Substring(startIndex, endIndex - startIndex);

                return link;
            }
            catch
            {
                return null;
            }
        }

        static public void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }

        static public string AvailableFolderName(string name)
        {
            return name.Replace(":", " ").Replace("/", " ").Replace("\\", " ").Replace("?", " ").Replace("*", " ").Replace("\"", " ").Replace("<", " ").Replace(">", " ").Replace("|", " ");
        }

        static public bool Is_Available_Folder_Name(string name)
        {
            if (name != AvailableFolderName(name))
                return false;

            return true;
        }

        static public string ListToString(List<string> list)
        {
            string all = null;

            foreach (string a in list)
                all += "/pause/" + a;

            return all;
        }

        static public List<string> StringToList(string all)
        {
            List<string> list = new List<string>();

            int startIndex = all.IndexOf("/pause/")+7;
            int endIndex = 0;

            for (; startIndex >= 7; startIndex = all.IndexOf("/pause/",startIndex)+7)
            {
                endIndex = all.IndexOf("/pause/",startIndex);
                if (endIndex < startIndex) endIndex = all.Length;
                list.Add(WorkerClass.StringWithApostrophe(all.Substring(startIndex, endIndex - startIndex)));
            }

            return list;
        }

        static public string StringWithoutApostrophe(string word)
        {
            try
            {
                return word.Replace("'", "/apostrophe/");
            }
            catch
            {
                return null;
            }
        }

        static public string StringWithApostrophe(string word)
        {
            try
            {
                return word.Replace("/apostrophe/", "'");
            }
            catch
            {
                return null;
            }
        }
    }
}
