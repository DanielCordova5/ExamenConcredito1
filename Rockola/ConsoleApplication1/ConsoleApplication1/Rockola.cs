using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rockola
    { 
        public string artista;
        public string album;
        public string cancion;
        public string duracion;
        public string genero;

        public Rockola(string Artista, string Album, string Cancion, string Duracion, string Genero)
        {
            artista = Artista;
            album = Album;
            cancion = Cancion;
            duracion = Duracion;
            genero = Genero;
        }

        public string pArtista
        {
            get
            {
                return artista;
            }
            set
            {
                artista = value;
            }
        }

        public string pAlbum
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
            }
        }

        public string pCancion
        {
            get
            {
                return cancion;
            }
            set
            {
                cancion = value;
            }
        }

        public string pGenero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }

    }

}
