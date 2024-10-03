using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CookExam2
{
    /// <summary>
    /// Interaction logic for FoodRecipe_Dialog.xaml
    /// </summary>
    public partial class FoodRecipe_Dialog : Window
    {
        public FoodRecipe temp_recipe { get; set; }
        public FoodRecipe_Dialog(FoodRecipe recipe)
        {
            InitializeComponent();
            temp_recipe = recipe;
            DataContext = temp_recipe;
            if (temp_recipe.ImageSource == null)
                img.Source = new BitmapImage(new Uri("restaurant.png", UriKind.Relative));
        }
        private void AddNewImage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Zach!");
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                temp_recipe.ImageSource = ofd.FileName;
                img.Source = new BitmapImage(new Uri(temp_recipe.ImageSource));
            }
        }
        private void Save(object sender, RoutedEventArgs e)
        { 
            if (name.Text != "" && type.SelectedIndex != -1 && kitchen.Text != "" && description.Text != "")
            {
                temp_recipe.Update(name.Text, type.Text, type.SelectedIndex, kitchen.Text, description.Text, img.Source.ToString());
                DialogResult = true;
            }

            if (name.Text == "") MessageBox.Show("Будь ласка, введіть ім'я."); return;
            if (type.SelectedIndex != -1) MessageBox.Show("Виберіть тип страви."); return;
            if (kitchen.Text == "") MessageBox.Show("Введіть кухню."); return;
            if (description.Text == "") MessageBox.Show("Введіть інформацію про страву."); return;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string inputText = textBox.Text;
            string cleanedText = Regex.Replace(inputText, "[^a-zA-ZА-Яа-я]", "");
            textBox.Text = cleanedText;
            textBox.CaretIndex = textBox.Text.Length;
        }

        private void kitchen_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string inputText = textBox.Text;
            string cleanedText = Regex.Replace(inputText, "[^a-zA-ZА-Яа-я]", "");
            textBox.Text = cleanedText;
            textBox.CaretIndex = textBox.Text.Length;
        }

        private void description_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string inputText = textBox.Text;
            string cleanedText = Regex.Replace(inputText, "[^a-zA-Zа-яА-Я0-9\\s]", "");
            textBox.Text = cleanedText;
            textBox.CaretIndex = textBox.Text.Length;
        }
    }
}
