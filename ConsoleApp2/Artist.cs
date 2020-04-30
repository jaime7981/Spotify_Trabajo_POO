using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Artist
    {
        string username;
        int ranking;
        string biografia;
        bool verification;
        List<UserSystem> followers;

        public Artist()
        {
            followers = new List<UserSystem>();
            
        
        
        }
        public Artist(string Username,bool Verification, int Ranking ) 
            :this()
        
        {
            username = Username;
            verification = Verification;
            ranking = Ranking;
        
        
        
        
        }




    }








    
}
