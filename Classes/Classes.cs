using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dem.Classes
{
    public class Classes
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string application { get; set; }
        public string typeDefect { get; set; }
        public string description { get; set; }
        public string client { get; set; }
        public string status { get; set; }
        public int avgTime { get; set; }

        public Classes() { }
        public Classes(int id, DateTime date, string application, string typeDefect, string description, string client, string status, int avgTime)
        {
            this.id = id;
            this.date = date;
            this.application = application;
            this.typeDefect = typeDefect;
            this.description = description;
            this.client = client;
            this.status = status;
            this.avgTime = avgTime;
        }

        public static List<Classes> allApplication = new List<Classes>()
        {
            new Classes(1, Convert.ToDateTime("20.10.2024 11:30:00"), "Шуруповерт", "Не работает", "Не работает", "Осок Пал Саныч", "В работе", 3),
            new Classes(2, Convert.ToDateTime("21.10.2024 11:30:00"), "Дрель", "Не включается", "Не работает", "Осок Пал Саныч", "В ожидании", 2),
            new Classes(3, Convert.ToDateTime("22.10.2024 11:30:00"), "Сварка", "Не варит", "Не работает", "Осок Пал Саныч", "Выполнено", 4),
        };
    }
}
