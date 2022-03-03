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

        public static float InputFloat(string value, string message = "値を入力してください" )
        {
            float i;
            while (true)
            {
                Console.WriteLine(message);
                if (float.TryParse(InputString(value), out i))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー！");
                }

            }
            return i;
        }
    }
}
