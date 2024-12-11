using System.Reflection.Metadata.Ecma335;
using System.Windows;

namespace WPF_Tutorial
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



        private void BerechneButton_Click(object sender, RoutedEventArgs e)
        {
            Rechteck rechteck = new Rechteck();
            rechteck.Height = double.Parse(HeightInput.Text);
            rechteck.Width = double.Parse(WidthInput.Text);

            double area = rechteck.GetArea();
            ResultRect.Text = area.ToString();
        }

        private void EndeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}