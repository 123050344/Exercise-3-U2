using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_U2
{
    public class create_person
    {
        private int number;
        public int fecha_nacimiento;
        public int age;

       
        public int Age { get => age; set => age = value; }
        public int Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Number { get => number; set => number = value; }

        public void c_person (int _number, int _fechanacimiento, int _age)
        {
            this.number = _number;
            this.fecha_nacimiento = _fechanacimiento;
            this.age = _age;
        }
    }
}
