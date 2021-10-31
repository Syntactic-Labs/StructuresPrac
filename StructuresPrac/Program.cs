//alias
using cw = System.Console;

namespace StructuresPrac
{
    struct Employee {
     //instance variables (private by default)
        string name;
        int eid;
        double sal;
     // instance method 1
        public void input(string name, int eid, double sal) {
            this.name = name;
            this.eid = eid;
            this.sal = sal;
        }
     // instance method 2
        void disp() {
            cw.WriteLine($"Emp.Name     :{name}");
            cw.WriteLine($"Emp.Id       :{eid}");
            cw.WriteLine($"Emp.Salary   :{sal}");

        }
     // The main event
        static void Main() {
     //creating an object like class
            Employee emp = new Employee();
     //calling instance methods using object
            emp.input("Todd", 99, 98000.25);
            emp.disp();
        }
    }
}
