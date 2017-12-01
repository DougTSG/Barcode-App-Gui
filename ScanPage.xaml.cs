using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Barcode_App_Gui
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class ScanPage : Page
    {
        private string barCode = string.Empty;

        public ScanPage()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            string sampleText = String.Format("Door: {0}{1}Date:{2}{3}", "A1", Environment.NewLine, "11/15/2017", Environment.NewLine);

            File.WriteAllText(@"testData.txt", sampleText);

            DoScan();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }

        static void DoScan()
        {
            string time = DateTime.Now.ToString("HH:mm:ss tt");


        }


        private void dataEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key.ToString() == "Return")
            {
                string time = DateTime.Now.ToString("HH:mm:ss tt");
                MessageBox.Show("Submitted");
                File.AppendAllText("testData.txt", string.Format("{0},{1}{2}", time, dataEntry.Text, Environment.NewLine));

            }
            barCode += e.Key;
            text.Text = barCode;
        }
    }
}
