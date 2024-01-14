using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object Sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;
            if(!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Foreground = new SolidColorBrush(Colors.Black),
                    Margin = new Thickness(10, 5, 5, 5)
                };

                BulletDecorator bulletDecorator = new BulletDecorator();

                TextBlock bullet = new TextBlock
                {
                    Text = "\u2022", // Unicode character for a bullet point
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(5, 5, 5, 5)
                };

                bulletDecorator.Child = todoItem;
                bulletDecorator.Bullet = bullet;

                TodoList.Children.Add(bulletDecorator);
                TodoInput.Clear();
            }
            
        }

    }
}