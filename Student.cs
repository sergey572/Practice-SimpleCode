namespace Practice
{
    //строки 530-547 из файла MainSpace.cs
    internal class Student
    {
        public Student(string lastName,DateTime birthday)
        {
            
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
        {
            this.middleName = middleName;
            this.birthday = birthday;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nОтчество: {middleName}\nДата рождения: {birthday}");
        }

    }
}



