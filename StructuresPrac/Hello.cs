//alias
using cw = System.Console;

namespace StructuresPrac {
    struct Hello {
        string pname;
        int pid;
        //instance parameterized constructor. Structure supports only parameterized constructor now
        public Hello(string name, int id) {
            this.pname = name;
            this.pid = id;
        }
        public void msg() {
            cw.WriteLine($"Person Name :{pname}");
            cw.WriteLine($"Person Number :{pid}");

        }
        //Main method
        static void Main() {
            cw.WriteLine("Parameterized Constructor in C# Structures");
            //object creation and calling parameterized constuctor like class
            Hello ss = new Hello("Todd", 29);
            ss.msg();
        }
    } 
}
