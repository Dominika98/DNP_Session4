using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace Ex2_serialization_
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFormatter formatter=new BinaryFormatter();
            Person2 Miska=new Person2("Miśka", "Kubicz", 125);
            /*Stream stream=new FileStream("People.bin",FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Miska);
            stream.Close();*/

            MemoryStream stream=new MemoryStream();
            DataContractJsonSerializer serializer=new DataContractJsonSerializer(typeof(Person2));
            serializer.WriteObject(stream, Miska);

            stream.Position = 0;  
            StreamReader sr = new StreamReader(stream);  
            Console.Write("JSON form of Person object: ");  
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
