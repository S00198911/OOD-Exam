using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // ****************************************************************************************************
    // Christian Krivickis
    // S00198911
    // Github: https://github.com/ChristianKrivickis/OOD-Exam
    // ****************************************************************************************************
    public partial class MainWindow : Window
    {
        List<Game> AllGames;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = GameListBox.SelectedItem as Game;

            if (selectedGame != null)
            {
                GameImage.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                GameTextBlock.Text = $"{selectedGame.Price:C}";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GameData db = new GameData();

            var query = from g in db.Games
                        select g;

            AllGames = query.ToList();

            GameListBox.ItemsSource = AllGames;
        }

    }
}
