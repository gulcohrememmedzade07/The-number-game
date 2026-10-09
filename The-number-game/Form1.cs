namespace The_number_game
{
    public partial class Form1 : Form
    {
        private int num = 0;
        private int cehd = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Axtarılan ədəd xanası boş ola bilməz!");
                return;
            }

            if (!int.TryParse(maskedTextBox1.Text, out int daxiledilenEded))
            {
                errorProvider1.SetError(maskedTextBox1, "Zəhmət olmasa düzgün ədəd daxil edin!");
                return;
            }

            cehd++;

            if (daxiledilenEded==num) {
                richTextBox1.Text = "Oyunu qazandınız\n Cehd sayı:"+cehd;
                button1.Enabled = false;
                maskedTextBox1.Enabled = false;
            }
            else
            {
                string mesaj = "Daxil edilən ədəd yanlışdır\n Cehd sayı:"+cehd+"\n";

                if (daxiledilenEded < num)
                {
                    mesaj += "Təsadüfi ədəddən kiçikdir";
                }
                else
                {
                    mesaj += "Təsadüfi ədəddən böyükdür";
                }

                richTextBox1.Text = mesaj;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 100);
            button1.Enabled = true;
            maskedTextBox1.Enabled = true;
            cehd = 0;

            maskedTextBox1.Clear();
            richTextBox1.Clear();
            errorProvider1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            maskedTextBox1.Enabled = false;
            richTextBox1.ReadOnly = true;
        }
    }
}
