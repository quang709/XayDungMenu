using System;

namespace Xây_dựng_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice = 8;
            double length = 0, width = 0, side = 0, radius = 0;
            while (choice != 0)
            {
                Console.WriteLine("1. Khởi tạo hình vuông");
                Console.WriteLine("2. Khởi tạo hình chữ nhật");
                Console.WriteLine("3. Khởi tạo hình tròn");
                Console.WriteLine("4. In ra diện tích và chu vi hình vuông");
                Console.WriteLine("5. In ra diện tích và chu vi hình chữ nhật");
                Console.WriteLine("6. In ra diện tích và chu vi hình tròn.");
                Console.WriteLine("7. Kết thúc");
                Console.Write("Chọn chức năng: ");
                Shape s = new Shape();
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Nhập cạnh hình vuông: ");
                        side = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Nhập chiều dài: ");
                        length = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        width = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nhập bán kính: ");
                        radius = double.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Chu vi hình vuông:" + s.AreaSquare(side));
                        Console.WriteLine("Diện tích hình vuông:" + s.PerimeterSquare(side));
                        break;
                    case 5:
                        Console.WriteLine("Chu vi hình chữ nhật:" + s.PerimeterRectangle(length, width));
                        Console.WriteLine("Diện tích hình chữ nhật:" + s.AreaRectangle(length, width));
                        break;
                    case 6:
                        Console.WriteLine("Chu vi hình tròn:" + s.PerimeterCircle(radius));
                        Console.WriteLine("Diện tích hình tròn:" + s.AreaCircle(radius));
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chọn chức năng: ");
                        break;
                }
            }
        }
    }
}