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
using Victorina.Models;

namespace Victorina.Pages
{

    public partial class QuestionPage : Page
    {
        private List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;

        public QuestionPage()
        {
            InitializeComponent();
            questions = QuizData.GetQuestions();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            Question q = questions[currentIndex];
            QuestionCounter.Text = $"Вопрос {currentIndex + 1} из {questions.Count}";
            QuestionText.Text = q.Text;
            Option0.Content = q.Options[0];
            Option1.Content = q.Options[1];
            Option2.Content = q.Options[2];
            Option3.Content = q.Options[3];
            Option0.IsEnabled = true;
            Option1.IsEnabled = true;
            Option2.IsEnabled = true;
            Option3.IsEnabled = true;


        }

        void Option_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            Question q = questions[currentIndex];
            int selectedIndex = 0;
            if (clicked == Option1) selectedIndex = 1;
            else if (clicked == Option2) selectedIndex = 2;
            else if (clicked == Option3) selectedIndex = 3;
            Option0.IsEnabled = false;
            Option1.IsEnabled = false;
            Option2.IsEnabled = false;
            Option3.IsEnabled = false;

            Button correctButton = Option0;
            if (q.CorrectIndex == 1) correctButton = Option1;
            else if (q.CorrectIndex == 2) correctButton = Option2;
            else if (q.CorrectIndex == 3) correctButton = Option3;

            correctButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#008000"));

            if (selectedIndex == q.CorrectIndex)
                score++;
            else
                clicked.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));

            ShowQuestion();
            
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = System.TimeSpan.FromSeconds(1.5);
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                currentIndex++;

                if (currentIndex < questions.Count)
                {
                    ShowQuestion();
                }
                else
                {
                    NavigationService.Navigate(new ResultPage(score, questions.Count));
                }

                Option0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
                Option1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
                Option2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
                Option3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));

            };
            timer.Start();
        }
    }
}
