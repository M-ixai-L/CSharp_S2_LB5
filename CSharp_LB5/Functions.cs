using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CSharp_LB5
{
    public class Functions
    {
        internal Library ReadLibrary()
        {
            Library readLibrary = new Library();

            if (File.Exists("library.json"))
            {
                string readJSON = File.ReadAllText("library.json");
                readLibrary = JsonSerializer.Deserialize<Library>(readJSON);
            }
            
            return readLibrary;
        }

        internal void WriteJSON(Library library)
        {
            string writeJSON = JsonSerializer.Serialize(library);
            File.WriteAllText("library.json", writeJSON);
        }
    }
}