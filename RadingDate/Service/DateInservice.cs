using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static RadingDate.Configuration.AppConfiguration;
namespace RadingDate.Service
{
    internal class DateInservice
    {
        public static void CreateIfXmlIfNotExsists()
        {
            if (!File.Exists(DateInPath))
            {
                // יצירת קובץ חדש
                XDocument document = new();
                // יצירת אלמנט
                XElement MusicSchool = new XElement("Queries");
                // הוספת האלמנט לקובץ
                document.Add(MusicSchool);
                // שמירת השינויים בקובץ
                document.Save(DateInPath);
            }
        }
        public static void InsertNewDate( string DayOfweek, string DayInMonth,string Month,string Year,string Result)
        {
            XDocument document = XDocument.Load(DateInPath);
            XElement? myMetting = document.Descendants("Queries")
                .FirstOrDefault();


            if (myMetting == null) 
            { 
                return;
            }
            XElement query = new(
                "Query",
                new XElement("day", DayOfweek),
                new XElement("dayinmonth", DayInMonth),
                new XElement("month", Month),
                new XElement("year", Year),
                new XElement("rasult", Result)



                );
            // הוספת 
            myMetting.Add(query);
            //שמירת הקובץ
            document.Save(DateInPath);
        }
    }
}
