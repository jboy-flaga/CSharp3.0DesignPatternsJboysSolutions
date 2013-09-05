using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            TextMessage message = new TextMessage();
            message.Message = Console.ReadLine();

            TextMessage caesarsCipherEncryptor = new CaesarsCipherEncryptor(message, 7);
            Console.WriteLine("Encrypting message: " + caesarsCipherEncryptor.Message);

            TextMessage caesarsCipherDecryptor = new CaesarsCipherDecryptor(caesarsCipherEncryptor, 7);
            Console.WriteLine("Decrypting message: " + caesarsCipherDecryptor.Message);

            Console.ReadLine();
        }
    }
}
