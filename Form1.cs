namespace Triangle_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_button_Click(object sender, EventArgs e)
        {

            try
            {
                int SideA = int.Parse(textBox2.Text);
                int SideB = int.Parse(textBox3.Text);
                int SideC = int.Parse(textBox4.Text);
                if (SideA <= 0 || SideB <= 0 || SideC <= 0) { MessageBox.Show("����������� �� �����������"); }
                else if (SideA == SideB && SideB == SideC) { MessageBox.Show("����������� ��������������"); }
                else if (SideA == SideB || SideA == SideC || SideB == SideC) { MessageBox.Show("����������� ��������������"); }
                else if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA) { MessageBox.Show("����������� �� �����������"); }
                else { MessageBox.Show("����������� ��������������"); }
            }
            catch
            {
                MessageBox.Show("������� ����������� ������");
            }
        }
    }
}
