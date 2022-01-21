using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Fredag.Codes
{
    internal class PersonModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BirthDateInDanishFormat { get; set; }
        public int Age { get; set; }
        public double TimeSpanInTotalDays { get; set; }
        public int TelephonNr { get; init; }
    }
}