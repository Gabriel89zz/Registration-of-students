using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registration_of_students
{
    internal class People
    {
		protected string fullname;

		public string FullName
		{
			get { return fullname; }
			set { fullname = value; }
		}

		protected string age;

		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		protected string number;

		public string Number
		{
			get { return number; }
			set { number = value; }
		}

        public People()
        {
			fullname = "";
			age = "";
			number = "";
        }
        virtual public void GetInfo()
        {
		    MessageBox.Show($"Name: {fullname}\nAge: {age}\nPhone number: {number}");
		}
    }
}
