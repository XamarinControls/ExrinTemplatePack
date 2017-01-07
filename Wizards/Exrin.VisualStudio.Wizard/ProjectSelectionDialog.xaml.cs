using System.Windows;

namespace Exrin.VisualStudio.Wizard
{
    /// <summary>
    /// Interaction logic for ProjectSelectionDialog.xaml
    /// </summary>
    public partial class ProjectSelectionDialog : Window
    {

        public ProjectSelectionResult Result { get; set; }

        public ProjectSelectionDialog()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Result = ProjectSelectionResult.None;

            if (UWPCheckBox.IsChecked == true)
                Result = Result | ProjectSelectionResult.UWP;

            if (IOSCheckBox.IsChecked == true)
                Result = Result | ProjectSelectionResult.iOS;

            if (AndroidCheckBox.IsChecked == true)
                Result = Result | ProjectSelectionResult.Android;

            this.Close();
        }
    }
    
}
