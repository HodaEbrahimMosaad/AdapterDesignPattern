using DesignPatternsInCSharp.Adapter.AdapterService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Adapter.AdapterService
{
    public partial class StarWarsCharacterDisplayService
    {

        public ICharacterSourceAdapter CharacterSourceAdapter { get; set; }
        public StarWarsCharacterDisplayService(ICharacterSourceAdapter csa)
        {
            this.CharacterSourceAdapter = csa;
        }



        public async Task<string> ListCharacters()
        {
            IEnumerable<Person> people;
            people = await CharacterSourceAdapter.GetPerson();
            var sb = new StringBuilder();
            int nameWidth = 30;
            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"HAIR"}");
            foreach (Person person in people)
            {
                sb.AppendLine($"{person.Name.PadRight(nameWidth)}   {person.HairColor}");
            }

            return sb.ToString();
        }
    }
}
