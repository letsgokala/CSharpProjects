using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonPractical
{
    public class PokemonLogEntry
    {
        private string _name;
        private int _gainedLevel;
        private DateTime _timeStamp;

        public String Name{ get; }
        public int GainedLevel{ get; }
        public DateTime TimeStamp{ get; }

        public PokemonLogEntry(String name, int gainedLevel, DateTime timeStamp)
        {
            Name = name;
            GainedLevel = gainedLevel;
            TimeStamp = timeStamp;
        }
    }
}