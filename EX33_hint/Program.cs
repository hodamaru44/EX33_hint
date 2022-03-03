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
            RectAngle rectAngle3 = new RectAngle(5,8);


            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            var rcetAngle4 = rectAngle1 + rectAngle2;
            Console.WriteLine($"rectAngle1 + rectAngle2={rcetAngle4.width},{rcetAngle4.height}");
            var rcetAngle5 = rectAngle1 + rectAngle3;
            Console.WriteLine($"rectAngle1 + rectAngle3={rcetAngle5.height},{rcetAngle5.width}");
        }
    }
}
