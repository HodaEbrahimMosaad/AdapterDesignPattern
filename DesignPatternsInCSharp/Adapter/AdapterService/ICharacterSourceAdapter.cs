using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Adapter.AdapterService
{
    public interface ICharacterSourceAdapter
    {
        public Task<IEnumerable<Person>> GetPerson();
    }
}
