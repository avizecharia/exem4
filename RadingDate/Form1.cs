using System.Collections.Generic;
using static RadingDate.Service.DateInservice;
namespace RadingDate
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreateIfXmlIfNotExsists();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertNewDate(DayOfWeekComboBox.Text, DayOfMonthComboBox.Text, GetMonth(), YearComboBox.Text,GetResult());
            MessageBox.Show(GetResult());
            
        }
        public string GetResult()
        {
            return $"{GetDayOfweek()} , {GetDayOfMonth()}  , {GetYear()}";
        }
        public string GetDayOfweek()
        {
            string MyDay = DayOfWeekComboBox.Text;
            switch (MyDay)
            {
                case "ראשון":
                    return "באחד בשבת";

                case "שני":
                    return "בשני בשבת";
                case "שלישי":
                    return "בשלישי בשבת";

                case "רביעי":
                    return "ברביעי בשבת";

                case "חמישי":
                    return "בחמישי בשבת";

                case "ששי":
                    return "בששי בשבת";

                default:
                    return "not fond";

            }
        }
        public string GetYear()
        {
            string MyYear = YearComboBox.Text;
            switch (MyYear)
            {
                case @"תשפ""ד":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";

                case @"תשפ""ה":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                case @"תשפ""ו":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";

                case @"תשפ""ז":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";

                case @"תשפ""ח":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם";

                case @"תשפ""ט":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם";

                case @"תש""צ":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים  לבריאת העולם";

                case @"תשצ""א":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם";

                case @"תשצ""ב":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ושניים לבריאת העולם";

                case @"תשצ""ג":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם";

                default:
                    return "not fond";

            }
        }
        public string GetMonth() 
        { 
            return MonthComboBox.Text;

        }
        public string GetNextMonth() 
        {
            List<string> Months = ["תשרי","מרחשון","כסלו","טבת","שבט","אדר","אדר הראשון","אדר השני","ניסן","אייר","סיון","תמוז","אב","אלול",];
            string MyMonth = MonthComboBox.Text;
            int index = Months.IndexOf(MyMonth);
            if (index == Months.Count)
            {
                index = -1;
            }
             return Months[index + 1];
        }
        public string GetDayOfMonth()
        {
            int DatOfMonth = int.Parse(DayOfMonthComboBox.Text);
            switch (DatOfMonth)
            {
                case 1:
                    return $" יום אחד לירח {GetMonth()} ";
                case 2:
                    return $"שני ימים לירח { GetMonth()} ";
                case 3:
                    return $" שלושה ימים לירח {GetMonth()} ";
                case 4:
                    return $" ארבעה ימים לירח {GetMonth()} ";
                case 5:
                    return $" חמישה ימים לירח {GetMonth()} ";
                case 6:
                    return $"שישה ימים לירח  {GetMonth()} ";
                case 7:
                    return $" שבעה ימים לירח {GetMonth()} ";
                case 8:
                    return $" שמונה ימים לירח {GetMonth()} ";
                case 9:
                    return $" תשעה ימים לירח {GetMonth()} ";
                case 10:
                    return $" עשרה ימים לירח {GetMonth()} ";
                case 11:
                    return $" אחת עשר ימים לירח {GetMonth()} ";
                case 12:
                    return $"שתים עשר ימים לירח { GetMonth()} ";
                case 13:
                    return $" שלושה עשר ימים לירח {GetMonth()} ";
                case 14:
                    return $" ארבעה עשר ימים לירח {GetMonth()} ";
                case 15:
                    return $" חמישה עשר ימים לירח {GetMonth()} ";
                case 16:
                    return $" שישה עשר ימים לירח {GetMonth()} ";
                case 17:
                    return $" שבעה עשר ימים לירח { GetMonth()} ";
                case 18:
                    return $" שמונה עשר ימים לירח {GetMonth()} ";
                case 19:
                    return $" תשעה עשר ימים לירח {GetMonth()} ";
                case 20:
                    return $" עשרים ימים לירח {GetMonth()} ";
                case 21:
                    return $" אחד ועשרים ימים לירח {GetMonth()} ";
                case 22:
                    return $" שניים ועשרים ימים לירח {GetMonth()} ";
                case 23:
                    return $" שלושה ועשרים ימים לירח {GetMonth()} ";
                case 24:
                    return $" ארבעה ועשרים ימים לירח {GetMonth()} ";
                case 25:
                    return $" חמישה ועשרים ימים לירח {GetMonth()} ";
                case 26:
                    return $" שישה ועשרים ימים לירח {GetMonth()} ";
                case 27:
                    return $" שבעה ועשרים ימים לירח {GetMonth()} ";
                case 28:
                    return $" שמונה ועשרים ימים לירח {GetMonth()} ";
                case 29:
                    return $" תשעה ועשרים ימים לירח {GetMonth()} ";
                case 30:
                    return $" שלשים ימים לירח  {GetMonth()}  שהוא ראש חודש {GetNextMonth()} ";
                default:
                    return "not found";
            }
        }
    }
}
