namespace _27._06._24_HW
{
    internal class Program
    {
        // Task 1
        public enum ClientType
        {
            Normal,
            VIP,
            Diamond
        }


        struct Client
        {
            public int _code, _orders;
            public string _name, _phone, _address;
            public double _amount;
            public ClientType _type;

            public Client(int Code, string Name, string Address, string Phone, int Orders, double Amount, ClientType Type)
            {
                _code = Code;
                _name = Name;
                _address = Address;
                _phone = Phone;
                _orders = Orders;
                _amount = Amount;
                _type = Type;
            }

            public void Print() => Console.WriteLine($"Code: {_code}\nName: {_name}\nAdress: {_address}\nPhone number: {_phone}\nOrder: {_orders}\nSum: {_amount}\n Type: {_type}");
        }


        // Task 2
        public static int sumInRange(int startIndex, int endIndex, int[] arr)
        {
            int sumInRange = arr.Skip(startIndex).Take(endIndex - startIndex + 1).Sum();
            return sumInRange;
        }


        // Task 3
        public class Airplane
        {
            public string _name;
            public string _manufacturer;
            public int _year;
            public string _type;

            public Airplane(string name, string manufacturer, int year, string type)
            {
                _name = name;
                _manufacturer = manufacturer;
                _year = year;
                _type = type;
            }

            public string GetName() { return _name; }
            public void SetName(string value) { _name = value; }

            public string GetManufacturer() { return _manufacturer; }
            public void SetManufacturer(string value) { _manufacturer = value; }

            public int GetYear() { return _year; }
            public void SetYear(int value) { _year = value; }

            public string GetType() { return _type; }
            public void SetType(string value) { _type = value; }

            public string NameProperty
            {
                get { return _name; }
                set { _name = value; }
            }

            public string ManufacturerProperty
            {
                get { return _manufacturer; }
                set { _manufacturer = value; }
            }

            public int YearProperty
            {
                get { return _year; }
                set { _year = value; }
            }

            public string TypeProperty
            {
                get { return _type; }
                set { _type = value; }
            }

            public string AutoName { get; set; }
            public string AutoManufacturer { get; set; }
            public int AutoYear { get; set; }
            public string AutoType { get; set; }
        }


        // Task 4
        public class Journal
        {
            private string _name;
            private int _year;
            private string _description;
            private string _number;
            private string _email;

            public Journal(string name, int year, string description, string number, string email)
            {
                _name = name;
                _year = year;
                _description = description;
                _number = number;
                _email = email;
            }

            public Journal()
            {
                _name = "Unknown";
                _year = DateTime.Now.Year;
                _description = "Unknown";
                _number = "Unknown";
                _email = "Unknown";
            }

            public string GetName() { return _name; }
            public void SetName(string value) { _name = value; }

            public int GetYear() { return _year; }
            public void SetYear(int value) { _year = value; }

            public string GetDescription() { return _description; }
            public void SetDescription(string value) { _description = value; }

            public string GetNumber() { return _number; }
            public void SetNumber(string value) { _number = value; }

            public string GetEmail() { return _email; }
            public void SetEmail(string value) { _email = value; }

            public string NameProperty
            {
                get { return _name; }
                set { _name = value; }
            }

            public int YearProperty
            {
                get { return _year; }
                set { _year = value; }
            }

            public string DescriptionProperty
            {
                get { return _description; }
                set { _description = value; }
            }

            public string NumberProperty
            {
                get { return _number; }
                set { _number = value; }
            }

            public string EmailProperty
            {
                get { return _email; }
                set { _email = value; }
            }

            public void InputData()
            {
                Console.WriteLine("Enter the journal's name:");
                _name = Console.ReadLine();

                Console.WriteLine("Enter the founding year:");
                _year = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the description of the journal:");
                _description = Console.ReadLine();

                Console.WriteLine("Enter the contact phone number:");
                _number = Console.ReadLine();

                Console.WriteLine("Enter the contact email:");
                _email = Console.ReadLine();
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Foundation year: {_year}");
                Console.WriteLine($"Description: {_description}");
                Console.WriteLine($"Contact phone: {_number}");
                Console.WriteLine($"Contact e-mail: {_email}");
            }
        }




        static void Main(string[] args)
        {
            // Task 1
            Client client = new Client(1, "Bogdan Bogdan", "Glasower str. 60", "+380984758311", 2, 30000, ClientType.VIP);
            client.Print();
            

            // Task 2
            int start = 1;
            int end = 4;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum in range = {sumInRange(start, end, arr)}");


            // Task 3
            Airplane airplane = new Airplane("Boeing 747-400 LCF Dreamlifter", "Boeing", 2007, "Cargo");
            Console.WriteLine($"Name: {airplane._name}");
            Console.WriteLine($"Factory: {airplane._manufacturer}");
            Console.WriteLine($"Release year: {airplane._year}");
            Console.WriteLine($"Type: {airplane._type}");


            // Task 4
            Journal journal = new Journal();
            journal.InputData();
            journal.PrintInfo();
        }
    }
}