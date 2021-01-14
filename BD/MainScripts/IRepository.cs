using System.Collections.Generic;

namespace BD
{
    interface IRepository
    {


        bool AddUser(User newUser);

        bool AddDoc(doctors newDoc);
        bool AddPain(places_of_pain newPain);

        bool EditUserByID(User newUser);

        bool EditUserByName(User newUser, string Name);
        
        bool EditUserByNickName(User newUser, string NickName);

        bool DelUserByID(int ID);

        bool DelUserByName(string Name);
        bool DelUserByNickName(string NickName);

        IEnumerable<User> GetUsers();


        public bool AddMedicines(Medicines newMed);

        public bool EditMedByID(Medicines newMed);

        public bool EditMedByName(Medicines newMed, string Name);

        public bool DelMedByID(int ID);

        public bool DelMedByName(string Name);

        IEnumerable<Medicines> GetMedicines();


        IEnumerable<roles> GetRoles();

        List<string> GetCM();
        List<string> GetUM();
        List<string> GetSpec();
        List<string> GetBest();

        IEnumerable<doctors> Getdoc();
        List<string> GetTables();




        IEnumerable<awards> GetAwards();


        IEnumerable<places_of_pain> GetPOP();


        IEnumerable<doctors> GetDoctors();




    }
}
