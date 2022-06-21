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

    public partial class HockeyWindow : Window
    {
        
        private List<Player> _players;
        

        public HockeyWindow()
        {
            InitializeComponent();

            _players = new List<Player>() {
            new HockeyPlayer(PlayerType.HockeyPlayer, 0,
                "Connor McDavid", "Edmonton Oilers", 46, 63, 34),
            new HockeyPlayer(PlayerType.HockeyPlayer, 1,
                "Nathan MacKinnon", "Colorado Avalanche", 53, 58, 35),
            new HockeyPlayer(PlayerType.HockeyPlayer, 2,
                "Leon Draisaitl", "Edmonton Oilers", 153, 67, 43),
            new HockeyPlayer(PlayerType.HockeyPlayer, 3,
                "Artemi Panarin", "New York Rangers", 54, 63, 32),
            new HockeyPlayer(PlayerType.HockeyPlayer, 4,
                "Sidney Crosby", "Pittsburgh Penguins", 41, 31, 16)
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            var hockeyPlayers = from player in _players
                                select player.PlayerName;

            lstHockey.ItemsSource = hockeyPlayers;
        }

        private void lstHockey_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            int index = lstHockey.SelectedIndex;

            var selectedPlayer = (from player in _players
                                 where player.PlayerId == index
                                 select player).FirstOrDefault();

            selectedPlayer.PlayerId = int.Parse(txtIDH.Text);
            txtIDH.IsReadOnly = true;
            txtPlayerNameH.Text = selectedPlayer.PlayerName;
            txtTeamNameH.Text = selectedPlayer.TeamName;
            selectedPlayer.GamesPlayed = int.Parse(txtGamesPlayedH.Text);
            selectedPlayer.Assists = int.Parse(txtAssistsH.Text);
            selectedPlayer.Goals = int.Parse(txtGoalsH.Text);
           


        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Player hPlayer = new HockeyPlayer(PlayerType.HockeyPlayer, _players.Count,
                txtPlayerNameH.Text, txtTeamNameH.Text, int.Parse(txtGamesPlayedH.Text),
                int.Parse(txtAssistsH.Text), int.Parse(txtGoalsH.Text));

           _players.Add(hPlayer);

            RefreshListBox();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = lstHockey.SelectedIndex;

            Player player = _players[index];
            player.PlayerName = txtPlayerNameH.Text;
            player.TeamName = txtTeamNameH.Text;
            player.GamesPlayed = int.Parse(txtGamesPlayedH.Text);
            player.Assists = int.Parse(txtAssistsH.Text);
            player.Goals = int.Parse(txtGoalsH.Text);

            RefreshListBox();


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lstHockey.SelectedIndex;

            _players.RemoveAt(index);

            for (int i = 0; i < _players.Count; i++)
                _players[i].PlayerId = i;

            RefreshListBox();
        }
    }
}

