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
        public string[] MajorToList()//将Major转化为列表
        {
            string[] strArr = this.Major.Split('-');
            return strArr;

        }
        public void SetMajor(string[] str)
        {
            foreach(string s in str)
            {
                this.Major = s + "-";
            }
        }
    }
}
