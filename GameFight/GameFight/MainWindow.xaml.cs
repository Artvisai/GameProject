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
using ClassLibraryGame;

namespace GameFight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseLevelWindow lvls = new ChooseLevelWindow();
            lvls.Show();
            Close();
        }

        private void clearSavesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\AppData\LevelAccess.txt", false, System.Text.Encoding.Default))
                {
                    sw.Write("");
                    MessageBox.Show("Saves Cleared!");
                }

            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
