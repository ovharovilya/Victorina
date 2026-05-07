using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina.Models
{
    public static class QuizData
    {
        public static List<Question> GetQuestions()
        {
            return new List<Question>()
            {
                new Question("Какой тип данных используется для целых чисел?", new List<string> {"string", "bool", "int", "double"}, 2),
                new Question("Какой тип данных используется для строк?", new List<string> {"string", "bool", "int", "double"}, 0),
                new Question("Какой модификатор доступа делает поля и методы видимыми для всех классов?", new List<string> {"private", "public", "protected", "bool"}, 1),
                new Question("Какой модификатор доступа делает поля и методы невидимыми для всех классов?", new List<string> {"private", "public", "protected", "int"}, 0),
                new Question("Какой тип данных используется для целых чисел?", new List<string> {"string", "bool", "int", "double"}, 2),
                new Question("Какой тип данных используется для строк?", new List<string> {"string", "bool", "int", "double"}, 0),
                new Question("Какой модификатор доступа делает поля и методы видимыми для всех классов?", new List<string> {"private", "public", "protected", "bool"}, 1),
                new Question("Какой модификатор доступа делает поля и методы невидимыми для всех классов?", new List<string> {"private", "public", "protected", "int"}, 0),
                new Question("Какой тип данных используется для целых чисел?", new List<string> {"string", "bool", "int", "double"}, 2),
                new Question("Какой тип данных используется для строк?", new List<string> {"string", "bool", "int", "double"}, 0),
            };
        }
    }
}
