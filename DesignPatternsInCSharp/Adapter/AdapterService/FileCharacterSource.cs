using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Adapter.AdapterService
{
    public class FileCharacterSource
    {
        public async Task<IEnumerable<Person>> GetDataFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<Person>>(await File.ReadAllTextAsync(path));
        }
    }
}
