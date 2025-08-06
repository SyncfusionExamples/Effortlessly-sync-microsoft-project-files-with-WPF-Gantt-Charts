namespace WPFGanttDemo
{
    using System.Windows;
    using Syncfusion.SfSkinManager;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = "Material3Light" });
        }

        private void OnExportButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.ganttControl.ExportToXML())
            {
                MessageBox.Show("Tasks exported successfully.", "XML Import/Export",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OnImportButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.ganttControl.ImportFromXML())
            {
                MessageBox.Show("Tasks imported successfully.", "XML Import/Export", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}