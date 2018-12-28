using System.Diagnostics;

namespace TenMinuteMail.Test
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
