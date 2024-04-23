using Calculation_of_fuel_consumption;
using DayNight;
using GetUsdRate;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //private readonly HttpClient _client;

        public Form1()
        {
            InitializeComponent();

            GetUsdRate.GetUsdRate._client = new HttpClient();
            GetUsdRate.GetUsdRate._client.BaseAddress = new Uri("https://api.privatbank.ua/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Class1.IsNight())
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkGreen;
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if(double.TryParse(tB_distance.Text, out double distance) &&
            double.TryParse(tB_averageFuelConsumption.Text, out double average) &&
            double.TryParse(tB_costOfOneLiter.Text, out double oneLiter))
            {
                tb_sumhrivna.Text =  Fuel.GetFuelConsumption(distance,average,oneLiter).ToString();
                tb_sumdollar.Text = GetUsdRate.GetUsdRate.ConvertToUSD(tb_sumhrivna.Text).Result.ToString();
            }
            else
            {
                MessageBox.Show("Data entry error");
                return;
            }
        }

        private void tB_distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// перевірка чи введенне число double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool IsDouble(string str)
        {
            if (!Double.TryParse(str, out _))
            {
                return false;
            }
            return true;
        }

        private void tB_averageFuelConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            
        }

        private void tB_costOfOneLiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
