using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Threading.Tasks;

namespace BookIndexMaker
{
    public delegate void UpdateEventHandler(object sender, UpdateEventArgs e);

    public class UpdateEventArgs : EventArgs
    {
        public IndexProject.EventUpdateTypes eventType { get; set; }
        public string message { get; set; }
        public int progressMax { get; set; }
        public int progressCurrent { get; set; }
        public int warningCount { get; set; }
    }

    [Serializable]
    public class IndexProject
    {
        public enum DocumentTypes
        {
            Word,
            PDF
        }

        public enum EventUpdateTypes
        {
            SavingToFile,
            LoadingFromFile,
            ParsingFromWord,
            ParsingFromPDF,
            Indexing,
            LoadingDependencies,
            DictionarySearch,
            Error
        }

        public event EventHandler<UpdateEventArgs> OnUpdate;

        public List<BookPage> PagesInBook { get; set; }
        public List<WordOnPage> RawWordList { get; set; }
        public List<WordOnPage> FilteredWordList { get; set; }
        public List<string> Warnings { get; set; }
        public Filters Filter { get; set; }
        public bool IsFiltered { get; set; }

        public List<DictionaryWord> DictionaryWords { get; set; }

        public IndexProject()
        {
            IsFiltered = false;
            Filter = new Filters();
            PagesInBook = new List<BookPage>();
            RawWordList = new List<WordOnPage>();
            FilteredWordList = new List<WordOnPage>();
            Warnings = new List<string>();
            DictionaryWords = new List<DictionaryWord>();
        }

        public List<string> GetWordList()
        {
            List<string> list = new List<string>();

            foreach (WordOnPage wop in RawWordList)
            {
                list.Add(wop.Word);
            }

            return list;
        }

        public System.Windows.Forms.AutoCompleteStringCollection GetAutoCompleteList()
        {
            System.Windows.Forms.AutoCompleteStringCollection list = new System.Windows.Forms.AutoCompleteStringCollection();

            foreach (WordOnPage wop in RawWordList)
            {
                list.Add(wop.Word);
            }

            return list;
        }

