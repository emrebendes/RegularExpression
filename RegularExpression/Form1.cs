using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = @"^-?[0-9]*(\.[0-9]*)?";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                Regex regex = new Regex(textBox2.Text);
                MatchCollection mc = regex.Matches(textBox1.Text);
                if (mc.Count == 0)
                    listBox1.Items.Add("eþleþme yok");
                else
                    foreach (Match m in mc)
                        listBox1.Items.Add(m.Value);
            }
            catch (Exception re)
            {
                listBox1.Items.Add(re.Message);
            }
               
        }
    }
}