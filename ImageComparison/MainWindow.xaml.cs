using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
using EasyCode.Common.Controls;
using FileOrganizer;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImageComparison
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

        private void DirButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFolderDialog();
            dialog.Title = "Select folders with images";

            if (dialog.ShowDialog() ==true)
            {
                DirLabel.Content = dialog.SelectedPath;
                CmpButton.IsEnabled = true;
            }
            else
            {
                DirLabel.Content = "No folder selected.";
                CmpButton.IsEnabled = false;
            }
        }

        private void ImageView_Click(object sender, MouseButtonEventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void ImgPreview_Click(object sender, MouseButtonEventArgs e)
        {
         //   throw new NotImplementedException();
        }

        private void CmpButton_Click(object sender, RoutedEventArgs e)
        {

            FilesIterator ft = new FilesIterator();
            var res = ft.Foo(DirLabel.Content.ToString(), 16, HashEnum.Difference);
            ImageView.ItemsSource = res;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ImageView.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Group");
            view.GroupDescriptions.Add(groupDescription);
        }


        private void DeleteDuplicate(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
