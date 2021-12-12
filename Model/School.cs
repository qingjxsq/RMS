using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class School
    {
       public string Name;
       public string Major;
        public string[] Majors;
        public void MajorToArr()//将Major转化为数组
        {
            this.Majors = this.Major.Split('-');

        }
        public void SetMajor()
        {
            Major = "";
            foreach(string s in Majors)
            {
                this.Major = s + "-";
            }
        }
    }
}
