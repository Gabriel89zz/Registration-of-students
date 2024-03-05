using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration_of_students
{
    internal class Students:People
    {
		private string id;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public Students():base()
        {
            id = "";
        }
        public override void GetInfo()
		{
            MessageBox.Show($"Name: {fullname}\nAge: {age}\nPhone number: {number}\nId: {id}");
        }
	}
}
