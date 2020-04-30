using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Song
    {
        string Namesong;
        string Genre;
        string Composer;
        string Discography;
        string Studio;
        string Publicationyear;
        string Lyrics;
        string Duration;
        string Category;
        string Type;
        string Qualification;
        string Reproduction;

        public Song(string namesong,string genre,string composer,string discography,string studio,string publicationyear, string lyrics, string duration, string category, string type, string qualification,string reproduction) 
        {
            Namesong = namesong;
            Genre = genre;
            Composer = composer;
            Discography = discography;
            Studio = studio;
            Publicationyear = publicationyear;
            Lyrics = lyrics;
            Duration = duration;
            Category = category;
            Type = type;
            Qualification = qualification;
            Reproduction = reproduction;





        
        
        }


        public  string Getinfo { get; set; }
        
            
        
        
        



    }
}
