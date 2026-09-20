using System.Collections.Generic;
using System.Windows;

namespace DominoTrain.Views
{
    public partial class ProfileWindow : Window
    {
        private bool _isEditing = false;

        private readonly List<string> _availableAvatars = new List<string>
        {
            "pack://application:,,,/Resources/Images/avatar_generic_preview.png",
        };

        public ProfileWindow()
        {
            InitializeComponent();
            LoadUserData();
            SetupAvatarGallery();
        }

        private void LoadUserData()
        {
            _usernameTextBox.Text = "DominoMaster";
            _biographyTextBox.Text = "Passenger on the express train to victory!";
            _gamesPlayedValueTextBlock.Text = "42";
            _winsValueTextBlock.Text = "28";
            _memberSinceValueTextBlock.Text = "Sep 2026";
        }

        private void SetupAvatarGallery()
        {
            _avatarListBox.ItemsSource = _availableAvatars;
            _avatarListBox.SelectedIndex = 0;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isEditing)
            {
                _isEditing = true;
                _usernameTextBox.IsReadOnly = false;
                _biographyTextBox.IsReadOnly = false;

                _editButton.Visibility = Visibility.Collapsed;
                _cancelButton.Visibility = Visibility.Visible;
                _saveButton.Visibility = Visibility.Visible;

                _usernameTextBox.Focus();
                _usernameTextBox.SelectAll();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ExitEditingMode();
            LoadUserData();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Profile updated successfully!", "Domino Train", MessageBoxButton.OK, MessageBoxImage.Information);

            ExitEditingMode();
        }

        private void ExitEditingMode()
        {
            _isEditing = false;
            _usernameTextBox.IsReadOnly = true;
            _biographyTextBox.IsReadOnly = true;

            _cancelButton.Visibility = Visibility.Collapsed;
            _saveButton.Visibility = Visibility.Collapsed;
            _editButton.Visibility = Visibility.Visible;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InstagramButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }
    }
}
