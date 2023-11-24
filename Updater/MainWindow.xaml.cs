using MahApps.Metro.Controls;

namespace MahAppBase
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        #region Property
        public MainComponent MainViewModel { get; set; }
        #endregion

        #region MemberFunction

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainComponent();
            this.DataContext = MainViewModel;
        }
        #endregion
    }
}