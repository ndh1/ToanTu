using System;

namespace Bai6_ToanTu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string strsonguyen;
            int songuyen;
            string ketqua;

            strsonguyen = Console.ReadLine();
            songuyen = Int32.Parse(strsonguyen);
            ketqua = (songuyen % 2 == 0) ? "So chan" : "sole";
            Console.WriteLine("{0} la {1}", songuyen, ketqua);

        }
    }
}
