global using H1Fredag.Codes;
global using H1Fredag.Codes.SystemIO;

//int age = 50;
//string birthDateInDanishFormat = "23-02-1971";
//double timeSpanInTotalDays = 1778.777;

//PersonModel Model = new PersonModel()
//{
//    Age = age,
//    BirthDateInDanishFormat = birthDateInDanishFormat,
//    TelephonNr = 12345678,
//    TimeSpanInTotalDays = timeSpanInTotalDays
//};
//Person p = new(Model);

//p.GetPersonalInfo(EnumPeople.Teacher);

////Person p = new("Niels", "Olesen", new DateTime(1971, 2, 23));
////Console.WriteLine(p.GetFullName());
////Console.WriteLine(p.BirthDateInDanishFormat);
////Console.WriteLine(p.Age);
////Console.WriteLine(p.TimeSpanInTotalDays);

//Person p2 = new();
//Console.WriteLine(p2.GetFullName());

//string[] h1 = new string[] { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog." };
//TECCources h1Kurser = new(h1);

//string[] h2 = new string[] { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." };
//TECCources h2Kurser = new(h2);

//if (h1Kurser.Cources != null && h2Kurser.Cources != null)
//{
//    Console.WriteLine("Antal kurser: " + h1Kurser.Cources.Count());
//    foreach (string item in h1Kurser.Cources)
//    {
//        Console.WriteLine("H1 kurser: " + item);
//    }

//    Console.WriteLine("");

//    Console.WriteLine("Antal kurser: " + h2Kurser.Cources.Count());
//    foreach (string item in h2Kurser.Cources)
//    {
//        Console.WriteLine("H2 kurser: " + item);
//    }
//}


// ----------------------------------------------------------------------------------------------------------------------------
// 2D array eksempel:
// ----------------------------------------------------------------------------------------------------------------------------
//string[,] allCourses = new string[,]
//{
//    { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog." },
//    { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." }
//};

//TECCources allCources = new(allCourses);

//int rowsIn2DArray = allCources.AllCources.GetLength(0);
//int columnCount = allCources.AllCources.GetLength(1);
//Console.WriteLine("Kurser(2) (alle, fra 2-dimensional array): ");
//for (int j = 0; j < rowsIn2DArray; j++)
//{
//    for (int k = 0; k < columnCount; k++)
//    {
//        string item = allCources.AllCources[j, k];
//        if (j == 0)
//            Console.WriteLine("    H1: " + item);
//        else
//        {
//            if(k == 0)
//                Console.WriteLine();

//            Console.WriteLine("    H2: " + item);
//        }   
//    }
//}


// ----------------------------------------------------------------------------------------------------------------------------
// Jagged array eksempel:
// ----------------------------------------------------------------------------------------------------------------------------
#region Jagged array eksempel

//string[] h1 = new string[] { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Netværk", "Clientside prog." };
//string[] h2 = new string[] { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." };

//string[][] tecKurserJagged = new string[][]
//{
//    h1,
//    h2
//};

//TECCources allCourcesJagged = new(tecKurserJagged);
//if (allCourcesJagged.AllCourcesJagged != null)
//{

//    int count = 0;
//    for (int x = 0; x < allCourcesJagged.AllCourcesJagged.Length; x++)
//    {
//        string[] array = allCourcesJagged.AllCourcesJagged[x];
//        count = count + array.Length;
//    }

//    Console.WriteLine("Antal kurser: " + count);

//    for (int x = 0; x < allCourcesJagged.AllCourcesJagged.Length; x++)
//    {
//        string[] array = allCourcesJagged.AllCourcesJagged[x];
//        for (int y = 0; y < array.Length; y++)
//        {
//            if (x == 0)
//                Console.WriteLine("    H1 Kurser: " + array[y]);
//            else
//            {
//                if (y == 0)
//                    Console.WriteLine();

//                Console.WriteLine("    H2 kurser: " + array[y]);
//            }
//        }
//    }
//}

#endregion

// Eksempel på 3D array:
//string[,,] allCourses3D = new string[,,]
//{
//    {
//        { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog." },
//        { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." }
//    },
//    {
//        { "Grundl. Prog.", "Datab. prog.", "Studieteknik", "OOP", "Computertek.", "Clientside prog." },
//        { "Db Server.", "Clinet. prog. 2", "Server sikkerhed", "OOP2", "Datab. prog. 2", "GUI prog." }
//    }
//};

// ----------------------------------------------------------------------------------------------------------------------------
// Code along øvelse 3/3 Generic list:
// ----------------------------------------------------------------------------------------------------------------------------
//List<PersonModel> people = new List<PersonModel>()
//{
//    new PersonModel() { FirstName = "Niels", LastName = "Olesen", TelephonNr = 12345678 },
//    new PersonModel() { FirstName = "Thomas", LastName = "Jensen", TelephonNr = 11111111 },
//    new PersonModel() { FirstName = "Susanne", LastName = "Hansen", TelephonNr = 22222222 },
//};

//List<PersonModel> queryPeople = people.Where(a => a.FirstName == "Susanne").ToList();
//PersonModel person = ((List<PersonModel>)queryPeople)[0];
//int tlfNr = person.TelephonNr;

////IEnumerable<PersonModel> queryPeople =
////    from item in people
////    where item.FirstName == "Niels"
////    select item;

////List<PersonModel> match = queryPeople.ToList();
////int tlf = match[0].TelephonNr;
//Console.WriteLine($"Telefonnr er : {tlfNr}");


string msg = IOHandler.HandleDir(@"TestMappe1\SubDir1\SubSubMappe", @"TestMappe1\SubDir1\Niels", CrudOperation.Update);
Console.WriteLine(msg);

//IOHandler.HandleDir(null, null, CrudOperation.Read);
//IOHandler.HandleDir(@"TestMappe1\SubDir1\Niels", null, CrudOperation.Delete);

//IOHandler.HandleFile("Niels.txt", CrudOperation.Create, null);

Console.ReadLine();