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

namespace CharacterCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush color = new SolidColorBrush();

        string[] Hair = { "", "Sunglasses.png", "BruhHair.png", "TopHat.png", "LadyHair.png", "BullyHair.png" };
        int CurrentHair = 1;
        string[] Smile = { "", "AngryTeeth.png", "Frown.png", "Smile01.png" };
        int CurrentSmile = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        // RGB sliders
        private void slid_Red_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.Color = Color.FromArgb(100, Convert.ToByte(slid_Red.Value), Convert.ToByte(slid_Green.Value), Convert.ToByte(slid_Blue.Value));
        }

        private void r_SkinFill_Loaded(object sender, RoutedEventArgs e)
        {
            r_SkinFill.Fill = color;
        }

        private void slid_Green_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.Color = Color.FromArgb(100, Convert.ToByte(slid_Red.Value), Convert.ToByte(slid_Green.Value), Convert.ToByte(slid_Blue.Value));
        }

        private void slid_Blue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.Color = Color.FromArgb(100, Convert.ToByte(slid_Red.Value), Convert.ToByte(slid_Green.Value), Convert.ToByte(slid_Blue.Value));
        }

        // Changes hat/hair
        private void bt_HairRight_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentHair < Hair.Length)
            {
                img_Hair.Source = new BitmapImage(new Uri(Hair[CurrentHair++], UriKind.Relative));
            }
            else
            {
                CurrentHair = 0;
                img_Hair.Source = new BitmapImage(new Uri(Hair[CurrentHair++], UriKind.Relative));
            }
        }

        private void bt_HairLeft_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentHair > 0 && CurrentHair < Hair.Length)
            {
                img_Hair.Source = new BitmapImage(new Uri(Hair[CurrentHair--], UriKind.Relative));
            }
            else
            {
                img_Hair.Source = new BitmapImage(new Uri(Hair[CurrentHair], UriKind.Relative));
                CurrentHair = Hair.Length - 1;
            }
        }

        // Changes smile
        private void bt_SmileRight_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentSmile < Smile.Length)
            {
                img_Smile.Source = new BitmapImage(new Uri(Smile[CurrentSmile++], UriKind.Relative));
            }
            else
            {
                CurrentSmile = 0;
                img_Smile.Source = new BitmapImage(new Uri(Smile[CurrentSmile++], UriKind.Relative));
            }
        }

        private void bt_SmileLeft_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentSmile > 0 && CurrentSmile < Smile.Length)
            {
                img_Smile.Source = new BitmapImage(new Uri(Smile[CurrentSmile--], UriKind.Relative));
            }
            else
            {
                img_Smile.Source = new BitmapImage(new Uri(Smile[CurrentSmile], UriKind.Relative));
                CurrentSmile = Smile.Length - 1;
            }
        }
    }
}
