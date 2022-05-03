using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLesson
{
    class CPerson
    {
        private string? lastName;
        private string? name;
        private string? middleName;


        public string? LastName
        { get { return lastName; } set { lastName = value; } }


        public string? Name
        { get { return name; } set { name = value; } }


        public string? MiddleName
        { get { return middleName; } set { middleName = value; } }



        public virtual void ShowData()
        {

            Console.WriteLine (lastName + " " + name + " " + middleName);
            
        }
    }
}

