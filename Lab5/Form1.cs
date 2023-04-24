using Microsoft.VisualBasic;
using ��������;


namespace Lab5
{
    public partial class Form1 : Form
    {
        Fruit Fruit = null;
        Vegetable vegetable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0, count = 0;

            string name = Interaction.InputBox("������ ����� ������:", "������ �������");
            if (!inputDoble(ref price, "������ ����"))
                return;
            if (!inputDoble(ref count, "������ �������"))
                return;
            Fruit = new Fruit(name, count, price, 20);
            ProductCollection collection = new ProductCollection();
            collection.Add(Fruit);
            Fruit.Info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double price = 0, count = 0;

            string name = Interaction.InputBox("������ ����� �����:", "������ �������");
            if (!inputDoble(ref price, "������ ����"))
                return;
            if (!inputDoble(ref count, "������ �������"))
                return;
            vegetable = new Vegetable(name, count, price, 20);
            ProductCollection collection = new ProductCollection();
            collection.Add(vegetable);
            vegetable.Info();
        }
        static bool inputDoble(ref double x, string Povidom)
        {
            string S;
            S = x.ToString();
        Povtor:
            S = Interaction.InputBox(Povidom, "�������", S);
            try
            {
                x = Convert.ToDouble(S);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("�� ����� �� �����\n\n������ ���������?",
                    "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto Povtor;
                else
                {
                    return false;
                }

            }
            return true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Fruit is not null)
            {
                string fruitName;
                bool isValid = false;

                while (!isValid)
                {
                    fruitName = Interaction.InputBox("������ ����� ������:", "����� ������");

                    if (string.IsNullOrWhiteSpace(fruitName))
                    {
                        MessageBox.Show("������ ����� ������!");
                    }
                    else
                    {
                        isValid = true;
                        Fruit.Name = fruitName;
                    }
                }
                Fruit.Info();
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Fruit is not null)
            {
                double count = 0;
                if (inputDoble(ref count, "������ �������"))
                {
                Fruit.Quantity = count;
                Fruit.Info();
                    return;

                }
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Fruit is null)
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
                return;
            }
            double price = 0;
            if (inputDoble(ref price, "������ �������"))
            {
                Fruit.Price = price;
                Fruit.Info();
                return;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Fruit is null)
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
                return;
            }
            Fruit.Info();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Fruit is null)
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
            else
            {
                Fruit = null;
                MessageBox.Show("���� ��������", "�����", MessageBoxButtons.OK);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vegetable is not null)
            {
                string vgName;
                bool isValid = false;

                while (!isValid)
                {
                    vgName = Interaction.InputBox("������ ����� �����:", "����� ������");

                    if (string.IsNullOrWhiteSpace(vgName))
                    {
                        MessageBox.Show("������ ����� �����!");
                    }
                    else
                    {
                        isValid = true;
                        vegetable.Name = vgName;
                    }
                }
                vegetable.Info();
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(vegetable is not null) {
                double count = 0;
                if (inputDoble(ref count, "������ �������"))
                {
                    vegetable.Quantity = count;
                    vegetable.Info();
                    return;
                }
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
            
                
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (vegetable is not null)
            {
                double price = 0;
                if (inputDoble(ref price, "������ �������"))
                {
                    vegetable.Price = price;
                    vegetable.Info();
                    return;
                }
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (vegetable is not null)
            {
                vegetable.Info();
            }
            else
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (vegetable is null)
            {
                MessageBox.Show("����a �� ����", "�����", MessageBoxButtons.OK);
            }
            else
            {
                vegetable = null;
                MessageBox.Show("���� ��������", "�����", MessageBoxButtons.OK);

            }
        }
    }
}