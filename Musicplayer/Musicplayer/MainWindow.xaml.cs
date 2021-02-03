using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace Musicplayer
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

        String[] path, files;

        private void Playbutton_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        MediaPlayer player = new MediaPlayer();

        private void Songlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            player.Open(new Uri((string)Songlist.SelectedItem));
        }

        private void Pausebutton_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            
        }

        private void Soundslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
                player.Volume = e.NewValue; 
        }

        private void Stop_button_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Nextbutton_Click(object sender, RoutedEventArgs e)
        {
            Songlist.SelectedIndex += 1;
        }

        private void Previousbutton_Click(object sender, RoutedEventArgs e)
        {
            Songlist.SelectedIndex -= 1;
        }

        private void Trackingslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Position = TimeSpan.FromMilliseconds(e.NewValue);
        }

        private void Openfilesbutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog megnyitas = new OpenFileDialog();

            megnyitas.Multiselect = true;
            if ((bool)megnyitas.ShowDialog())
            {
                files = megnyitas.SafeFileNames;
                path = megnyitas.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    Songlist.Items.Add(path[i]);
                }
            }
           
        }
    }
}
