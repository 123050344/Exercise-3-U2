
namespace Exercise_3_U2
{
    class program
    {
        static void Main(string[] args)
        {

            create_person person =new create_person();
            person.c_person(2346578,12/03/02, 19);

            Console.WriteLine("~Data of a person~");
            Console.WriteLine("Number: " + person.Number);
            Console.WriteLine("fecha de nacimiento: " + person.Fecha_nacimiento);
            Console.WriteLine("Age: " + person.Age);

            school_data data = new school_data();
            data.s_data(23050489, 12);

            Console.WriteLine("~School data~");
            Console.WriteLine("tuition: " + data.Tuition);
            Console.WriteLine("Number list: " + data.Num_list);

            Console.ReadKey();

        } 

    }

}

