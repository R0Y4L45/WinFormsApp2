
namespace WinFormsApp1
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Telephone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

        public Person() { }


        public Person(string? name, string? surname, string? fatherName, string? country, string? city, string? telephone, DateTime birthDate, bool gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Telephone = telephone;
            BirthDate = birthDate;
            Gender = gender;
        }
    }
}
