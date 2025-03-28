using System.Text.Json;
using SecureLogin.Models;

namespace SecureLogin.Utils
{
    public static class SaveJson
    {
        private static string filename = "users.json";

        public static void CreateJson()
        {
            if (!File.Exists(filename))
            {
                using (FileStream createFile = File.Create(filename)) { }
                ;
            }
        }

        public static void AddUserToJson(User user)
        { // create json file before writing it
            CreateJson();
            User.UserList.Add(user);
            var userToJson = JsonSerializer.Serialize(User.UserList);
            File.WriteAllText(filename, userToJson);
            Console.WriteLine(user.username);
        }
    }
}
