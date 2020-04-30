using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Video
    {
        string videoName;
        string genre;
        string category;
        string actor;
        string director;
        string studio;
        string uploadDate;
        string description;
        int duration;
        int qualification;
        int reproduction;

        public Video(string VideoName,string Genre,string Category,string Actor,string Director,string Studio, string UploadDate, string Description,int Duration,int Qualification, int Reproduction)
        {
            videoName = VideoName;
            genre = Genre;
            category = Category;
            actor = Actor;
            director = Director;
            studio = Studio;
            uploadDate = UploadDate;
            description = Description;
            duration = Duration;
            qualification = Qualification;
            reproduction = Reproduction;


        }
        public string Getinfovideo { get; set; }
        






    }
}
