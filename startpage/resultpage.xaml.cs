using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace startpage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class resultpage : Page
    {
        public resultpage()
        {
            this.InitializeComponent();
            this.button2.Click += button2_Click;
            this.button1.Click += button1_Click;
        }
        protected override void OnNavigatedTo (NavigationEventArgs e)
        {
            string text = e.Parameter as string;
            textBox.Text = text;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(third));
        }
    }
}
