using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLesson
{
    class CStudent : CPerson
    {
        private double average;

        public double Average
        { get { return average; } set { average = value; } }


        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Average Mark - {average}");

        }
    }
}
