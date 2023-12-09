using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;


namespace JsonSearchApp
{
    public partial class MainWindow : Window
    {
        private readonly Dictionary<string, List<string>> jsonData = new Dictionary<string, List<string>>
        {
            { "8195", new List<string> { "Compliance_Policies" } },
            { "8197", new List<string> { "Resource_Access_Policies" } },
            { "8199", new List<string> { "Compliance_Policies", "Resource_Access_Policies" } }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string code = codeTextBox.Text.Trim();

            // Check if the input contains only numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(code, @"^\d+$"))
            {
                if (jsonData.ContainsKey(code))
                {
                    List<string> values = jsonData[code];
                    string result = $"Code: {code}\nContents: {string.Join(", ", values)}";
                    resultTextBlock.Text = result;
                }
                else
                {
                    resultTextBlock.Text = "Code not found!";
                }
            }
            else
            {
                resultTextBlock.Text = "Invalid input. Please enter only numeric characters.";
            }
        }

        private void ResultTextBlock_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Open the context menu when right-clicking on the resultTextBlock
            if (e.RightButton == MouseButtonState.Pressed)
            {
                resultTextBlock.ContextMenu.IsOpen = true;
            }
        }

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Copy the result to the clipboard when the "Copy" menu item is clicked
            Clipboard.SetText(resultTextBlock.Text);
        }

        private void codeTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // You can add any additional logic related to the text change event if needed
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = null;
            codeTextBox.Text = null;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Build 1.0" +
                "\n\nThis application is designed to retrieve SCCM Capabilities codes from the SCCM Client on Windows devices.\nThe database containing these codes has been compiled from various MVP sites online" +
                "\n\nThe author takes no responsibility or liability for any errors or misinformation presented through this App", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
