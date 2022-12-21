using System.Windows;

namespace OOP_lab3
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new viewmodel.MainViewModel();

        }
    }
}