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
using System.Windows.Shapes;
using ClassLibraryGame;

namespace GameFight
{
    /// <summary>
    /// Interaction logic for ChooseLevelWindow.xaml
    /// </summary>
    public partial class ChooseLevelWindow : Window
    {

        List<string> levelAccess = new List<string>();

        public ChooseLevelWindow()
        {
            InitializeComponent();
            readLevelAccess();
            if (levelAccess.Count > 0)
                LevelTwoButton.Background = new SolidColorBrush(Colors.SpringGreen);
            if (levelAccess.Count > 1)
                LevelThreeButton.Background = new SolidColorBrush(Colors.SpringGreen);
        }

        private void readLevelAccess()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\AppData\LevelAccess.txt"))
                {
                    foreach (string number in sr.ReadToEnd().Split(' '))
                        if (!levelAccess.Contains(number) && number!="")
                            levelAccess.Add(number);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void LevelOne_Click(object sender, RoutedEventArgs e)
        {
            Hero hr = new Hero(@"..\..\Resources\Hero2.jpg");
            Enemy en = new Enemy(@"..\..\Resources\Enemy.jpg", "Ancient Dragon");
            Level lvl = new Level(hr, en, levelAccess, "2");
            lvl.Show();
            Close();
        }

        private void LevelTwo_Click(object sender, RoutedEventArgs e)
        {
            if (levelAccess.Count > 0)
            {
                Hero hr = new Hero(@"..\..\Resources\Hero2.jpg");
                Enemy en = new Enemy(@"..\..\Resources\Enemy2.jpg", "Evil Skull") { health = 90, attack = 4 };
                Level lvl = new Level(hr, en, levelAccess, "3");
                lvl.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Complete the previous level!");
            }
        }

        private void LevelThree_Click(object sender, RoutedEventArgs e)
        {
            if (levelAccess.Count > 1)
            {
                Hero hr = new Hero(@"..\..\Resources\Hero2.jpg");
                Enemy en = new Enemy(@"..\..\Resources\Enemy3.jpg", "Shadow Wizard") { health = 40, attack = 17, heal = 15 };
                Level lvl = new Level(hr, en, levelAccess);
                lvl.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Complete the previous level!");
            }
        }
    }
}
