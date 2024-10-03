using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CookExam2
{
    public class MainViewModel_FoodRecipe : ObservableObject_FoodRecipe
    {
        public ObservableCollection<FoodRecipe> recipesList { get; set; }
        private FoodRecipe selectedRecipe;
        private RelayCommand addRecipe;
        private RelayCommand changeRecipe;
        private RelayCommand deleteRecipe;
        private RelayCommand saveRecipe;
        public MainViewModel_FoodRecipe()
        {
            recipesList = new ObservableCollection<FoodRecipe>();
            recipesList.Add(new FoodRecipe("Борщ", "Перше блюдо", 0, "Україна", "Суп", "C:\\Users\\coolm\\source\\repos\\CookExam2\\CookExam2\\Borch.jpg"));
            recipesList.Add(new FoodRecipe("Вареники", "Друге блюдо", 1, "Україна", "Тісто в карплі", "C:\\Users\\coolm\\source\\repos\\CookExam2\\CookExam2\\Varenyky.jpg"));
        }
        public FoodRecipe SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                if (selectedRecipe != value)
                {
                    selectedRecipe = value;
                    OnPropertyChanged(nameof(selectedRecipe));
                }
            }
        }
        public RelayCommand AddRecipe
        {
            get
            {
                return addRecipe ?? (addRecipe = new RelayCommand(
                    (obj) =>
                    {
                        FoodRecipe recipe = new FoodRecipe();
                        FoodRecipe_Dialog recipe_add_form = new FoodRecipe_Dialog(recipe);
                        if (recipe_add_form.ShowDialog() == true)
                            recipesList.Add(recipe);
                    }
                    ));
            }
        }
        public RelayCommand ChangeRecipe
        {
            get
            {
                return changeRecipe ?? (changeRecipe = new RelayCommand(
                    (obj) =>
                    {
                        if (SelectedRecipe != null)
                        {
                            FoodRecipe recipe = new FoodRecipe(SelectedRecipe.Name, SelectedRecipe.Type, SelectedRecipe.TypeIndex, SelectedRecipe.KitchenType, SelectedRecipe.Description, SelectedRecipe.ImageSource);
                            FoodRecipe_Dialog recipe_change_form = new FoodRecipe_Dialog(recipe);
                            if (recipe_change_form.ShowDialog() == true)
                            {
                                int pos = recipesList.IndexOf(SelectedRecipe);
                                recipesList.Remove(SelectedRecipe);
                                recipesList.Insert(pos, recipe);
                            }
                        }
                    },
                    (obj) => (recipesList.Count > 0 && SelectedRecipe != null)
                    ));
            }
        }
        public RelayCommand DeleteRecipe
        {
            get
            {
                return deleteRecipe ?? (
                    deleteRecipe = new RelayCommand(
                        (obj) =>
                        {
                            FoodRecipe recipe = obj as FoodRecipe;
                            recipesList.Remove(recipe);
                        },
                        (obj) => (recipesList.Count > 0 && SelectedRecipe != null)
                        ));
            }
        }
        public RelayCommand SaveRecipe
        {
            get
            {
                return saveRecipe ??
                    (saveRecipe = new RelayCommand(
                        (obj) =>
                        {
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Text(*.txt)|*.txt|JSON(*.json)|*.json";
                            if (saveFileDialog.ShowDialog() == true)
                            {
                                switch (saveFileDialog.FilterIndex)
                                {
                                    case 1:
                                        {
                                            using (StreamWriter saver = new StreamWriter(saveFileDialog.FileName))
                                            {
                                                foreach (var item in recipesList)
                                                {
                                                    saver.WriteLine(item.Name);
                                                    saver.WriteLine(item.Type);
                                                    saver.WriteLine(item.KitchenType);
                                                    saver.WriteLine(item.Description);
                                                    saver.WriteLine("----------------");
                                                }
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            DataContractJsonSerializer jsonFormat = new DataContractJsonSerializer(typeof(List<FoodRecipe>));
                                            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                                                jsonFormat.WriteObject(fs, recipesList);
                                        }
                                        break;
                                }
                            }
                        },
                        (obj) => recipesList.Count > 0
                    ));
            }
        }
    }
}
