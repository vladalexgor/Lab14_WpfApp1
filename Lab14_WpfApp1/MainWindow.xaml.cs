using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14_WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// Определить класс Product для хранения информации о товаре. Класс должен содержать характеристики Название товара (строка), Цена (число),
    /// Изображение (строка - путь к файлу с изображением), Категория (перечисление, возможные значения – Еда, Бытовая техника).
    /// Разработать шаблон данных для отображения списка товаров в компоненте ListBox. При помощи триггеров определите разный шаблон для товаров категории
    /// Еда и категории Бытовая техника.
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product() 
            {
                ProductName = "Potato",
                Price = 80,
                ProductImage = "Data/1_potato.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "PC",
                Price = 125000,
                ProductImage = "Data/2_PC.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Tomato",
                Price = 350,
                ProductImage = "Data/3_tomato.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Fridge",
                Price = 90000,
                ProductImage = "Data/4_fridge.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
