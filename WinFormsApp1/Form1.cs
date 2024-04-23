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
    }
}
