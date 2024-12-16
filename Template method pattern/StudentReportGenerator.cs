using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern
{
    class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о студентах.");
        }
        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о студентах.");
        }
        protected override void FormatReport()
        {
            Console.WriteLine("Форматирован отчет по студентам.");
        }
    }
}
