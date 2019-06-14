using System;

namespace csharp_mongo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            /*// 1. Create a record and save to mongodb
            PersonModel person = new PersonModel
            {
                FirstName = "Chimmy",
                LastName = "JK",
                PrimaryAddress = new AddressModel
                {
                    StreetAddress = "101 Oak Street",
                    City = "Georgia",
                    State = "PA",
                    ZipCode = "10000"
                }
            };
            db.InsertRecord("Users", person);*/


            /* // 2. Load data and print
            var recs = db.LoadRecords<PersonModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{ rec.Id }: { rec.FirstName } { rec.LastName }");

                if (rec.PrimaryAddress != null)
                {
                    Console.WriteLine(rec.PrimaryAddress.City);
                }
            }*/

            /* // 3. Update and delete record
            var onerec = db.LoadRecordById<PersonModel>("Users", 
                new Guid("83290201-3a39-4c07-a711-8041eb149992"));
            onerec.DateOfBirth = 
                new DateTime(1990, 5, 20, 0, 0, 0, DateTimeKind.Utc);
            db.UpsertRecord("Users", onerec.Id, onerec);
            db.DeleteRecord<PersonModel>("Users", onerec.Id);*/

            /* // 4. Test BsonIgnoreExtraElements
            var recs = db.LoadRecords<NameModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{ rec.FirstName } { rec.LastName }");
            }*/


            Console.ReadLine();
        }
    }
}
