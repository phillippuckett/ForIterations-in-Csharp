using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(1);
            }
            Console.ReadLine();
            */

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(1);
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }

            //Console.ReadLine();

            int length = 15;
            for (int myValue = 0; myValue < length; myValue++) 
            {
                Console.WriteLine(myValue);
            }
            Console.ReadLine();


            //NOTE: 'break;' is a way if breaking out of a syntac
           
            /*TIP: To watch code execute VSC has a dev tool that can be accessed by 
            clicking on the left-most column (left of the line numbers), it creates a red dot. 
            
            Run the application by clicking on the green arrow on the toolbar, 
            the code will run and the debug windows (Daignostic Tools, Call Stack, Locals, Output, Autos, etc.) will activate.
            
            In the values column, in the debugger, you can see the value of "i" is 0. 
            You can also see this by hovering over "i" in the code, which can be pinned down and monitored.

            You can go line by line in your code by selecting the step-through button on the toolbar (looks like an arrow hopping over a period).

            By hovering over the red dot, you can go into settings and 
            make the 'break;' point into a conditional 'break;' point and selecting 'Conditions' and set up the desired condition.
             */
        }
    }
}
https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners/for-Iteration-Statement