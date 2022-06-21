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
    /// Interaction logic for BaseballWindow.xaml
    /// </summary>
    public partial class BaseballWindow : Window
    {
        private List<Player> _players;
        

        public BaseballWindow()
        {
            InitializeComponent();

            _players = new List<Player>() {
            new BaseballPlayer(PlayerType.BaseballPlayer, 0,
                "Shohei Ohtani", "Angels", 42, 24, 15),
            new BaseballPlayer(PlayerType.BaseballPlayer, 1,
                "Fernando Tatis", "Padres", 40, 22, 12),
            new BaseballPlayer(PlayerType.BaseballPlayer, 2,
                "Vladimir Guerrero", "Blue Jays", 38, 20, 10),
            new BaseballPlayer(PlayerType.BaseballPlayer, 3,
                "Ronald Acuna", "Braves", 36, 18, 8),
            new BaseballPlayer(PlayerType.BaseballPlayer, 4,
                "Aaron Judge", "Yankees", 34, 16, 6)
           };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            var baseballPlayers = from player in _players
                                  select player.PlayerName;

            lstBaseball.ItemsSource = baseballPlayers;
        }

        private void lstBaseball_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstBaseball.SelectedIndex;

            var selectedPlayer = (from player in _players
                                  where player.PlayerId == index
                                  select player).FirstOrDefault();

            selectedPlayer.PlayerId = int.Parse(txtIDB.Text);
            txtIDB.IsReadOnly = true;
            txtPlayerNameB.Text = selectedPlayer.PlayerName;
            txtTeamNameB.Text = selectedPlayer.TeamName;
            selectedPlayer.GamesPlayed = int.Parse(txtGamesPlayedB.Text);
            selectedPlayer.Runs = int.Parse(txtRunsB.Text);
            selectedPlayer.HomeRuns = int.Parse(txtHomeRunsB.Text);
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Player bPlayer = new BaseballPlayer(PlayerType.BaseballPlayer, _players.Count,
                txtPlayerNameB.Text, txtTeamNameB.Text,
                int.Parse(txtGamesPlayedB.Text),
                int.Parse(txtRunsB.Text), int.Parse(txtHomeRunsB.Text));

            _players.Add(bPlayer);

            RefreshListBox();
         }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = lstBaseball.SelectedIndex;

            Player player = _players[index];
            player.PlayerName = txtPlayerNameB.Text;
            player.TeamName = txtTeamNameB.Text;
            player.GamesPlayed = int.Parse(txtGamesPlayedB.Text);
            player.Runs = int.Parse(txtRunsB.Text);
            player.HomeRuns = int.Parse(txtHomeRunsB.Text);

            RefreshListBox();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lstBaseball.SelectedIndex;

            _players.RemoveAt(index);

            for (int i = 0; i < _players.Count; i++)
                _players[i].PlayerId = i;

            RefreshListBox();
        }
    }
}
