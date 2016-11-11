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
    public sealed partial class e1 : Page
    {
        public int x8, x1, x2, x3, x4, x5, x6, x7, x9,x10,x12,x13,x15,x16,x18;
        public e1()
        {
            this.InitializeComponent();
            this.button2.Click += button2_Click;
            Random rd = new Random();
            x1 = rd.Next(1, 7);
            x3 = rd.Next(0, 3);
            x4 = rd.Next(8, 14);
            x6 = rd.Next(1, 4);
            x7 = rd.Next(5, 10);
            x9 = rd.Next(0, 5);
            x10 = rd.Next(5, 10);
            x12 = rd.Next(0, 4);
            x13 = rd.Next(3, 8);
            x15 = rd.Next(1, 4);
            x16 = rd.Next(8, 14);
            x18 = rd.Next(2,6);
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
            string z1 = "**";
            block2.Text = Convert.ToString(z1);
            block5.Text = Convert.ToString(z1);
            block8.Text = Convert.ToString(z1);
            block11.Text = Convert.ToString(z1);
            block14.Text = Convert.ToString(z1);
            block17.Text = Convert.ToString(z1);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int result = 0,count=0;
            int answer1=1;
            string y1 = box1.Text;
            if (y1.Length == 0)
            {
                count++;
            }
            else
            {
                int y1_int = (int)Convert.ToInt32(y1);
                int i1 = 0;
                while (i1 < x3)
                {
                    answer1 = answer1 * x1;
                    i1 = i1 + 1;
                }
                if (answer1 == y1_int)
                {
                    result = result + 1;
                }
            }
            int answer2=1;
            string y2 = box2.Text;
            if (y2.Length == 0)
            {
                count++;
            }
            else
            {
                int y2_int = (int)Convert.ToInt32(y2);
                int i2 = 0;
                while (i2 < x6)
                {
                    answer2 = answer2 * x4;
                    i2 = i2 + 1;
                }
                if (answer2 == y2_int)
                {
                    result = result + 1;
                }
            }
            int answer3=1;
            int i3 = 0;
            string y3 = box3.Text;
            if (y3.Length == 0)
            {
                count++;
            }
            else
            {
                int y3_int = (int)Convert.ToInt32(y3);
                while (i3 < x9)
                {
                    answer3 = answer3 * x7;
                    i3 = i3 + 1;
                }
                if (answer3 == y3_int)
                {
                    result = result + 1;
                }
            }
            int answer4 = 1;
            string y4 = box4.Text;
            if (y4.Length == 0)
            {
                count++;
            }
            else
            {
                int y4_int = (int)Convert.ToInt32(y4);
                int i4 = 0;
                while (i4 < x12)
                {
                    answer4 = answer4 * x10;
                    i4 = i4 + 1;
                }
                if (answer4 == y4_int)
                {
                    result = result + 1;
                }
            }
            int answer5 = 1;
            string y5 = box5.Text;
            if (y5.Length == 0)
            {
                count++;
            }
            else
            {
                int y5_int = (int)Convert.ToInt32(y5);
                int i5 = 0;
                while (i5 < x15)
                {
                    answer5 = answer5 * x13;
                    i5 = i5 + 1;
                }
                if (answer5 == y5_int)
                {
                    result = result + 1;
                }
            }
            int answer6 = 1;
            string y6 = box6.Text;
            if (y6.Length == 0)
            {
                count++;
            }
            else
            {
                int y6_int = (int)Convert.ToInt32(y6);
                int i6 = 0;
                while (i6 < x18)
                {
                    answer6 = answer6 * x16;
                    i6 = i6 + 1;
                }
                if (answer6 == y6_int)
                {
                    result = result + 1;
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
