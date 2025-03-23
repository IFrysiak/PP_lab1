using System;
using System.Linq;
using System.Windows.Forms;
using PP_lab1;

namespace PP_lab1_WinFormsApp
{
    public partial class Form1 : Form
    {
        private Problem problem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int itemCount) &&
                int.TryParse(textBox2.Text, out int seed) &&
                int.TryParse(textBox3.Text, out int capacity))
            {
                problem = new Problem(itemCount, seed);
                Result result = problem.Solve(capacity);

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listBox1.Items.Add("Selected Items: " + string.Join(", ", result.SelectedItems.OrderBy(i => i)));
                listBox1.Items.Add("Total Value: " + result.TotalValue);
                listBox1.Items.Add("Total Weight: " + result.TotalWeight);

                foreach (var item in problem.Items)
                {
                    listBox2.Items.Add($"{item.OriginalIndex}: Value={item.Value}, Weight={item.Weight}, Ratio={(double)item.Value / item.Weight:F2}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
