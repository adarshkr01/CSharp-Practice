using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictTesting
{
    public class Phonetic
    {
        public string text { get; set; }
        public string audio { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public List<string> synonyms { get; set; }
        public string example { get; set; }
    }

    public class Meaning
    {
        public string partOfSpeech { get; set; }
        public List<Definition> definitions { get; set; }
    }

    public class Root
    {
        public string word { get; set; }
        public List<Phonetic> phonetics { get; set; }
        public List<Meaning> meanings { get; set; }
    }



}
