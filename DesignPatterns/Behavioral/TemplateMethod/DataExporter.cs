using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            FetchData();
            FormatData();
            Save();
        }

        protected abstract void Connect();
        protected abstract void FetchData();
        protected abstract void FormatData();

        protected virtual void Save()
        {
            Console.WriteLine("Saving data to disk...");
        }

    }
}
