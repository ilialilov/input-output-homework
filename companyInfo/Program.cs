using System;


namespace companyInfo
{
    class Program
    {
        static void Main()
        {
            string cName = Console.ReadLine();
            string cAddress = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = Console.ReadLine();
            string web = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string personalPhone = Console.ReadLine();
            if (fax == "")
                fax = "(no fax)";
            Console.WriteLine(cName);
            Console.WriteLine("Address: " + cAddress);
            Console.WriteLine("Tel. " + phone);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("Web site: " + web);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, personalPhone);
            
        }
    }
}
