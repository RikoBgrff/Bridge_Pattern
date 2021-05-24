using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class JsonHelper
    {
       public static void JsonSerialize(List<User> users, string filename)
        {

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, users);
                }
            }
        }

        public List<User>  JsonDeserialize()
        {
            List<User> users = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader("users.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<List<User>>(jr);
                    if (users != null)
                    {
                        return users;
                    }
                    return null;
                }
            }

        }
    }
}
