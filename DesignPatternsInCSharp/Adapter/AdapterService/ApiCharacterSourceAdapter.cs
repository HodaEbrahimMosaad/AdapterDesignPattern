using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Adapter.AdapterService
{
    public class ApiCharacterSourceAdapter : ICharacterSourceAdapter
    {
        private readonly ApiCharacterSource ApiCharacterSource;
        public ApiCharacterSourceAdapter(ApiCharacterSource acs)
        {
            this.ApiCharacterSource = acs;
        }
        public Task<IEnumerable<Person>> GetPerson()
        {
            return this.ApiCharacterSource.GetDataFromAPI();
        }
    }
}
