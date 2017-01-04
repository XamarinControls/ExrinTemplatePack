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
