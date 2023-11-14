using System.Windows;

namespace ScaryHalloweenStoryApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCreateStoryButtonClick(object sender, RoutedEventArgs e)
        {
            // Combine user input to create the complete scary Halloween story
            string story = $"{part1TextBox.Text}\n{part2TextBox.Text}\n{part3TextBox.Text}";
            // Add more parts as needed

            // Display the complete story in the TextBlock
            storyTextBlock.Text = story;
        }
    }
}
