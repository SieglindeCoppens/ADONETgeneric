using System;

namespace ADONETgeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DbProviderFactories.RegisterFactory("sqlserver", SqlClientFactory.Instance);
            string connectionString = 
        }
    }
}
