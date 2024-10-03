using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookExam2
{
    public class FoodRecipe : ObservableObject_FoodRecipe
    {
        string name;
        string type;
        string kitchenType;
        int typeIndex;
        string description;
        string imageSource;

        public string Name { get {return name; } set { name = value; OnPropertyChanged(nameof(Name)); } }
        public string Type { get { return type; } set { type = value; OnPropertyChanged(nameof(Type)); } }
        public string KitchenType { get { return kitchenType; } set { kitchenType = value; OnPropertyChanged(nameof(KitchenType)); } }
        public int TypeIndex { get { return typeIndex; } set { typeIndex = value; OnPropertyChanged(nameof(TypeIndex)); } }
        public string Description { get { return description; } set { description = value; OnPropertyChanged(nameof(Description)); } }
        public string ImageSource { get { return imageSource; } set { imageSource = value; OnPropertyChanged(nameof(ImageSource)); } }
        public FoodRecipe() { }
        public FoodRecipe(string name, string type, int typeIndex, string kitchenType, string description, string imageSource) => Update(name, type, typeIndex, kitchenType, description, imageSource);
        public void Update(string name, string type, int typeIndex, string kitchenType, string description, string imageSource)
        {
            Name = name;
            Type = type;
            KitchenType = kitchenType;
            TypeIndex = typeIndex;
            Description = description;
            ImageSource = imageSource;
        }
    }
}
