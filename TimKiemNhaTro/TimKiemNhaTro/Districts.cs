using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhaTro
{
    public class Districts
    {
        public string name;
        public string[] commune;
        public Districts(string name, string[] list)
        {
            this.name = name;
            this.commune = list;
        }

    }

}
