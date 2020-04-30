using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        string username;
        bool privacy;
        bool premium;
        List<UserSystem> followers;
        List<UserSystem> followed;

        public User()
        {
            followers = new List<UserSystem>();
            followed = new List<UserSystem>();


        }

        public User(string Username, bool Privacy,bool Premium)
            :this()
        {
            this.username = Username;
            this.privacy = Privacy;
            this.premium = Premium;
        
        }

        public void ShowInformation()
        {
            throw new NotImplementedException();
        }

        public void Follow()
        {
            throw new NotImplementedException();
        }

        public void Advertistemt()
        {
            throw new NotImplementedException();
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

    }
}
