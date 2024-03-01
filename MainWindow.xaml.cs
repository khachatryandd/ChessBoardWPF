using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Figures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            board.MouseLeftButtonDown += Board_MouseLeftButtonDown;
            //f.MouseLeftButtonDown += Image_MouseLeftButtonDown;
        }
        private void Board_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(board);
            //X.Content = $"X: {Math.Truncate(point.X)}";
            //Y.Content = $"Y: {Math.Truncate(point.Y)}";
           
            f.Margin = new Thickness(Math.Truncate(point.X), Math.Truncate(point.Y),0,0);

            SelectImage(((ComboBoxItem)Color.SelectedItem)?.Content.ToString(), ((ComboBoxItem)Figure.SelectedItem)?.Content.ToString());
        }
        //private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    Point clickPoint = e.GetPosition(f);
        //    double x = Canvas.GetLeft(f);
        //    double y = Canvas.GetTop(f);
        //}

        /// <summary>
        /// Prints the figure's image
        /// </summary>
        /// <param name="color">figures color(white,black)</param>
        /// <param name="figure">(any chess figure)</param>
        private void SelectImage (string color, string figure)
        {
            string imagePath = "";
            BitmapImage bitmapImage = new BitmapImage();
            if (color == "White")
            {
                imagePath = $"/Figures/{Letter.W}{figure}.png";
                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                f.Source = bitmapImage;
            }
            else
            {
                imagePath = $"/Figures/{Letter.B}{figure}.png";
                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                f.Source = bitmapImage;
            }
        }
        //private void a(string color, string figure)
        //{
        //    string imagePath = ""; 
        //    BitmapImage bitmapImage = new BitmapImage();
        //    if (color == "White")
        //    {
        //        switch (figure)
        //        {
        //            case "King":
        //                imagePath = $"/Figures/WKing.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source=bitmapImage;
        //                break;
        //            case "Queen":
        //                imagePath = $"/Figures/WQueen.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage; 
        //                break;
        //            case "Rook":
        //                imagePath = $"/Figures/WRook.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage; 
        //                break;
        //            case "Knight":
        //                imagePath = $"/Figures/WKnight.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage; 
        //                break;
        //            case "Bishop":
        //                imagePath = $"/Figures/WBishop.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage; 
        //                break;
        //            case "Pawn":
        //                imagePath = $"/Figures/WPawn.png"; 
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage; 
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        switch (figure)
        //        {
        //            case "King":
        //                 imagePath = $"/Figures/BKing.png";
        //                 bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //            case "Queen":
        //                imagePath = $"/Figures/BQueen.png";
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //            case "Rook":
        //                imagePath = $"/Figures/BRook.png";
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //            case "Knight":
        //                imagePath = $"/Figures/BKnight.png";
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //            case "Bishop":
        //                imagePath = $"/Figures/BBishop.png";
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //            case "Pawn":
        //                imagePath = $"/Figures/BPawn.png";
        //                bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        //                f.Source = bitmapImage;
        //                break;
        //        }
        //    }
        // }
    }
}
