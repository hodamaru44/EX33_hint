using System;

namespace EX33_hint
{
    class Program
    {
        //先生の見ながらやりました
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(InputClass.InputFloat("幅："),
                 InputClass.InputFloat("高さ："));
            RectAngle rectAngle2 = new RectAngle(InputClass.InputFloat("幅："),
                 InputClass.InputFloat("高さ："));

            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            var rcetAngle3 = rectAngle1 + rectAngle2;
            Console.WriteLine($"rectAngle1 + rectAngle2={rcetAngle3.width},{rcetAngle3.height}");
            var rctAngle4 = rectAngle1 + rectAngle2;
            Console.WriteLine($"rectAngle1 + rectAngle2={rcetAngle3.height},{rcetAngle3.width}");
        }
    }
}
