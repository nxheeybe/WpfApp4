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

namespace WpfApp4
{
    public partial class EditTestWindowTestsNotFoundPage : Page
    {
        public EditTestWindowTestsNotFoundPage()
        {
            InitializeComponent();
            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "аааа";
            textBlock1.Opacity = 0.3;
            textBlock1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("black"));
            textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock1.VerticalAlignment = VerticalAlignment.Center;
            textBlock1.FontFamily = new FontFamily("Моя");
            textBlock1.FontSize = 86;
            textBlock1.FontWeight = FontWeights.Bold;
            MainSpace.Children.Add(textBlock1);

            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = "Пока что нет вопроса, на который можно ответить.\nПодождите пока будут вопросы.";
            textBlock2.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock2.VerticalAlignment = VerticalAlignment.Center;
            textBlock2.TextAlignment = TextAlignment.Center;
            textBlock2.FontFamily = new FontFamily("Моя");
            textBlock2.Width = 450;
            textBlock2.FontSize = 16;
            textBlock2.TextWrapping = TextWrapping.Wrap;
            MainSpace.Children.Add(textBlock2);
        }
    }
}
