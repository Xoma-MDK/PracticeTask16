using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticeTask16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Months(int Year, int Days)
        {
            for (int i = 1; i <= 12; i++)
            {
                if ((Days - System.DateTime.DaysInMonth(Year, i)) <= 0)
                    return i;
                Days = Days - System.DateTime.DaysInMonth(Year, i);
            }
            return 0;
        }

        public string DaysinMonth(int Year, int Days)
        {
            Dictionary<int, string> NamberMonth = new Dictionary<int, string>();
            NamberMonth.Add(1, "Январь");
            NamberMonth.Add(2, "Февряль");
            NamberMonth.Add(3, "Март");
            NamberMonth.Add(4, "Апрель");
            NamberMonth.Add(5, "Мая");
            NamberMonth.Add(6, "Июнь");
            NamberMonth.Add(7, "Июль");
            NamberMonth.Add(8, "Август");
            NamberMonth.Add(9, "Сентябрь");
            NamberMonth.Add(10, "Октябрь");
            NamberMonth.Add(11, "Ноябрь");
            NamberMonth.Add(12, "Декабрь");
            int Month = Months(Year, Days);
            for (int i = 1; i <= 12; i++)
            {
                if ((Days - System.DateTime.DaysInMonth(Year, i)) <= 0)
                {
                    break;
                }
                Days = Days - System.DateTime.DaysInMonth(Year, i);
            }
            string MonthsRu = "";
            if (NamberMonth.TryGetValue(Month, out MonthsRu))
            {
                return MonthsRu + ' ' + Days;
            }
            return "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            int c = Convert.ToInt32(textBox2.Text);
            int c1 = Convert.ToInt32(textBox3.Text);
            dateTimePicker2.MaxDate = DateTime.Now;
            DateTime dt1 = dateTimePicker2.Value;
            DateTime dt2 = DateTime.Now;
            int d = (dt2.Year - dt1.Year) * 365;
            string s = "Вы " + f;
            listBox1.Items.Add(s);
            s = Convert.ToString(d);
            s = "Вы прожили " + s + " дней";
            listBox1.Items.Add(s);
            s = Convert.ToString(c1);
            s = "Вы хотите учиться еще " + s + " дней";
            listBox1.Items.Add(s);
            dt1 = dt1.AddDays(c1);
            s = "Вы станете очень умным " + dt1;
            listBox1.Items.Add(s);
            s = Convert.ToString(dt1.DayOfWeek);
            s = "Это будет в " + s;
            listBox1.Items.Add(s);
            s = "Если не все поняли, подучите английский";
            listBox1.Items.Add(s);
            int days = Convert.ToInt32(textBox5.Text);
            int years = Convert.ToInt32(textBox4.Text);
            s = DaysinMonth(years, days);
            listBox1.Items.Add(s);

        }


    }
}
