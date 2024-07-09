/*
using AppConfigUnderstanding;
DelegateTester tester = new DelegateTester();

CallBack handler = new CallBack(tester.DisplayMessge);
CallBack2 handler2 = new CallBack2(tester.DisplayMessge);
Delegate handle = new CallBack(tester.DisplayMessge);

Console.WriteLine(handler == handle);



int invocationCount = handler.GetInvocationList().Length;
Console.WriteLine(invocationCount);






class DelegateTester
{
   

    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
    public static void MethodWithCallback(int param1, int param2, CallBack callback)
    {
        if (callback != null) {callback("The number is: " + (param1 + param2).ToString()); }
        
    }
    public void DisplayMessge(string message)
    {
        Console.WriteLine(message + "Output from Display Message.");
    }
    public void CheckMethod(string message)
    {
        Console.WriteLine(message + " : Output from CheckMethod");

    }

}*/

// Declare a delegate
using AppConfigUnderstanding.Services;

delegate void MultiplyCallback(int i, double j);

class MathClass 
{
    static void Main()
    {
        //  MathClass m = new MathClass();

        CSharpModule module = new CSharpModule();
        Console.WriteLine(module.GetMessage());
        Console.WriteLine(module.Comparator("Rashid", "Rashid"));




        
/*
        // Delegate instantiation using "MultiplyNumbers"
        MultiplyCallback d = m.MultiplyNumbers;
        

        // Invoke the delegate object.
        Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i <= 5; i++)
        {
            d(i, 2);
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();*/
    }

    public string GetMessage()
    {
        return "inteface method0";
    }

    // Declare the associated method.
    void MultiplyNumbers(int m, double n)
    {
        Console.Write(m * n + " ");
    }
}
