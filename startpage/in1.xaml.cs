using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace startpage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class in1 : Page
    {
        public int x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15,x16,x18,x19,x21,x22,x24,x25,x27,x28,x30;
        public in1()
        {
            this.InitializeComponent();
            this.button2.Click += button2_Click;
            Random rd = new Random();
            x1 = rd.Next(1, 30);
            x3 = rd.Next(30, 50);
            x4 = rd.Next(51, 70);
            x6 = rd.Next(71, 81);
            x7 = rd.Next(82, 90);
            x9 = rd.Next(91, 100);
            x10 = rd.Next(1, 10);
            x12 = rd.Next(11, 20);
            x13 = rd.Next(21, 30);
            x15 = rd.Next(31, 40);
            x16 = rd.Next(1, 10);
            x18 = rd.Next(10, 20);
            x19 = rd.Next(21, 30);
            x21 = rd.Next(31, 40);
            x22 = rd.Next(40, 49);
            x24 = rd.Next(41, 50);
            x25 = rd.Next(51, 60);
            x27 = rd.Next(34, 40);
            x28 = rd.Next(81, 90);
            x30 = rd.Next(91, 100);
            x2 = rd.Next(1, 3);
            x5 = rd.Next(3, 5);
            x8 = rd.Next(7, 9);
            x11 = rd.Next(12, 14);
            x14 = rd.Next(17, 19);
            block1.Text = Convert.ToString(x1);
            block3.Text = Convert.ToString(x3);
            block4.Text = Convert.ToString(x4);
            block6.Text = Convert.ToString(x6);
            block7.Text = Convert.ToString(x7);
            block9.Text = Convert.ToString(x9);
            block10.Text = Convert.ToString(x10);
            block12.Text = Convert.ToString(x12);
            block13.Text = Convert.ToString(x13);
            block15.Text = Convert.ToString(x15);
            block16.Text = Convert.ToString(x16);
            block18.Text = Convert.ToString(x18);
            block19.Text = Convert.ToString(x19);
            block21.Text = Convert.ToString(x21);
            block22.Text = Convert.ToString(x22);
            block24.Text = Convert.ToString(x24);
            block25.Text = Convert.ToString(x25);
            block27.Text = Convert.ToString(x27);
            block28.Text = Convert.ToString(x28);
            block30.Text = Convert.ToString(x30);
            string z1;
            if (x2 == 1)
            {
                z1 = ">";
                block2.Text = Convert.ToString(z1);
                block29.Text = Convert.ToString(z1);
            }
            else
            {
                z1 = "<";
                block2.Text = Convert.ToString(z1);
                block29.Text = Convert.ToString(z1);
            }
            string z2;
            if (x5 == 4)
            {
                z2 = ">";
                block5.Text = Convert.ToString(z2);
                block26.Text = Convert.ToString(z2);
            }
            else
            {
                z2 = "<";
                block5.Text = Convert.ToString(z2);
                block26.Text = Convert.ToString(z2);
            }
            string z3;
            if (x8 == 7)
            {
                z3 = ">";
                block8.Text = Convert.ToString(z3);
                block23.Text = Convert.ToString(z3);
            }
            else
            {
                z3 = "<";
                block8.Text = Convert.ToString(z3);
                block23.Text = Convert.ToString(z3);
            }
            string z4;
            if (x11 == 12)
            {
                z4 = ">";
                block11.Text = Convert.ToString(z4);
                block20.Text = Convert.ToString(z4);
            }
            else
            {
                z4 = "<";
                block11.Text = Convert.ToString(z4);
                block20.Text = Convert.ToString(z4);
            }
            string z5;
            if (x14 == 17)
            {
                z5 = ">";
                block14.Text = Convert.ToString(z5);
                block17.Text = Convert.ToString(z5);
            }
            else
            {
                z5 = "<";
                block14.Text = Convert.ToString(z5);
                block17.Text = Convert.ToString(z5);
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int result = 0,count=0;
            int answer1;
            string y1 = box1.Text;
            if (y1.Length == 0)
            {
                count++;
            }
            else
            {
                int y1_int = (int)Convert.ToInt32(y1);
                if (x2 == 1)
                {
                    if (x1 > x3)
                    {
                        answer1 = 1;
                    }
                    else
                    {
                        answer1 = 0;
                    }
                    if (y1_int == answer1)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x1 < x3)
                    {
                        answer1 = 1;
                    }
                    else
                    {
                        answer1 = 0;
                    }
                    if (answer1 == y1_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer2;
            string y2 = box2.Text;
            if (y2.Length == 0)
            {
                count++;
            }
            else
            {
                int y2_int = (int)Convert.ToInt32(y2);
                if (x5 == 4)
                {
                    if (x4 > x6)
                    {
                        answer2 = 1;
                    }
                    else
                    {
                        answer2 = 0;
                    }
                    if (answer2 == y2_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x4 < x6)
                    {
                        answer2 = 1;
                    }
                    else
                    {
                        answer2 = 0;
                    }
                    if (answer2 == y2_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer3;
            string y3 = box3.Text;
            if (y3.Length == 0)
            {
                count++;
            }
            else
            {
                int y3_int = (int)Convert.ToInt32(y3);
                if (x8 == 7)
                {
                    if (x7 > x9)
                    {
                        answer3 = 1;
                    }
                    else
                    {
                        answer3 = 0;
                    }
                    if (answer3 == y3_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x7 < x9)
                    {
                        answer3 = 1;
                    }
                    else
                    {
                        answer3 = 0;
                    }
                    if (answer3 == y3_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer4;
            string y4 = box4.Text;
            if (y4.Length == 0)
            {
                count++;
            }
            else
            {
                int y4_int = (int)Convert.ToInt32(y4);
                if (x11 == 12)
                {
                    if (x10 > x12)
                    {
                        answer4 = 1;
                    }
                    else
                    {
                        answer4 = 0;
                    }
                    if (answer4 == y4_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x10 < x12)
                    {
                        answer4 = 1;
                    }
                    else
                    {
                        answer4 = 0;
                    }
                    if (answer4 == y4_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer5;
            string y5 = box5.Text;
            if (y5.Length == 0)
            {
                count++;
            }
            else
            {
                int y5_int = (int)Convert.ToInt32(y5);
                if (x14 == 17)
                {
                    if (x13 > x15)
                    {
                        answer5 = 1;
                    }
                    else
                    {
                        answer5 = 0;
                    }
                    if (answer5 == y5_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x13 < x15)
                    {
                        answer5 = 1;
                    }
                    else
                    {
                        answer5 = 0;
                    }
                    if (answer5 == y5_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer6;
            string y6 = box6.Text;
            if (y6.Length == 0)
            {
                count++;
            }
            else
            {
                int y6_int = (int)Convert.ToInt32(y6);
                if (x14 == 17)
                {
                    if (x16 > x18)
                    {
                        answer6 = 1;
                    }
                    else
                    {
                        answer6 = 0;
                    }
                    if (answer6 == y6_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x16 < x18)
                    {
                        answer6 = 1;
                    }
                    else
                    {
                        answer6 = 0;
                    }
                    if (answer6 == y6_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer7;
            string y7 = box7.Text;
            if (y7.Length == 0)
            {
                count++;
            }
            else
            {
                int y7_int = (int)Convert.ToInt32(y7);
                if (x11 == 12)
                {
                    if (x19 > x21)
                    {
                        answer7 = 1;
                    }
                    else
                    {
                        answer7 = 0;
                    }
                    if (answer7 == y7_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x19 < x21)
                    {
                        answer7 = 1;
                    }
                    else
                    {
                        answer7 = 0;
                    }
                    if (answer7 == y7_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer8;
            string y8 = box8.Text;
            if (y8.Length == 0)
            {
                count++;
            }
            else
            {
                int y8_int = (int)Convert.ToInt32(y8);
                if (x8 == 7)
                {
                    if (x22 > x24)
                    {
                        answer8 = 1;
                    }
                    else
                    {
                        answer8 = 0;
                    }
                    if (answer8 == y8_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x22 < x24)
                    {
                        answer8 = 1;
                    }
                    else
                    {
                        answer8 = 0;
                    }
                    if (answer8 == y8_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer9;
            string y9 = box9.Text;
            if (y9.Length == 0)
            {
                count++;
            }
            else
            {
                int y9_int = (int)Convert.ToInt32(y9);
                if (x5 == 4)
                {
                    if (x25> x27)
                    {
                        answer9 = 1;
                    }
                    else
                    {
                        answer9 = 0;
                    }
                    if (answer9 == y9_int)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x25 < x27)
                    {
                        answer9 = 1;
                    }
                    else
                    {
                        answer9 = 0;
                    }
                    if (answer9 == y9_int)
                    {
                        result = result + 1;
                    }
                }
            }
            int answer10;
            string y10 = box10.Text;
            if (y10.Length == 0)
            {
                count++;
            }
            else
            {
                int y10_int = (int)Convert.ToInt32(y10);
                if (x2 == 1)
                {
                    if (x28 > x30)
                    {
                        answer10 = 1;
                    }
                    else
                    {
                        answer10 = 0;
                    }
                    if (y10_int == answer10)
                    {
                        result = result + 1;
                    }
                }
                else
                {
                    if (x28 < x30)
                    {
                        answer10 = 1;
                    }
                    else
                    {
                        answer10 = 0;
                    }
                    if (answer10 == y10_int)
                    {
                        result = result + 1;
                    }
                }
            }
            if (count > 0)
            {
                MessageDialog msg = new MessageDialog("please do answer to all the questions");
                msg.ShowAsync();
            }
            string k = Convert.ToString(result);
            this.Frame.Navigate(typeof(resultpage),k);
        }
    }
}
