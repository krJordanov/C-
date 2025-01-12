﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineAClassPerson
{
   public class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get; set; }

        public void AddMember(Person person)
        {
            FamilyMembers.Add(person);
        }

        public Person GetOldestPerson()
        {
            int maxAge = FamilyMembers.Max(m => m.Age);
            return FamilyMembers.First(m => m.Age == maxAge);
        }
    }
}
