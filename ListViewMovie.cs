using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Movie_Maniacs
{
    class ListViewMovie : MovieClass
    {
        private Image PosterImage;
        private int Poz;
        private string LinkPoster;

        public ListViewMovie()
        { 
        }

        public ListViewMovie(bool isdynamic)
        {
            IsDynamic = isdynamic;
        }

        public Image Poster
        {
            get
            {
                return PosterImage;
            }
            set
            {
                PosterImage = value;
            }
        }

        public string MovieName
        {
            get
            {
                return Movie_Name;
            }
            set
            {
                Movie_Name = value;
            }
        }

        public string Mark
        {
            get
            {
                return Get_Mark();
            }
            set
            {
                Set_Mark(value);
            }
        }

        public int Pozition
        {
            get
            {
                return Poz;
            }
            set
            {
                Poz = value;
            }
        }

        public string PosterLink
        {
            get
            {
                return LinkPoster;
            }
            set
            {
                LinkPoster = value;
            }
        }
    }
}
