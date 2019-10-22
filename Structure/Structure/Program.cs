﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct User
    {
        public string name;
        public int age;


        public User(string n, int a)
        {
            name = n; age = a;
        }

        public void DisplayInfo()
        {

            Console.WriteLine($"name={name} age={age}");
        }
    }

    class Program
    {

     
        static void Main(string[] args)
        {

            User[] users = new User[2];
            users[0] = new User("Bob", 20);
            users[1].name = "Sam";
            users[1].age = 25;
            foreach(User user in users)
            {
                user.DisplayInfo();
            }
            User tom = new User();   
       
            int d = tom.age;

            tom.DisplayInfo();
            Console.ReadKey();
        }
    }
}
