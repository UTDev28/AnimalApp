using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Animal animal;

        //Create a dictionary to hold animal objects
        Dictionary<string, Animal> AnimalDict = new Dictionary<string, Animal>();

        Dog dog;
        Cat cat;
        Bird bird;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Control for when the Cat button is checked by the user
        private void RdBtnCat_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("cat.jpg", UriKind.Relative));
            animal = new Cat("Fur","Cat food: dry/wet");
        }

        //Control for when the Dog button is checked by the user
        private void RdBtnDog_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("dog.jpg", UriKind.Relative));
            animal = new Dog("long hair, short hair, or floof","kibbles n bits" );

        }

        //Control for when the Bird button is checked by the user
        private void RdBtnBird_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("bird.jpg", UriKind.Relative));
            animal = new Bird("feathers","seed and grain");
        }

        private void BtnSound_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Sound();
        }

        //Controls for the six buttons.
        //Control for the move button
        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Move();
        }
        //Control for the eat button
        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Eat();
        }
        //Control for the pet button
        private void BtnPet_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Pet();
        }
        //Control for the sound button
        //Control for the food type button
        private void BtnFoodType_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.SkinType;
        }
        //Control for the skin type button
        private void BtnSkinType_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.FoodType;
        }

    }
}
