using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_U2
{
    public class school_data : create_person
    {
        private int tuition;
        private int num_list;

        public int Tuition { get => tuition; set => tuition = value; }
        public int Num_list { get => num_list; set => num_list = value; }

        public void s_data(int _tuition, int _numlist)
        {
            this.tuition = _tuition;
            this.num_list = _numlist;
        }
    }
}
