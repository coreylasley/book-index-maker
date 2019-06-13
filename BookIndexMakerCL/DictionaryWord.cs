using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookIndexMaker
{


    [Serializable]
    public class DictionaryWord
    {
        public enum WordTypes
        {
            Adjective, // a.
            Noun, // n.
            Plural, // pl.
            PluralNoun,
            Preposition, // prep.
            TransitiveVerb, // v. t.
            ING, // p. pr.
            ED, // imp.
            Adverb, // adv.
            VerbIntransitive, // v. i.
            Unknown
        }

        public List<Filters.DictionaryFilters> WordTypeList { get; set; }
        public string Word { get; set; }
        public string WordType { get; set; }


        public DictionaryWord(string word, WordTypes wordType)
        {
            Word = word;
            //WordTypeEnum = wordType;
        }

        public DictionaryWord(string word, string definition)
        {
            Word = word;
            WordType = "Unknown";
            WordTypeList = new List<Filters.DictionaryFilters>();

            if (definition.Substring(0, 1) == "(")
            {
                string[] p = definition.Split(')');
                if (p.Length > 1)
                {
                    p[0] = p[0] + ")";
                    WordType = p[0];
                }

                WordType = WordType.Replace(",", "&").Replace("/", "&").Replace("(", "").Replace(")", "").Replace(" ", "");
                string[] types = WordType.Split('&');
                foreach (string str in types)
                {
                    switch (str.Trim().Replace(".", ""))
                    {
                        case "n": WordTypeList.Add(Filters.DictionaryFilters.Nouns); break;
                        case "pl": WordTypeList.Add(Filters.DictionaryFilters.Nouns); break;
                        case "npl": WordTypeList.Add(Filters.DictionaryFilters.Nouns); break;
                        case "v": WordTypeList.Add(Filters.DictionaryFilters.Verbs); break;
                        case "vb": WordTypeList.Add(Filters.DictionaryFilters.Verbs); break;
                        case "vbn":
                            WordTypeList.Add(Filters.DictionaryFilters.Verbs);
                            WordTypeList.Add(Filters.DictionaryFilters.Nouns);
                            break;
                        case "vt": WordTypeList.Add(Filters.DictionaryFilters.VerbsTransitive); break;
                        case "vi": WordTypeList.Add(Filters.DictionaryFilters.VerbsIntransitive); break;
                        case "a": WordTypeList.Add(Filters.DictionaryFilters.Adjectives); break;
                        case "adj": WordTypeList.Add(Filters.DictionaryFilters.Adjectives); break;
                        case "adv": WordTypeList.Add(Filters.DictionaryFilters.Adverbs); break;
                        case "pn": WordTypeList.Add(Filters.DictionaryFilters.Pronouns); break;
                        case "prep": WordTypeList.Add(Filters.DictionaryFilters.Prepositions); break;
                        case "imp": WordTypeList.Add(Filters.DictionaryFilters.Imperatives); break;
                        case "conj": WordTypeList.Add(Filters.DictionaryFilters.Conjunctions); break;
                        case "ppr": WordTypeList.Add(Filters.DictionaryFilters.PresentParticiples); break;
                        case "pp": WordTypeList.Add(Filters.DictionaryFilters.PastParticiples); break;
                        case "superl": WordTypeList.Add(Filters.DictionaryFilters.Superlatives); break;
                        case "subj": WordTypeList.Add(Filters.DictionaryFilters.Subjunctives); break;
                        case "interj": WordTypeList.Add(Filters.DictionaryFilters.Interjections); break;
                        case "compar": WordTypeList.Add(Filters.DictionaryFilters.Comparatives); break;
                        case "dat": WordTypeList.Add(Filters.DictionaryFilters.Datives); break;
                        case "def": WordTypeList.Add(Filters.DictionaryFilters.Definites); break;
                        default:
                            WordTypeList.Add(Filters.DictionaryFilters.Unknown);
                            break;
                    }
                }

            }


        }


    }
}
