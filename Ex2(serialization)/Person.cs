using System;

[Serializable]
class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        
        public Person(string FirstName, string LastName, int Ssn){
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.Ssn=Ssn;
        }
    }