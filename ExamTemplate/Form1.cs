using System.IO;
namespace ExamTemplate
{
    public partial class Form1 : Form
    {
        private int correct, current;
        private FileStream file;
        private StreamReader reader;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            correct = 0;
        }

        ~Form1()
        {
            file.Close();
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file = new FileStream("Data.txt", FileMode.Open);
            reader = new StreamReader(file);

            button1.Text = "Submit";
            Question.Text = reader.ReadLine();
            Answer1.Text = reader.ReadLine();
            Answer2.Text = reader.ReadLine();
            Answer3.Text = reader.ReadLine();
            Answer4.Text = reader.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(reader.ReadLine());

            switch (n)
            {
                case 1:
                    if (Answer1.Enabled == true)
                    {
                        correct++;
                    }
                    break;
                case 2:
                    if (Answer2.Enabled == true)
                    {
                        correct++;
                    }
                    break;
                case 3:
                    if (Answer3.Enabled == true)
                    {
                        correct++;
                    }
                    break;
                case 4:
                    if (Answer4.Enabled == true)
                    {
                        correct++;
                    }
                    break;
            }
            current++;

            Question.Text = reader.ReadLine();
            Answer1.Text = reader.ReadLine();
            Answer2.Text = reader.ReadLine();
            Answer3.Text = reader.ReadLine();
            Answer4.Text = reader.ReadLine();

            progressBar1.Increment(10);

            if (current == 10)
            {
                Answer1.Hide();
                Answer2.Hide();
                Answer3.Hide();
                Answer4.Hide();
                button1.Text = "Exit";
                Question.Text = $"Shen gaeci {correct} shekitxvas sworad atidan\n es aris {correct}0%";
            }
            if (current == 11)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}