using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Movie_Maniacs
{
    class CheckUpdates
    {

        public static void CheckForUpdates()
        {
            string xmlUrl = "http://www.maritimsoftware.xhost.ro/updates.xml";
            string elementName = null;
            string url = null;

            try
            {
                Version newVersion = null;

                XmlTextReader reader = new XmlTextReader(xmlUrl);

                reader.MoveToContent();

                for (; reader.Name != "moviemaniacs"; reader.Read()) ;

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "moviemaniacs")
                    for (; reader.Read() == true; )
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else if (reader.NodeType == XmlNodeType.Text && reader.HasValue == true)
                            switch (elementName)
                            {
                                case "version":
                                    newVersion = new Version(reader.Value);
                                    break;
                                case "url":
                                    url = reader.Value;
                                    break;

                            }
                if (newVersion != System.Reflection.Assembly.GetExecutingAssembly().GetName().Version)
                    if (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.CompareTo(newVersion) < 0)
                        if (MessageBox.Show("Out there is available a new version for Movie Maniacs. Do you want to update it?", "New updates", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            Process.Start(url) ;

                MessageBox.Show("This product is up to date!");
                reader.Close();
            }
            catch
            {
                return;
            }
        }

        public static void CheckforUpdates()
        {
            Thread thread = new Thread(new ThreadStart(CheckForUpdates));

            thread.Start();
        }
    }
}
