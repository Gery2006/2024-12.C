using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gettersetter
{
    class Person
    {
        public Person() { }
        public string Name { get; set; }
        private int id;
        public int Id { get => id; set => id = 101; }
        private int age;
        public void setAge(int age) {this.age= age;}

        private int gender;
        public void getrender(string gender)
        {
            switch (gender)
            {
                case "Férfi":
                    this.gender = 1;
                    break;

                case "Nő":
                    this.gender = 2;
                    break;

                default: this.gender = 3;
                    break;
            }
        }
        public string getGender()
        {
            switch (this.gender)
            {
                case 1: return "Férfi";
                case 2: return "Nő";
                default: return "ismeretlen";
            }
        }
    }
}
