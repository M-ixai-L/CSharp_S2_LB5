using System.Collections.Generic;
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

        internal void ReadLibrary()
        {
            Library readLibrary = new Library();

            if (File.Exists("library.json"))
            {
                string readJSON = File.ReadAllText("library.json");
                library = JsonSerializer.Deserialize<Library>(readJSON);
            }
        }

        internal void WriteJSON()
        {
            string writeJSON = JsonSerializer.Serialize(library);
            File.WriteAllText("library.json", writeJSON);
        }
    }
}