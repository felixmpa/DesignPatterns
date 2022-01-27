using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person()
        {

        }

        public Person(int age, DateTime birthDate, string name)
        {
            this.Age = age;
            this.BirthDate = birthDate;
            this.Name = name;
        }

        public Person(int age, DateTime birthDate, string name, IdInfo info)
        {
            this.Age = age;
            this.BirthDate = birthDate;
            this.Name = name;
            this.IdInfo = info;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name   = String.Copy(Name);
            return clone;
        }

    }
}
