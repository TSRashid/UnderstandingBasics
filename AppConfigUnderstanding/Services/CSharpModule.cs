using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUnderstanding.Services
{
    internal class CSharpModule
    {
        public string GetMessage()
        {
            return "Message from interface";

        }

        public bool Comparator(string msg1, string msg2)
        {

            
            return msg1.Equals(msg2);   
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        

    }
}
