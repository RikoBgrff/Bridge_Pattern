using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            void CheckUser(List<User> userz, User user)
            {
                foreach (var item in userz)
                {
                    if(item.Username == user.Username)
                    {
                        if(item.Password == user.Password)
                        {
                            Console.WriteLine("OK");
                        }
                    }
                }
            }
            UserSerializer serialize = new UserSerializer();
            JsonHelper helper = new JsonHelper();
            serialize.SerializeUser();
            Console.WriteLine("Welcome!");
            Console.Write("Username:"); string username = Console.ReadLine();
            Console.Write("Password:"); string password = Console.ReadLine();
            List<User> users = helper.JsonDeserialize();
            User userNowLogsIn = new User()
            {
                Username = username,
                Password = password
            };
            CheckUser(users, userNowLogsIn);
        }
    }
}
