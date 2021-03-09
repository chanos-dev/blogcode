using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0310
{
    class Program
    {
        static void Main(string[] args)
        { 
            var person1 = new NormalPerson()
            {
                PersonalID = "1",
                Name = "홍길동",
                Age = 24,
            };

            var person2 = new NormalPerson()
            {
                PersonalID = "1",
                Name = "이몽룡",
                Age = 25,
            }; 

            var person3 = person1;

            Console.WriteLine("=== NormalPerson ===");
            Console.WriteLine($"person1 : {person1.ToString()}");
            Console.WriteLine($"person2 : {person2.ToString()}");
            Console.WriteLine($"person3 : {person3.ToString()}");
            Console.WriteLine($"person1 == person 2 : {person1.Equals(person2)}");
            Console.WriteLine($"person1 == person 3 : {person1.Equals(person3)}");
            Console.WriteLine(""); 

            var ePerson1 = new EqualsPerson()
            {
                PersonalID = "1",
                Name = "홍길동",
                Age = 24,
            };

            var ePerson2 = new EqualsPerson()
            {
                PersonalID = "1",
                Name = "이몽룡",
                Age = 25,
            };

            var ePerson3 = ePerson1;

            Console.WriteLine("=== EqualsPerson ===");
            Console.WriteLine($"ePerson1 : {ePerson1.ToString()}");
            Console.WriteLine($"ePerson2 : {ePerson2.ToString()}");
            Console.WriteLine($"ePerson3 : {ePerson3.ToString()}");
            Console.WriteLine($"ePerson1 == ePerson 2 : {ePerson1.Equals(ePerson2)}");
            Console.WriteLine($"ePerson1 == ePerson 3 : {ePerson1.Equals(ePerson3)}"); 
        }
    }

    class NormalPerson
    {
        public string PersonalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"PersonalID : {PersonalID}, Name : {Name}, Age : {Age}";
    }

    class EqualsPerson : IEquatable<EqualsPerson>
    {
        public string PersonalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }              

        public override bool Equals(object obj)
        {
            return this.Equals(obj as EqualsPerson);
        }

        public bool Equals(EqualsPerson other)
        {
            if (other is null)
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            return this.PersonalID == other.PersonalID;
        }

        public static bool operator ==(EqualsPerson left, EqualsPerson right)
        {
            if (left is null)
            {
                if (right is null) 
                    return true; 

                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(EqualsPerson left, EqualsPerson right) => !(left == right);

        public override int GetHashCode()
        {
            var hashCode = 1345254698;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PersonalID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }

        public override string ToString() => $"PersonalID : {PersonalID}, Name : {Name}, Age : {Age}";
    }
}
