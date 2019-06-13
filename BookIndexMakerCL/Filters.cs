using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class Filters
{
    public enum DictionaryFilters
    {
        Nouns,
        Verbs,
        VerbsTransitive,
        VerbsIntransitive,
        Adjectives,
        Adverbs,
        Pronouns,
        Prepositions,
        Imperatives,
        Conjunctions,
        PresentParticiples,
        PastParticiples,
        Superlatives,
        Subjunctives,
        Interjections,
        Comparatives,
        Datives,
        Definites,
        Unknown
    }

    public bool Nouns { get; set; }
    public bool Verbs { get; set; }
    public bool VerbsTransitive { get; set; }
    public bool VerbsIntransitive { get; set; }
    public bool Adjectives { get; set; }
    public bool Adverbs { get; set; }
    public bool Pronouns { get; set; }
    public bool Prepositions { get; set; }
    public bool Imperatives { get; set; }
    public bool Conjunctions { get; set; }
    public bool PresentParticiples { get; set; }
    public bool PastParticiples { get; set; }
    public bool Superlatives { get; set; }
    public bool Subjunctives { get; set; }
    public bool Interjections { get; set; }
    public bool Comparatives { get; set; }
    public bool Datives { get; set; }
    public bool Definites { get; set; }

    public bool CapitalsOnly { get; set; }
    public bool NumbersAll { get; set; }
    public bool NumbersAndLetters { get; set; }

    public string IncludeWords { get; set; }
    public string ExcludeWords { get; set; }

    public static List<DictionaryFilters> GetDictionaryFilterEnums(string wordTypeDescription)
    {
        List<DictionaryFilters> ret = new List<DictionaryFilters>();

        string w = wordTypeDescription.ToLower().Replace(" ", "").Replace("/","");
        if (w.IndexOf("n.") == 0) ret.Add(DictionaryFilters.Nouns);
        if (w.IndexOf("v.vb.") > -1) ret.Add(DictionaryFilters.Verbs);
        if (w.IndexOf("v.t.") > -1) ret.Add(DictionaryFilters.VerbsTransitive);
        if (w.IndexOf("v.i.") > -1) ret.Add(DictionaryFilters.VerbsIntransitive);
        if (w.IndexOf("a.adj.") > -1) ret.Add(DictionaryFilters.Adjectives);
        if (w.IndexOf("adv.") > -1) ret.Add(DictionaryFilters.Adverbs);
        if (w.IndexOf("pn.") > -1) ret.Add(DictionaryFilters.Pronouns);
        if (w.IndexOf("prep.") > -1) ret.Add(DictionaryFilters.Prepositions);
        if (w.IndexOf("imp.") > -1) ret.Add(DictionaryFilters.Imperatives);
        if (w.IndexOf("conj.") > -1) ret.Add(DictionaryFilters.Conjunctions);
        if (w.IndexOf("p.pr.") > -1) ret.Add(DictionaryFilters.PresentParticiples);
        if (w.IndexOf("p.p.") > -1) ret.Add(DictionaryFilters.PastParticiples);
        if (w.IndexOf("superl.") > -1) ret.Add(DictionaryFilters.Superlatives);
        if (w.IndexOf("subj.") > -1) ret.Add(DictionaryFilters.Subjunctives);
        if (w.IndexOf("interj.") > -1) ret.Add(DictionaryFilters.Interjections);
        if (w.IndexOf("compar.") > -1) ret.Add(DictionaryFilters.Comparatives);
        if (w.IndexOf("dat.") > -1) ret.Add(DictionaryFilters.Datives);
        if (w.IndexOf("def.") > -1) ret.Add(DictionaryFilters.Definites);

        if (ret.Count == 0) ret.Add(DictionaryFilters.Unknown);

        return ret;
    }

    public static string DictionaryFiltersToString(DictionaryFilters df)
    {
        string ret = "";

        switch (df)
        {
            case DictionaryFilters.Adjectives: ret = "Adjective"; break;
            case DictionaryFilters.Adverbs: ret = "Adverb"; break;
            case DictionaryFilters.Comparatives: ret = "Comparative"; break;
            case DictionaryFilters.Conjunctions: ret = "Conjunction"; break;
            case DictionaryFilters.Datives: ret = "Dative"; break;
            case DictionaryFilters.Definites: ret = "Definite"; break;
            case DictionaryFilters.Imperatives: ret = "Imperative"; break;
            case DictionaryFilters.Interjections: ret = "Interjection"; break;
            case DictionaryFilters.Nouns: ret = "Noun"; break;
            case DictionaryFilters.PastParticiples: ret = "Past Participle"; break;
            case DictionaryFilters.Prepositions: ret = "Preposition"; break;
            case DictionaryFilters.PresentParticiples: ret = "Present Participle"; break;
            case DictionaryFilters.Pronouns: ret = "Pronoun"; break;
            case DictionaryFilters.Subjunctives: ret = "Subjunctive"; break;
            case DictionaryFilters.Superlatives: ret = "Superlative"; break;
            case DictionaryFilters.Unknown: ret = "Unknown"; break;
            case DictionaryFilters.Verbs: ret = "Verb"; break;
            case DictionaryFilters.VerbsIntransitive: ret = "Intransitive Verb"; break;
            case DictionaryFilters.VerbsTransitive: ret = "Transitive Verb"; break;         

        }

        return ret;
    }
}
