using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Song
    {
        string namesong;
        string genre;
        string composer;
        string discography;
        string studio;
        string publicationyear;
        string lyrics;
        string duration;
        string category;
        string type;
        int qualification;
        int reproduction;

        public Song(string Namesong,string Genre,string Composer,string Discography,string Studio,string Publicationyear, string Lyrics, string Duration, string Category, string Type, int Qualification,int Reproduction) 
        {
            namesong = Namesong;
            genre = Genre;
            composer = Composer;
            discography = Discography;
            studio = Studio;
            publicationyear = Publicationyear;
            lyrics = Lyrics;
            duration = Duration;
            category = Category;
            type = Type;
            qualification = Qualification;
            reproduction = Reproduction;





        
        
        }


        public  string Getinfo { get; set; }
        
            
        
        
        



    }
}
