﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Person
    {
        string name;
        int age;
        string gender;
        public Person(string n, int a, string g)
        {
            name = n;
            age = a;
            gender = g;
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (name.Equals(person.Name))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

        public override string ToString()
        {
            return name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}