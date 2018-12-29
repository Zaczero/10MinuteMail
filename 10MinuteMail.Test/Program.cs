using System.Diagnostics;

namespace _10MinuteMail.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmm = new TenMinuteMail();

            var email = tmm.GetEmail().Result;
            var messages = tmm.GetMessages().Result;

            Debugger.Break();
        }
    }
}
