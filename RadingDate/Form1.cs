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
                case "�����":
                    return "���� ����";

                case "���":
                    return "���� ����";
                case "�����":
                    return "������ ����";

                case "�����":
                    return "������ ����";

                case "�����":
                    return "������ ����";

                case "���":
                    return "���� ����";

                default:
                    return "not fond";

            }
        }
        public string GetYear()
        {
            string MyYear = YearComboBox.Text;
            switch (MyYear)
            {
                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ����� ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ���� ������ �����";
                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ��� ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ���� ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ������ ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ���� ������ �����";

                case @"��""�":
                    return "���� ���� ����� ���� ���� ������  ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ���� ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ������ ������ �����";

                case @"���""�":
                    return "���� ���� ����� ���� ���� ������ ����� ������ �����";

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
            List<string> Months = ["����","������","����","���","���","���","��� ������","��� ����","����","����","����","����","��","����",];
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
                    return $" ��� ��� ���� {GetMonth()} ";
                case 2:
                    return $"��� ���� ���� { GetMonth()} ";
                case 3:
                    return $" ����� ���� ���� {GetMonth()} ";
                case 4:
                    return $" ����� ���� ���� {GetMonth()} ";
                case 5:
                    return $" ����� ���� ���� {GetMonth()} ";
                case 6:
                    return $"���� ���� ����  {GetMonth()} ";
                case 7:
                    return $" ���� ���� ���� {GetMonth()} ";
                case 8:
                    return $" ����� ���� ���� {GetMonth()} ";
                case 9:
                    return $" ���� ���� ���� {GetMonth()} ";
                case 10:
                    return $" ���� ���� ���� {GetMonth()} ";
                case 11:
                    return $" ��� ��� ���� ���� {GetMonth()} ";
                case 12:
                    return $"���� ��� ���� ���� { GetMonth()} ";
                case 13:
                    return $" ����� ��� ���� ���� {GetMonth()} ";
                case 14:
                    return $" ����� ��� ���� ���� {GetMonth()} ";
                case 15:
                    return $" ����� ��� ���� ���� {GetMonth()} ";
                case 16:
                    return $" ���� ��� ���� ���� {GetMonth()} ";
                case 17:
                    return $" ���� ��� ���� ���� { GetMonth()} ";
                case 18:
                    return $" ����� ��� ���� ���� {GetMonth()} ";
                case 19:
                    return $" ���� ��� ���� ���� {GetMonth()} ";
                case 20:
                    return $" ����� ���� ���� {GetMonth()} ";
                case 21:
                    return $" ��� ������ ���� ���� {GetMonth()} ";
                case 22:
                    return $" ����� ������ ���� ���� {GetMonth()} ";
                case 23:
                    return $" ����� ������ ���� ���� {GetMonth()} ";
                case 24:
                    return $" ����� ������ ���� ���� {GetMonth()} ";
                case 25:
                    return $" ����� ������ ���� ���� {GetMonth()} ";
                case 26:
                    return $" ���� ������ ���� ���� {GetMonth()} ";
                case 27:
                    return $" ���� ������ ���� ���� {GetMonth()} ";
                case 28:
                    return $" ����� ������ ���� ���� {GetMonth()} ";
                case 29:
                    return $" ���� ������ ���� ���� {GetMonth()} ";
                case 30:
                    return $" ����� ���� ����  {GetMonth()}  ���� ��� ���� {GetNextMonth()} ";
                default:
                    return "not found";
            }
        }
    }
}
