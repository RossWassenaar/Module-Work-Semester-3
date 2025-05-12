using System.Media;
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
using System.Windows.Threading;

namespace DateTime_ExamTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Allows the use of the Timer class methods
        private DispatcherTimer examTimer; //DispatcherTimer uses a tick event

        //Holds the time of when the exam will end
        private DateTime examEndTime;

        //Holds the seconds of the duration selected from the combo box
        private double totalExamDurationSeconds;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_StartExam_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox_ExamDuration.SelectedItem is ComboBoxItem selectedItem)
            {
                int minutes = int.Parse(selectedItem.Tag.ToString()); //Using the Tag from the combo box to get the minutes
                totalExamDurationSeconds = minutes * 60; //Converting minutes, got from the tag, to seconds for the timer

                DateTime currentTime = DateTime.Now; //Getting the current time
                examEndTime = currentTime.AddSeconds(totalExamDurationSeconds); //Adding the seconds to the current time to get the end time

                Button_StartExam.IsEnabled = false; //Disables the start exam button, so the user cannot click the button while the progress bar is progressing
                ComboBox_ExamDuration.IsEnabled = false; //Disables the combo box, so the user cannot change the exam duration while the progress bar is progressing

                examTimer = new DispatcherTimer()
                {
                    Interval = TimeSpan.FromSeconds(1) //Sets the timer to tick every 1 (one) second
                };
                examTimer.Tick += ExamTimer_Tick; //When the system detects a tick, the ExamTimer_Tick method will be called
                examTimer.Start(); //Starts the timer
            }
        }

        //Method used as an event handler because .Tick is an event that requires an action to automatically execute when a tick is detected
        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            double remainingSeconds = (examEndTime - DateTime.Now).TotalSeconds; //Calculates the remaining seconds until the exam ends

            if (remainingSeconds > 0)
            {
                double secondsPassed = totalExamDurationSeconds - remainingSeconds; //Calculates the seconds passed since the exam started

                //Progress bar expects a value between 0 and 100, we need a percentage of time passed
                ProgressBar_ExamDuration.Value = secondsPassed / totalExamDurationSeconds * 100; //Calculates the percentage of time passed in seconds
            }
            else
            {
                examTimer.Stop(); //Stops the exam timer
                ProgressBar_ExamDuration.Value = 100; //Sets the progress bar to 100% when the exam ends

                SystemSounds.Beep.Play(); //Plays a beep sound when the exam ends
                MessageBox.Show("Exam time is up!", "Time's Up", MessageBoxButton.OK, MessageBoxImage.Information); //Shows a message box when the exam ends
                
                Button_StartExam.IsEnabled = true; //Enables the start exam button again
                ComboBox_ExamDuration.IsEnabled = true; //Enables the combo box again
            }
        }
    }
}