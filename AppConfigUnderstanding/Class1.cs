using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUnderstanding
{
    
    public delegate void CallBack(string message);
    public delegate void CallBack2(string message);
   


    internal class Test
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is console app ");

        }
       
    }
}
