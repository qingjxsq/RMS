using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resume
    {
        public string ID { get; set; }          //身份证号
        public string Name { get; set; }        //姓名
        public string Gender { get; set; }      //性别
        public string PoliSta { get; set; }     //政治面貌
        public string Birthday { get; set; }    //出生日期
        public string School { get; set; }      //学校
        public string Major { get; set; }       //专业
        public string Speciality { get; set; }  //特长
        public string Images { get; set; }      //照片

    }
}
