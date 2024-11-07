using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;


namespace ColorCoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowWidth = 200;
            int pixSize = 3;
            int brightness = 200;
            Bitmap image = new Bitmap(@"C:\Users\user\Desktop\Sucrose\Evil_Satisfaction.png"); // Путь к изображению
            string res = "";
            for (int y = 0; y < image.Height; y += pixSize)
            {
                int maxIndex = 0;
                for (int x = 0; x < image.Width; x += pixSize)
                {
                    int lightCount = 0;
                    int redCount = 0;
                    int yellowCount = 0;
                    int greenCount = 0;
                    int cyanCount = 0;
                    int blueCount = 0;
                    int pinkCount = 0;
                    int darkCount = 0;
                    
                    Color pixel = Color.Black;
                    // Подсчет яркости фрагмента 5 на 5 пикселей
                    for (int j = y; j < y + pixSize; j++)
                    {
                        for (int i = x; i < x + pixSize; i++)
                        {
                            if (i >= image.Width || j >= image.Height)
                            {
                                break;
                            }
                            else
                            {
                                pixel = image.GetPixel(i, j);
                                if (0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B < 112) // светлый
                                    lightCount++;
                                else if (pixel.R > brightness && pixel.G < brightness / 2 && pixel.B < brightness / 2) // красный
                                    redCount++;
                                else if (pixel.R > brightness && pixel.G > brightness && pixel.B < brightness / 2) // желтый
                                    yellowCount++;
                                else if (pixel.R < brightness / 2 && pixel.G > brightness && pixel.B < brightness / 2) // зеленый
                                    greenCount++;
                                else if (pixel.R < brightness / 2 && pixel.G > brightness && pixel.B > brightness) // голубой
                                    cyanCount++;
                                else if (pixel.R < brightness / 2 && pixel.G < brightness / 2 && pixel.B > brightness) // синий
                                    blueCount++;
                                else if (pixel.R > brightness && pixel.G < brightness / 2 && pixel.B > brightness) // розовый
                                    pinkCount++;
                                else // темный
                                    darkCount++;
                            }
                        }
                    }
                    int[] colorCounts = { lightCount, redCount, yellowCount, greenCount, cyanCount, blueCount, pinkCount, darkCount };
                    maxIndex = Array.IndexOf(colorCounts, colorCounts.Max());
                    switch (maxIndex)
                    {
                        case 0:
                            res += "0";
                            break;
                        case 1:
                            res += "r";
                            break;
                        case 2:
                            res += "y";
                            break;
                        case 3:
                            res += "g";
                            break;
                        case 4:
                            res += "c";
                            break;
                        case 5:
                            res += "b";
                            break;
                        case 6:
                            res += "m";
                            break;
                        case 7:
                            res += "1";
                            break;
                    }
                }

                res += "\n";
            }
            using (FileStream fs = new FileStream($"C://Users/{Environment.UserName}/Desktop/KaijiAgain.txt", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(res);
                fs.Write(input, 0, input.Length);
                Console.WriteLine("Текст записан в файл");
            }
            Console.ReadKey();
        }
    }
}

/*
         using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        Bitmap image = new Bitmap("input_image.jpg");

        for (int y = 0; y < image.Height - 4; y += 5)
        {
            for (int x = 0; x < image.Width - 4; x += 5)
            {
                int lightCount = 0;
                int redCount = 0;
                int yellowCount = 0;
                int greenCount = 0;
                int cyanCount = 0;
                int blueCount = 0;
                int pinkCount = 0;
                int darkCount = 0;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Color pixel = image.GetPixel(x + i, y + j);

                        if (pixel.R > 200 && pixel.G > 200 && pixel.B > 200) // светлый
                            lightCount++;
                        else if (pixel.R > 200 && pixel.G < 100 && pixel.B < 100) // красный
                            redCount++;
                        else if (pixel.R > 200 && pixel.G > 200 && pixel.B < 100) // желтый
                            yellowCount++;
                        else if (pixel.R < 100 && pixel.G > 200 && pixel.B < 100) // зеленый
                            greenCount++;
                        else if (pixel.R < 100 && pixel.G > 200 && pixel.B > 200) // голубой
                            cyanCount++;
                        else if (pixel.R < 100 && pixel.G < 100 && pixel.B > 200) // синий
                            blueCount++;
                        else if (pixel.R > 200 && pixel.G < 100 && pixel.B > 200) // розовый
                            pinkCount++;
                        else // темный
                            darkCount++;
                    }
                }

                // Определение преимущественного цвета
                int[] colorCounts = { lightCount, redCount, yellowCount, greenCount, cyanCount, blueCount, pinkCount, darkCount };
                int maxIndex = Array.IndexOf(colorCounts, colorCounts.Max());

                // Вывод результата
                switch (maxIndex)
                {
                    case 0:
                        Console.Write("0 ");
                        break;
                    case 1:
                        Console.Write("R ");
                        break;
                    case 2:
                        Console.Write("Y ");
                        break;
                    case 3:
                        Console.Write("G ");
                        break;
                    case 4:
                        Console.Write("C ");
                        break;
                    case 5:
                        Console.Write("B ");
                        break;
                    case 6:
                        Console.Write("M ");
                        break;
                    case 7:
                        Console.Write("1 ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

*/