using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        //Console.WindowWidth = 200;
        int pixSize = 3;
        Bitmap image = new Bitmap(@"C:\Users\user\Downloads\photo1719934183.jpeg"); // Путь к изображению
        string res = "";
        for (int y = 0; y < image.Height; y += pixSize)
        {
            for (int x = 0; x < image.Width; x += pixSize)
            {
                int brightness = 0;

                // Подсчет яркости фрагмента 5 на 5 пикселей
                for (int j = y; j < y + pixSize; j++)
                {
                    for (int i = x; i < x + pixSize; i++)
                    {
                        if(i >= image.Width || j >= image.Height)
                        {
                            break;
                        }
                        else
                        {
                            Color pixel = image.GetPixel(i, j);
                            brightness = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        }
                    }
                }

                if (brightness < 64) // Пороговое значение для определения темного или светлого фрагмента
                {
                    //Console.BackgroundColor = ConsoleColor.Black;
                    //Console.Write(" "); // Темный фрагмент
                    res += "0";
                }
                else if (brightness >= 64 && brightness < 128)
                {
                    res += "1";
                }
                else if (brightness >= 128 && brightness < 192)
                {
                    res += "2";
                }
                else
                {
                    //Console.BackgroundColor = ConsoleColor.White;
                    //Console.Write(" "); // Светлый фрагмент
                    res += "3";
                }
            }
            //Console.WriteLine();
            res += "\n";
        }
        using (FileStream fs = new FileStream($"C://Users/{Environment.UserName}/Desktop/Kaji.txt", FileMode.OpenOrCreate))
        {
            byte[] input = Encoding.Default.GetBytes(res);
            fs.Write(input, 0, input.Length);
            Console.WriteLine("Текст записан в файл");
        }
        Console.ReadKey();
    }
}