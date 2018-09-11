using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaUADEO
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();
            user1.FirstName = "Bidkar";
            user1.LastName = "Aragon";
            user1.Email = "bidkar.aragon@udo.mx";

            Console.WriteLine("Usuario: " + user1.FullName);

            var user2 = new User
            {
                FirstName = "Ofelia",
                LastName = "La del abarrote",
                Email = "ofelia@abarrote.santa.fe",
                Name = "ofelia",
                Password = "123"
            };

            Console.WriteLine("Usuario: " + user2.FullName);
            Console.Read();

        }
    }
}
