using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace dial_okna
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Предоставление(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Ваше имя не было введено!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show($"Ваше имя: {name}", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Клик(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void ИзменяемоеЗначение(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBox.FontSize = e.NewValue;
        }
    }
}
