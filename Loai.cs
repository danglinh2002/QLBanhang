using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE4QLHANGHOA_ADO
{
    class Loai
    {
        public int maloai { get; set; }
        public string tenloai { get; set; }
        public string mahangsx { get; set; }
        public override string ToString()
        {
            return tenloai + "," + mahangsx;
        }
   
    }
}
