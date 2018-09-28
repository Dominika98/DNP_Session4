using System;
using System.Runtime.Serialization;
namespace Ex2_serialization_
{
[DataContract]
class Person2
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Ssn { get; set; }
        
        public Person2(string FirstName, string LastName, int Ssn){
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.Ssn=Ssn;
        }
    }
}