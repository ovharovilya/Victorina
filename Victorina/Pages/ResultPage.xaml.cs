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

namespace Victorina.Pages
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage(int score, int total)
        {
            InitializeComponent();

            ScoreText.Text = $"{score} из {total} правильных";
            double percent = (double)score / total * 100;

            if (percent >= 80)
            {
                EmojiText.Text = "🏆";
                CommentText.Text = "Хорошо!";
            }
            else if (percent >= 50) {
                EmojiText.Text = "👍";
                CommentText.Text = "Неплохо!";
            }
            else
            {
                EmojiText.Text = "📚";
                CommentText.Text = "Плохо";
            }

        }

        private void restart_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

    }
}
