using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class CsvExporter : DataExporter
    {
        protected override void Connect() =>
                Console.WriteLine("Connecting to database for CSV export...");

        protected override void FetchData() =>
            Console.WriteLine("Fetching data for CSV...");

        protected override void FormatData() =>
            Console.WriteLine("Formatting data as CSV...");

    }
}
