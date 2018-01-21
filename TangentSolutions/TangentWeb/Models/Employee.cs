namespace TangentWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool IsStaff { get; set; }
        public string PhoneNumber { get; set; }
        public string GithubUser { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int YearsWorked { get; set; }
        public int Age { get; set; }
        public int DaysToBirthday { get; set; }

        public Position Position { get; set; }
    }

    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int Sort { get; set; }
    }
}

//public class Rootobject
//{
//    public Class1[] Property1 { get; set; }
//}

//public class Class1
//{
//    public User user { get; set; }
//    public Position position { get; set; }
//    public string phone_number { get; set; }
//    public string email { get; set; }
//    public string github_user { get; set; }
//    public string birth_date { get; set; }
//    public string gender { get; set; }
//    public string race { get; set; }
//    public int years_worked { get; set; }
//    public int age { get; set; }
//    public int days_to_birthday { get; set; }
//}

//public class User
//{
//    public int id { get; set; }
//    public string username { get; set; }
//    public string email { get; set; }
//    public string first_name { get; set; }
//    public string last_name { get; set; }
//    public bool is_active { get; set; }
//    public bool is_staff { get; set; }
//}

//public class Position
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public string level { get; set; }
//    public int sort { get; set; }
//}
