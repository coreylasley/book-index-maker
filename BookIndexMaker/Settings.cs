using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BookIndexMaker
{
    public partial class Settings : Form
    {
        private string filename;
 
        private Filters _Filter;
        public Filters Filter
        {
            get
            {
                return _Filter;
            }
            set
            {
                _Filter = value;
                                
            }
        }

        private DialogResult _Result;
        public DialogResult Result
        {
            get
            {
                return _Result;
            }
        }

        public Settings()
        {
            _Result = DialogResult.Cancel;
            filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "8pointbooksettings.dat";
            Filter = new Filters();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _Result = DialogResult.OK;
            _Filter.ExcludeWords = txtExcludeWords.Text;
            _Filter.IncludeWords = txtIncludeWords.Text;
            _Filter.NumbersAll = chkNumeric.Checked;
            _Filter.NumbersAndLetters = chkLettersAndNumbers.Checked;
            _Filter.CapitalsOnly = chkCapitalLetter.Checked;

            for (int x = 0; x < chkDictionaryExclusion.Items.Count; x++)
            {
                bool check = chkDictionaryExclusion.GetItemChecked(x);
                switch (x)
                {
                    case 0: _Filter.Nouns = check; break;
                    case 1: _Filter.Verbs = check; break;
                    case 2: _Filter.VerbsTransitive = check; break;
                    case 3: _Filter.VerbsIntransitive = check; break;
                    case 4: _Filter.Adjectives = check; break;
                    case 5: _Filter.Adverbs = check; break;
                    case 6: _Filter.Pronouns = check; break;
                    case 7: _Filter.Prepositions = check; break;
                    case 8: _Filter.Imperatives = check; break;
                    case 9: _Filter.Conjunctions = check; break;
                    case 10: _Filter.PresentParticiples = check; break;
                    case 11: _Filter.PastParticiples = check; break;
                    case 12: _Filter.Superlatives = check; break;
                    case 13: _Filter.Subjunctives = check; break;
                    case 14: _Filter.Interjections = check; break;
                    case 15: _Filter.Comparatives = check; break;
                    case 16: _Filter.Datives = check; break;
                    case 17: _Filter.Definites = check; break;
                }
            }

            Serialize(_Filter);

            this.Hide();
        }

        public void Serialize(Filters objectToSerialize)
        {            
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public Filters DeSerialize()
        {            
            Filters objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (Filters)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {            
            if (File.Exists(filename)) _Filter = DeSerialize();

            chkNumeric.Checked = _Filter.NumbersAll;
            chkLettersAndNumbers.Checked = _Filter.NumbersAndLetters;
            chkCapitalLetter.Checked = _Filter.CapitalsOnly;

            chkDictionaryExclusion.SetItemChecked(0, _Filter.Nouns);
            chkDictionaryExclusion.SetItemChecked(1, _Filter.Verbs);
            chkDictionaryExclusion.SetItemChecked(2, _Filter.VerbsTransitive);
            chkDictionaryExclusion.SetItemChecked(3, _Filter.VerbsIntransitive);
            chkDictionaryExclusion.SetItemChecked(4, _Filter.Adjectives);
            chkDictionaryExclusion.SetItemChecked(5, _Filter.Adverbs);
            chkDictionaryExclusion.SetItemChecked(6, _Filter.Pronouns);
            chkDictionaryExclusion.SetItemChecked(7, _Filter.Prepositions);
            chkDictionaryExclusion.SetItemChecked(8, _Filter.Imperatives);
            chkDictionaryExclusion.SetItemChecked(9, _Filter.Conjunctions);
            chkDictionaryExclusion.SetItemChecked(10, _Filter.PresentParticiples);
            chkDictionaryExclusion.SetItemChecked(11, _Filter.PastParticiples);
            chkDictionaryExclusion.SetItemChecked(12, _Filter.Superlatives);
            chkDictionaryExclusion.SetItemChecked(13, _Filter.Subjunctives);
            chkDictionaryExclusion.SetItemChecked(14, _Filter.Interjections);
            chkDictionaryExclusion.SetItemChecked(15, _Filter.Comparatives);
            chkDictionaryExclusion.SetItemChecked(16, _Filter.Datives);
            chkDictionaryExclusion.SetItemChecked(17, _Filter.Definites);
        }
    }
}
