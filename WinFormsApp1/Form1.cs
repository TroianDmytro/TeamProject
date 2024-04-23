using Calculation_of_fuel_consumption;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;

        public Form1()
        {
            InitializeComponent();

            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.privatbank.ua/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
           
        }

        private void tB_distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsDouble(tB_distance.Text))
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
            if (IsDouble(tB_averageFuelConsumption.Text))
            {
                e.Handled = true;
            }
        }

        private void tB_costOfOneLiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsDouble(tB_costOfOneLiter.Text))
            {
                e.Handled = true;
            }
        }
    }
}
