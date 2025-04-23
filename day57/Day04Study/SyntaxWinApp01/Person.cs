using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp01
{
    internal class Person
    {


   
        public Person() { }

       
        public Person(string name, int age, char gender, string phone)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
        }

       
        public string Name { get; set; } 

     
        public int Age { get; set; } 
  

        public char Gender { get; set; }
        public string Phone { get; set; }

        public int BirthYear { get; set; }
        public override string ToString()
        {
            return $"Peron 객체는 이름 , {Name}\r\n" +
                $"나이, {Age}세 {BirthYear}년생\r\n성별, {Gender}자\r\n" +
                $"핸드폰, {Phone}";
        }

       
    }


}
