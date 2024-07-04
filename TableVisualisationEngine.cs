using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_info_app
{
    public class TableVisualisationEngine
    {
        public static void ShowTable<T>(List<T> tabledata, [AllowNull] string tablename) where T : class
        {
            Console.Clear();
            if (tablename == null)
                tablename = "";

            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tabledata)
                .WithColumn(tablename)
                .ExportAndWriteLine();
            Console.WriteLine("\n\n");
        }
    }
}
