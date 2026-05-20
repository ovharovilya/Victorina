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
                new Question("Какой модификатор доступа делает поля и методы видимыми для всех классов?", new List<string> {"private", "public", "protected", "internal"}, 1),
                new Question("Какой модификатор доступа делает поля и методы невидимыми для всех классов?", new List<string> {"private", "public", "protected", "internal"}, 0),
                new Question("Какой тип данных используется для true/false?", new List<string> {"string", "bool", "int", "double"}, 1),
                new Question("Какой тип данных используется для дробных чисел?", new List<string> {"string", "bool", "int", "double"}, 3),
                new Question("Какой модификатор доступа делает поля и методы видимыми только для наслеников классов?", new List<string> {"private", "public", "protected", "internal"}, 2),
                new Question("Какой модификатор доступа делает поля и методы видимыми только внутри сборки?", new List<string> {"private", "public", "protected", "internal"}, 3),
                new Question("Какой тип данных используется для символов?", new List<string> {"string", "bool", "char", "double"}, 2),
                new Question("Какой тип данных используется для строк?", new List<string> {"string", "bool", "int", "double"}, 0),
            };
        }
    }
}
