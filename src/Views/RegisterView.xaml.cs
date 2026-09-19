using DominoTrain.src.Resources;
using Microsoft.VisualBasic;
using System.Windows;
using AppStrings = DominoTrain.src.Resources.Strings; // <-- alias

namespace DominoTrain.src.Views
{
    public partial class RegisterView : Window
    {
        private const int MinPasswordLength = 12;

        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = passwordBox.Password;

            if (HasEmptyFields(email, username, password))
            {
                ShowError(AppStrings.EmptyFieldsMessage);
            }
            else if (password.Length < MinPasswordLength)
            {
                string message = string.Format(AppStrings.InvalidPasswordMessage, MinPasswordLength);
                ShowError(message);
            }
            else
            {
                // TODO: send the verification code to the email and open the "enter code" window
            }
        }

        private bool HasEmptyFields(string email, string username, string password)
        {
            bool hasEmptyFields = string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password);
            return hasEmptyFields;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, AppStrings.MessageBoxTitle, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}