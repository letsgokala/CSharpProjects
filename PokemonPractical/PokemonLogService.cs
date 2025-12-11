using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonPractical
{
    public class PokemonLogService
    {
        private List<PokemonLogEntry> _logs = new List<PokemonLogEntry>();        

        public void saveLog(String name, int amount)
        {
            PokemonLogEntry log = new PokemonLogEntry(name, amount, DateTime.Now);
            _logs.Add(log);
        }

        public List<PokemonLogEntry> GetAll()
        {
            return _logs;
        }
    }
}