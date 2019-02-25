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

namespace ObservableCollectionHomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Division> division;

        public MainWindow()
        {
            InitializeComponent();

            division = new List<Division>();

            division.Add(new Division
            {
                Name = "DivisionOne"    
            });

            division.Add(new Division
            {
                Name = "DivisionTwo"
            });

            division.Add(new Division
            {
                Name = "DivisionThree"
            });

            foreach (var i in division)
            {
                Grid grid = new Grid();

                TextBlock textBlock = new TextBlock();

                Button button = new Button();

                textBlock.Text = i.Name;

                button.Name = i.Name;
                button.Content = "Show";
                button.HorizontalAlignment = HorizontalAlignment.Right;
                button.Click += ButtonClickForShowEmployee;

                grid.Width = 150;
                grid.Children.Add(textBlock);
                grid.Children.Add(button);

                listBoxForDivision.Items.Add(grid);
            }
        }

        private void ButtonClickForAddEmployee(object sender, RoutedEventArgs e)
        {
            int age;
            int.TryParse(textBoxForAge.Text,out age);

            foreach (var i in division)
            {
                if (textBoxForDivisionName.Text == i.Name)
                {
                    i.Employees.Add(new Employee
                    {
                        Age = age,
                        FullName = textBoxForFullName.Text
                    });
                }
            }
        }

        private void ButtonClickForShowEmployee(object sender, RoutedEventArgs e)
        {
            listBoxForEmployee.Items.Clear();

            foreach (var i in division)
            {
                if (i.Name == (sender as Button).Name)
                {
                    foreach (var j in i.Employees)
                    {
                        listBoxForEmployee.Items.Add(j.FullName);
                    }
                }
            }
        }
    }
}