        public async Task<bool> ProcessIt(string DocumentToLoad, string ProjectFileToCreate, DocumentTypes docType, bool DictionaryMatch, bool ExcludeNumberWords)
        {
            var ret = true;

            await Task.Run(() =>
            {
                try
                {
                    /*
                    label1.Text = "Loading Dictionary...";
                    System.Windows.Forms.Application.DoEvents();

                    DataSet ds = RunQuery("SELECT Word, Definition FROM tblWord");

                    label1.Text = "Extracting Word List...";
                    System.Windows.Forms.Application.DoEvents();

                    dictionaryWords = new List<DictionaryWord>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dictionaryWords.Add(new DictionaryWord(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                    }
                    */

                    int PageNum = 0;

                    if (docType == DocumentTypes.Word)
                    {

                        /* // --- Currently disabling Word Interop because of strange errors --- //
                        FireUpdateEvent(EventUpdateTypes.LoadingDependencies, "Word Interop Application", 0, 0, 0);

                        string filePath = DocumentToLoad;

                        object file = filePath;
                        object nullobj = System.Reflection.Missing.Value;
                        object falseobj = false;
                        object read_only = true;

                        Microsoft.Office.Interop.Word.ApplicationClass wordApp = new Microsoft.Office.Interop.Word.ApplicationClass();

                        FileInfo fileInfo = new FileInfo(filePath);

                        string fileName = filePath.Substring(filePath.LastIndexOf('\\'));
                        fileName = "~" + fileName;


                        Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Open(ref file, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                            ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj);

                        Microsoft.Office.Interop.Word.WdStatistic stat = Microsoft.Office.Interop.Word.WdStatistic.wdStatisticPages;
                        PageNum = document.ComputeStatistics(stat, ref nullobj);

                        //returnval = new DOCXStructure[PageNum];

                        StringBuilder sb = new StringBuilder();
                        PagesInBook = new List<BookPage>();

                        string thisPageText = "";
                        string lastPageText = "";

                        for (int i = 0; i < PageNum; i++)
                        {                                            
                            FireUpdateEvent(EventUpdateTypes.ParsingFromWord, "Page", PageNum, i, Warnings.Count());

                            sb = new StringBuilder();

                            object what = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPage;
                            object which = nullobj;
                            object count = i + 1;
                            object name = nullobj;
                            object Page = "\\Page";

                            wordApp.Selection.GoTo(ref what, ref which, ref count, ref name);

                            Microsoft.Office.Interop.Word.Range range = document.Bookmarks.get_Item(ref Page).Range;

                            thisPageText = range.Text.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ").Replace("\t", " ").Replace("  ", " ");

                            if (thisPageText == lastPageText && thisPageText.Trim() != "")
                            {
                                Warnings.Add("The text of page " + i.ToString() + " matches that of the previous page.");
                            }

                            PagesInBook.Add(new BookPage(thisPageText));

                            lastPageText = thisPageText;

                        }

                        document.Close(ref falseobj, ref nullobj, ref nullobj);
                        wordApp.Quit(ref falseobj, ref nullobj, ref nullobj);
                        */
                        throw new Exception("Word Interop is currently not supported");
                    }

                    if (docType == DocumentTypes.PDF)
                    {

                        PagesInBook = new List<BookPage>();

                        using (PdfReader reader = new PdfReader(DocumentToLoad))
                        {
                            int maxPages = reader.NumberOfPages;
                            PageNum = reader.NumberOfPages;

                            StringBuilder text = new StringBuilder();

                            for (int x = 1; x <= reader.NumberOfPages; x++)
                            {
                                FireUpdateEvent(EventUpdateTypes.ParsingFromPDF, "Page: " + x.ToString(), maxPages, x, Warnings.Count());

                                System.Windows.Forms.Application.DoEvents();

                                PagesInBook.Add(new BookPage(PdfTextExtractor.GetTextFromPage(reader, x)));
                            }
                        }

                    }

                    List<WordOnPage> index = new List<WordOnPage>();

                    int pageCount = 0;
                    int pageTotal = PagesInBook.Count();
                    // Loop through all of the pages
                    foreach (BookPage bp in PagesInBook)
                    {
                        pageCount++;

                        FireUpdateEvent(EventUpdateTypes.Indexing, "Page: " + pageCount.ToString(), pageTotal, pageCount, Warnings.Count());

                        // Loop through all of the Words on the page
                        foreach (string word in bp.Words)
                        {
                            bool foundInIndex = false;

                            bool doit = true;

                            if (ContainsNumber(word) && ExcludeNumberWords) doit = false;

                            if (doit)
                            {

                                // Loop through our existing Index
                                foreach (WordOnPage wop in index.Where(x => x.Word.ToLower().Trim() == word.ToLower().Trim()))
                                {
                                    // the Word is found in the index

                                    foundInIndex = true;
                                    bool pageAlreadyMarked = false;

                                    // Loop through the pages this word is found on
                                    foreach (PageClass page in wop.Page.Where(p => p.Page == pageCount))
                                    {
                                        pageAlreadyMarked = true;
                                        break;
                                    }

                                    // If this page was not marked for this word
                                    if (!pageAlreadyMarked)
                                    {
                                        // add the page mark
                                        wop.Page.Add(new PageClass(pageCount));
                                    }

                                    break;

                                }

                                // If the word was not found in the index
                                if (!foundInIndex)
                                {
                                    WordOnPage nwop = new WordOnPage();
                                    nwop.Word = word.Trim();
                                    //nwop.WordType = GetWordType(nwop.Word);
                                    nwop.Page = new List<PageClass>();
                                    nwop.Page.Add(new PageClass(pageCount));
                                    index.Add(nwop);
                                }
                            }
                        }
                    }

                    RawWordList = index.OrderBy(p => p.Word).ToList();

                    int c = 0;

                    if (DictionaryMatch)
                    {

                        foreach (WordOnPage wop in RawWordList)
                        {
                            c++;

                            FireUpdateEvent(EventUpdateTypes.DictionarySearch, wop.Word, RawWordList.Count, c, Warnings.Count());
                            
                            bool found = false;
                            foreach (DictionaryWord dic in DictionaryWords.Where(x => x.Word.ToLower().Trim() == wop.Word.ToLower().Trim()))
                            {
                                wop.WordType = dic.WordType;
                                found = true;
                                break;
                            }

                            if (!found)
                            {
                                wop.WordType = "Unknown";
                            }

                        }
                    }

                    List<WordOnPage> finalList = new List<WordOnPage>();

                    StringBuilder stb = new StringBuilder();
                    foreach (WordOnPage wop in RawWordList)
                    {

                        //if (wop.)
                        //{

                        //    finalList.Add(wop);
                        //    //StringBuilder sbpages = new StringBuilder();
                        //    //foreach (int page in wop.Page)
                        //    //{
                        //    //    sbpages.Append(page.ToString() + ", ");
                        //    //}
                        //    //stb.AppendLine(wop.Word + " - " + sbpages.ToString());
                        //}

                    }

                    Serialize(ProjectFileToCreate, this);

                }
                catch (Exception ex)
                {
                    FireUpdateEvent(EventUpdateTypes.Error, ex.Message, 0, 0, 0);
                }
            });

            return ret;
        }

        public void FireUpdateEvent(EventUpdateTypes eventType, string message, int progressMax, int progressCurrent, int warningCount)
        {
            
            UpdateEventArgs e = new UpdateEventArgs();
            e.eventType = eventType;
            e.message = message;
            e.progressMax = progressMax;
            e.progressCurrent = progressCurrent;
            e.warningCount = warningCount;
            OnUpdate(this, e);
           
        }

        
        /// <summary>
        /// Serializes the Project in an Obfuscated Manner
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="objectToSerialize"></param>
        public void Serialize(string filename, IndexProject objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();                       
        }

        /// <summary>
        /// Deserializes the Project 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static IndexProject DeSerialize(string filename)
        {
            IndexProject objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (IndexProject)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }

        /// <summary>
        /// Deserializes a List of BookPage
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static List<BookPage> DeSerializeBookPageList(string filename)
        {
            List<BookPage> objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (List<BookPage>)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }

        private bool ContainsNumber(string what)
        {
            return Regex.IsMatch(what, @"\d", RegexOptions.IgnoreCase);
        }

        private string GetWordType(string word)
        {
            string type = "Unknown";

            var wordMatch = from dw in DictionaryWords
                            where dw.Word == word.ToLower().Trim()
                            select dw;

            bool found = false;
            foreach (DictionaryWord dic in wordMatch)
            {
                type = dic.WordType;
                found = true;
                break;
            }

            if (!found)
            {
                type = "Unknown";
            }

            return type;
        }

    }

}
