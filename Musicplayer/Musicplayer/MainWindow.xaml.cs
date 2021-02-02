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
                    Songlist.Items.Add(files[i]);
                }
            }
           
        }
    }
}
