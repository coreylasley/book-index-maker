using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace BookIndexMaker
{
    public class DictionaryData
    {

        /// <summary>
        /// Used to Query an Access Database that contains Dictionary Data
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="AccessDBFile"></param>
        /// <returns></returns>
        private DataSet RunQuery(string SQL, string AccessDBFile)
        {
            DataSet myDataSet = new DataSet();

            string cs = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + AccessDBFile + ";";

            using (OleDbConnection conn = new OleDbConnection(cs))
            {
                //pass the Select statement and connection information to the initializxation constructor for the OleDBDataAdapter
                System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(SQL, conn);

                //Create a new dataset with a table : Data
                myDataSet = new System.Data.DataSet("Data");

                //Fill the dataset and table with the data retrieved by the select command
                myDataAdapter.Fill(myDataSet, "Data");                                
            }

            //return the new dataset created 
            return myDataSet;
        }

    }
}
