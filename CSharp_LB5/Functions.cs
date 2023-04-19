using System.IO;
using System.Text.Json;

namespace CSharp_LB5
{
    public class Functions
    {
        //internal void 
        private Library library;
        
        //
        internal Functions(Library library)
        {
            this.library = library;
        }

        internal Library ReadLibrary()
        {
            if (File.Exists("library.json"))
            {
                string readJSON = File.ReadAllText("library.json");
                library = JsonSerializer.Deserialize<Library>(readJSON);
            }

            return library;
        }

        internal void WriteJSON()
        {
            string writeJSON = JsonSerializer.Serialize(library);
            File.WriteAllText("library.json", writeJSON);
        }
    }
}