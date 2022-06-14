using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Feature01
    {

        public int feature_id { get; set; }
        public string feature_name { get; set; }

        public int feature_type { get; set; }

        public Feature01(int id, string name, int type)
        {
            this.feature_id = id;
            this.feature_name = name;
            this.feature_type = type;
        }


    }
}
