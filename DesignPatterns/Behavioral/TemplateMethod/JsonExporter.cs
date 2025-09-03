using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class JsonExporter : DataExporter
    {
        protected override void Connect() =>
                Console.WriteLine("Connecting to API for JSON export...");

        protected override void FetchData() =>
            Console.WriteLine("Fetching data for JSON...");

        protected override void FormatData() =>
            Console.WriteLine("Formatting data as JSON...");

    }
}
