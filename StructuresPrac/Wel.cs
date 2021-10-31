//alias
using cw = System.Console;

namespace StructuresPrac
{
    //define structure
    struct hello {
        public void disp() {
            cw.WriteLine("welcome to c# Structures...");
        }
    }
    class Wel {
        static void Main() {
            //object creation like class
            hello obj = new hello();
            obj.disp();
        }
    }
}
