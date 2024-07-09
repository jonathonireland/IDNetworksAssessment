// See https://aka.ms/new-console-template for more information

List<int> ages = new List<int>();
List<string> people = new List<string>();
List<string> flags = new List<string>();
List<string> cities = new List<string>();
List<string> genders = new List<string>();
List<string> students = new List<string>();
List<string> employees = new List<string>();

int age = 0;
string name;
string flag;
string city;
bool isFemale;
string gender; 
bool isStudent;
string student;
bool isEmployee;
string employee;
int @continue;

do
{
    Console.Write("Enter Person's Name: ");
    name = Console.ReadLine();
    people.Add(name);

    Console.Write("Enter Person's age (or -1 if unknown):");
    age = Convert.ToInt32(Console.ReadLine());
    ages.Add(age);

    Console.Write("Enter Persons's City: ");
    city = Console.ReadLine();
    cities.Add(city);

    Console.Write("Female (Y or N):");
    gender = Console.ReadLine();
    genders.Add(gender);

    Console.Write("Enter Person's Student Status (Y or N):");
    student = Console.ReadLine();
    students.Add(student);

    Console.Write("Enter Person's Employee Status (Y or N):");
    employee = Console.ReadLine();
    employees.Add(employee);

    Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
}
while (@continue == 1);

// Print values in list - for
for (int i = 0; i < ages.Count; i++)
{
    Console.WriteLine($"(Name){people[i]}\n");
    Console.WriteLine($"(Age){ages[i]}\n");
    Console.WriteLine($"(City){cities[i]}\n");
    Console.WriteLine($"(Flags){genders[i]}{students[i]}{employees[i]}\n");
    Console.WriteLine("\n");
}
