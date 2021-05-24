using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class UserSerializer
    {
        public void SerializeUser()
        {
            List<User> users = new List<User>() {
            new User()
            {
                Username = "mammadzada",
                Password = "agil1234"
            },
            new User()
            {
                Username = "rikobgrff",
                Password = "riko1234"
            },
            new User()
            {
                Username = "eabbasov",
                Password = "elgun1234"
            },
            new User()
            {
                Username = "ayxanaxn",
                Password = "ayxan1234"
            },
            };
            JsonHelper.JsonSerialize(users, "users.json");
        }
    }
}
