using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Fredag.Codes
{
    enum EnumPeople
    {
        Teacher,
        Students,
        OfficeWorker
    }
    internal class Person : IPeople
    {
        private string? _firstName;

        private string? _lastName;
        //public string BirthDateInDanishFormat{ get; set; }
        //public int Age { get; set; }
        //public double TimeSpanInTotalDays { get; set; }
        //public int TelephonNr { get; init; }
        public PersonModel Model { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;

            AgeConverter ac = new(birthDate);
            int age = ac.Age;

            //int age = (new AgeConverter(birthDate)).Age;


            string birthDateInDanishFormat = birthDate.ToString("dd-MM-yyyy");
            TimeSpan ts = DateTime.Now - birthDate;
            double timeSpanInTotalDays = ts.TotalDays;
            Model = new PersonModel()
            {
                Age = age,
                BirthDateInDanishFormat = birthDateInDanishFormat,
                TelephonNr = 12345678,
                TimeSpanInTotalDays = timeSpanInTotalDays
            };
        }
        public Person()
        {
            _firstName = "Thomas";
            _lastName = "Jensen";
        }
        public Person(PersonModel model)
        {
            Model = model;

            int myAge = Model.Age;
        }
        public string? GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
        public void GetPersonalInfo(EnumPeople p)
        {
            switch (p)
            {
                case EnumPeople.Teacher:
                    Console.WriteLine("You requested teacher!");
                    break;
            }
        }
        public MetodeTestModel[] MetodeTest()
        {
            MetodeTestModel[] lst = new[]
            {
                new MetodeTestModel { c = 'A', text = "Hello World!", x = 2 },
                new MetodeTestModel { c = 'B', text = "Hello Niels!", x = 3 },
                new MetodeTestModel { c = 'C', text = "Hi!", x = 4 }
            };
            return lst;
        }
    }
    internal class MetodeTestModel
    {
        public int x { get; set; }
        public string text { get; set; }
        public char c { get; set; }
    }
}