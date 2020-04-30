using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.IO;
namespace ConsoleApp2
{
    class Reproduction
    {
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        public Reproduction()
        {

        }


        public void Onplay(bool songvideo)
        {
            var curDir = Directory.GetCurrentDirectory();

            if (songvideo == false) // si es falso es cancion
            {
                var songDir = @"\e-dubble - No Brakes (FF #44).mp3";
                var dir = curDir + songDir; // direccion de la cancion o vieo, quizas hacer esto en la clase de song
                /*
                wplayer.URL = dir;
                wplayer.controls.play();
                wplayer.controls.stop();
                wplayer.Play();
                */

            }
            if (songvideo == true) // si es falso es cancion
            {
                var videoDir = @"Epic downhill longboarding on higest speed Gravity Dogz.mp4";
                var dir = curDir + videoDir; // direccion de la cancion o vieo, quizas hacer esto en la clase de song
                //System.Diagnostics.Process.Start(dir);
            }

        }

        public void OnBack()
        {
            throw new NotImplementedException();
        }

        public void OnStop()
        {
            throw new NotImplementedException();
        }

        public void OnNext()
        {
            throw new NotImplementedException();
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

        public void SavedQueue()
        {
            throw new NotImplementedException();
        }

        public void ResumeLastPlayed()
        {
            throw new NotImplementedException();
        }
    }
}
