﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.4f);
            book.AddGrade(12);
            GradeStatiscs stats = book.ComputeStatistics();
            Console.WriteLine("Average grade {0}", stats.AverageGrade);
            Console.WriteLine("Highest grade {0}",stats.HighestGrade);
            Console.WriteLine("Lowest grade {0}",stats.LowestGrade);
        }
    }
}
