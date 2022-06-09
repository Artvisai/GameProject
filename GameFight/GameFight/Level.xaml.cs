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
    /// Interaction logic for Level.xaml
    /// </summary>
    public partial class Level : Window
    {
        Hero hr;
        Enemy en;
        Random rnd = new Random();
        List<string> levelAccess = new List<string>();
        string numberAccess;
        public Level()
        {
            InitializeComponent();
        }

        public Level(Hero hr, Enemy en, List<string> levelAccess, string numberAccess = "")
        {
            InitializeComponent();
            this.hr = hr;
            this.en = en;
            this.levelAccess = levelAccess;
            this.numberAccess = numberAccess;
            imgHero.Source = BitmapFrame.Create(new Uri(hr.photoPath, UriKind.Relative));
            imgEnemy.Source = BitmapFrame.Create(new Uri(en.photoPath, UriKind.Relative));
            enemyNameLabel.Content = en.name;
            heroHealthBar.Maximum = hr.health;
            heroHealthBar.Value = hr.health;
            enemyHealthBar.Maximum = en.health;
            enemyHealthBar.Value = en.health;
            heroHealthLabel.Content = hr.health;
            enemyHealthLabel.Content = en.health;
            healCountLabel.Content = hr.healTimes;
            attackButton.Content = "Attack("+hr.attack+"+-"+hr.hitRange+")";
            healButton.Content = "Heal(" + hr.heal + ")";
        }

        private void writeLevelAccess(string number)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\AppData\LevelAccess.txt", true, System.Text.Encoding.Default))
                {
                    if (!levelAccess.Contains(number) && number != "")
                    {
                        levelAccess.Add(number);
                        sw.Write(" "+number);
                    }
                }

            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private void enemyTurn()
        {
            bool flag = true;
            if (en.heal!=0)
            {
                if (en.health < enemyHealthBar.Maximum / 2)
                {
                    en.health += en.heal;
                    en.heal = 0;
                    flag = false;
                }
            }
            if (flag)
            {
                hr.health -= en.attack;
                if (hr.health <= 0)
                {
                    hr.health = 0;
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Close();
                    MessageBox.Show("You Lose!");
                }
                heroHealthBar.Value = hr.health;
                heroHealthLabel.Content = hr.health;
            }
        }

        private void giveUpButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
            MessageBox.Show("You Lose!");
        }

        private void attackButton_Click(object sender, RoutedEventArgs e)
        {
            en.health = en.health - hr.attack - rnd.Next(-hr.hitRange, hr.hitRange);
            if (en.health <= 0)
            {
                en.health = 0;
                writeLevelAccess(numberAccess);
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
                MessageBox.Show("You Win!");
            }
            else
            {
                enemyTurn();
            }
            enemyHealthBar.Value = en.health;
            enemyHealthLabel.Content = en.health;
        }

        private void healButton_Click(object sender, RoutedEventArgs e)
        {
            if (hr.healTimes > 0 && hr.health < heroHealthBar.Maximum)
            {
                hr.health += hr.heal;
                if (hr.health > heroHealthBar.Maximum)
                {
                    hr.health = (int)heroHealthBar.Maximum;
                }
                hr.healTimes -= 1;
                healCountLabel.Content = hr.healTimes;
                heroHealthBar.Value = hr.health;
                heroHealthLabel.Content = hr.health;
            }
        }
    }
}
