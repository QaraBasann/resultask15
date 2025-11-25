namespace CardInformation
{
    public partial class Form1 : Form
    {
        private void ClearAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

                else if (c is Label)
                {
                    label1.Text = "Card Number";
                    label2.Text = "Name Surname";
                    label3.Text = "CVV";
                    label4.Text = "MM.YY";

                }


                else if (c is DateTimePicker dt)
                    dt.Value = DateTime.Now;


                if (c.HasChildren)
                    ClearAllControls(c);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            if (textBox1.Text.Length == 19)
            {
                textBox1.BackColor = Color.LightGreen;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.White;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }
        int errorCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox2.Text.Contains(" ")))
            {

                MessageBox.Show("Ad ve Soyad arasinda bosluq olmalidir!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {

                MessageBox.Show("Butun xanalar doldurulmalidir!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1.Value <= DateTime.Now)
            {

                MessageBox.Show("Kartin muddeti kecib!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Melumatlar ugurla qeyd edildi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllControls(this);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "CVV")
            {
                pictureBox3.Image = pictureBox4.Image;
                label3.Text = textBox3.Text;
            }
            else
            {
                pictureBox3.Image = pictureBox5.Image;
                label3.Text = "CVV";
            }



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker1.Value.ToString("MM.yy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
