using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern\n");

            SubjectAccessor.ISubject subject = new SubjectAccessor.Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            subject = new SubjectAccessor.ProtectionProxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine((subject as SubjectAccessor.ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((subject as SubjectAccessor.ProtectionProxy).Authenticate("Abracadabra"));
            Console.WriteLine(subject.Request());

            Console.ReadLine();
        }
    }
}
