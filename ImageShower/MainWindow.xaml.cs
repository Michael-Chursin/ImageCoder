using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageShower
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imageCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            bool less = false;
            bool colorful = true;
            int pixSize = 5;
            int x = 0, y = 0;
            string image = imageEncode($"C://Users/{Environment.UserName}/Desktop/KaijiAgain.txt");
            if (colorful == false)
            {
                foreach (char sym in image)
                {
                    if (sym == '3')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.White;
                        myRect.Fill = Brushes.White;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '2')
                    {
                        Rectangle myRect = new Rectangle();
                        if (less == false)
                        {
                            myRect.Stroke = Brushes.Gray;
                            myRect.Fill = Brushes.White;
                        }
                        else
                        {
                            myRect.Stroke = Brushes.White;
                            myRect.Fill = Brushes.White;
                        }
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '1')
                    {
                        Rectangle myRect = new Rectangle();
                        if (less == false)
                        {
                            myRect.Stroke = Brushes.Black;
                            myRect.Fill = Brushes.Gray;
                        }
                        else
                        {
                            myRect.Stroke = Brushes.Black;
                            myRect.Fill = Brushes.Black;
                        }
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '0')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Black;
                        myRect.Fill = Brushes.Black;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '\n')
                    {
                        x = 0;
                        y += pixSize;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                foreach (char sym in image)
                {
                    if (sym == '1')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.White;
                        myRect.Fill = Brushes.White;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'r')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Red;
                        myRect.Fill = Brushes.Red;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'y')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Yellow;
                        myRect.Fill = Brushes.Yellow;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'g')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Green;
                        myRect.Fill = Brushes.Green;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'c')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Cyan;
                        myRect.Fill = Brushes.Cyan;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'b')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Blue;
                        myRect.Fill = Brushes.Blue;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == 'm')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Magenta;
                        myRect.Fill = Brushes.Magenta;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '0')
                    {
                        Rectangle myRect = new Rectangle();
                        myRect.Stroke = Brushes.Black;
                        myRect.Fill = Brushes.Black;
                        myRect.HorizontalAlignment = HorizontalAlignment.Left;
                        myRect.VerticalAlignment = VerticalAlignment.Center;
                        myRect.Height = pixSize;
                        myRect.Width = pixSize;
                        Canvas.SetLeft(myRect, x);
                        Canvas.SetTop(myRect, y);
                        imageCanvas.Children.Add(myRect);
                        x += pixSize;
                        myRect = null;
                    }
                    else if (sym == '\n')
                    {
                        x = 0;
                        y += pixSize;
                    }
                    else { continue; }
                }
            }
        }
        private string imageEncode(string path)
        {
            using (FileStream fstream = new FileStream(path, FileMode.Open))
            {
                byte[] output = new byte[fstream.Length];
                fstream.Read(output, 0, output.Length);
                string textFromFile = Encoding.Default.GetString(output);
                return textFromFile;
            }
        }
    }
}
