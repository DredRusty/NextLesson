using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLesson
{
    class CProfessor : CPerson
    {
        private int publications;
        private string? position;
        private int age;

        public int Publications
        { get { return publications; } set { publications = value; } }

        public string? Position
            { get { return position; } set { position = value; } }

        public int Age
            { get { return age; } set { age = value; } }


        public override void ShowData()
        {

            base.ShowData();
            Console.WriteLine($"Publications - {publications}, Position - {position}, Age - {age}" );

        }
    }
}
