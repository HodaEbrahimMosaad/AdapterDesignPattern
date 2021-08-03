using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Adapter.AdapterService
{
    public class FileCharacterSourceAdapter : ICharacterSourceAdapter
    {
        private readonly FileCharacterSource FileCharacterSource;
        public string path { get; set; }
        public FileCharacterSourceAdapter(string path, FileCharacterSource fcs)
        {
            this.FileCharacterSource = fcs;
            this.path = path;
        }
        public Task<IEnumerable<Person>> GetPerson()
        {
            return FileCharacterSource.GetDataFromFile(path);
        }
    }
}
