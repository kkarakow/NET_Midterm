using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTKatarzyna_Karakow
{
    /// <summary>
    /// Interaction logic for BasketballWindow.xaml
    /// </summary>
    public partial class BasketballWindow : Window
    {
        private List<Player> _players;

        public BasketballWindow()
        {
            InitializeComponent();

            _players = new List<Player>() {
            new BasketballPlayer(PlayerType.BasketballPlayer, 0,
                "Giannis Antetokounmpo", "Milwaukee Bucks", 56, 50, 15),
            new BasketballPlayer(PlayerType.BasketballPlayer, 1,
                "Kevin Durant", "Brooklyn Nets", 52, 34, 17),
            new BasketballPlayer(PlayerType.BasketballPlayer, 2,
                "LeBron James", "Los Angeles Lakers", 48, 42, 19),
            new BasketballPlayer(PlayerType.BasketballPlayer, 3,
                "Stephen Curry", "Golden State Warriors", 44, 32, 12),
            new BasketballPlayer(PlayerType.BasketballPlayer, 4,
                "Nikola Jokic", "Denver Nuggets", 34, 42, 16)
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            var basketballPlayers = from player in _players
                                            select player.PlayerName;

                        lstBasketball.ItemsSource = basketballPlayers;
        }

        private void lstBasketball_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            int index = lstBasketball.SelectedIndex;

            var selectedPlayer = (from player in _players
                                  where player.PlayerId == index
                                  select player).FirstOrDefault();

            selectedPlayer.PlayerId = int.Parse(txtIDBT.Text);
            txtIDBT.IsReadOnly = true;
            txtPlayerNameBT.Text = selectedPlayer.PlayerName;
            txtTeamNameBT.Text = selectedPlayer.TeamName;
            selectedPlayer.GamesPlayed = int.Parse(txtGamesPlayedBT.Text);
            selectedPlayer.FieldGoals = int.Parse(txtFieldGoalsBT.Text);
            selectedPlayer.ThreePointers = int.Parse(txtThreePointersBT.Text);
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Player btPlayer = new BasketballPlayer(PlayerType.BasketballPlayer, _players.Count,
                txtPlayerNameBT.Text, txtTeamNameBT.Text, int.Parse(txtGamesPlayedBT.Text),
                int.Parse(txtFieldGoalsBT.Text), int.Parse(txtThreePointersBT.Text));

            _players.Add(btPlayer);

            RefreshListBox();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = lstBasketball.SelectedIndex;

            Player player = _players[index];
            player.PlayerName = txtPlayerNameBT.Text;
            player.TeamName = txtTeamNameBT.Text;
            player.GamesPlayed = int.Parse(txtGamesPlayedBT.Text);
            player.FieldGoals = int.Parse(txtFieldGoalsBT.Text);
            player.ThreePointers = int.Parse(txtThreePointersBT.Text);

            RefreshListBox();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lstBasketball.SelectedIndex;

            _players.RemoveAt(index);

            for (int i = 0; i < _players.Count; i++)
                _players[i].PlayerId = i;

            RefreshListBox();
        }
    }
}
