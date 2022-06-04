namespace WinCalcul
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            if (string.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1�� ���ڸ� �Է����ּ���.");
                Sum1.Focus();
                return;
            }

            if (Int32.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2�� ���ڸ� �Է����ּ���.");
                return;
            }

            if (Int32.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
                return;
            }

            number1 = Convert.ToInt32(Sum1.Text);
            number2 = Convert.ToInt32(Sum2.Text);

            int sum = Add(number1, number2);
            SumResult.Text = sum.ToString();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void Sum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}