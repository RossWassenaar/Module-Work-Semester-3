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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;
        string position;
        int salary;
        List<string> skills = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = txt_FullName.Text;
            position = txt_Role.Text;
            salary = int.Parse(txt_ExpectedSalary.Text);

            if (chk_CSharp.IsChecked == true)
            {
                skills.Add("C#");
            }
            if (chk_Python.IsChecked == true)
            {
                skills.Add("Python");
            }
            if (chk_Java.IsChecked == true)
            {
                skills.Add("Java");
            }
            textBlock_InfoOutput.Text = $"Application Submitted:\n\nName: {name}\nPosition: {position}\nSalary: {salary}\nSkills: {string.Join(", ", skills)}";
            
        }
    }
}