using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class InputClass
    {
        public static string InputString(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float InputFloat(string message = "値を入力してください")
        {
            //Console.WriteLine(message);
            float i;
            while (true)
            {
                if (float.TryParse(InputString(message), out i))
                {
                    break;
                }
              
            }
            return i;
        }
    }
}
