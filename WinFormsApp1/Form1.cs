using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void save_Click(object sender, EventArgs e)
        {
            Person person = new Person();


            if (textBox2.TextLength > 2 && textBox3.TextLength > 2 && textBox4.TextLength > 2 && textBox5.TextLength > 2 && textBox6.TextLength > 2 && textBox1.TextLength > 2 && textBox1.TextLength <= 10)
            {
                person.Surname = textBox2.Text;
                person.Name = textBox3.Text;
                person.FatherName = textBox4.Text;
                person.Country = textBox5.Text;
                person.City = textBox6.Text;
                if (int.TryParse(textBox1.Text, out int number))
                {
                    person.Telephone = number.ToString();
                }
                else
                {
                    MessageBox.Show("Qaqa nomre sehvdi ee", "Sehv eledun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
                {
                MessageBox.Show("Qaqa bolmeler 3 herfden cox olmalidi", "Sehv eledun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            person.BirthDate = dateTimePicker1.Value;

            if (male.Checked)
                person.Gender = true;
            else
                person.Gender = false;

            string str = JsonSerializer.Serialize(person);

            File.WriteAllText($"{person.Name}.json", str);
            MessageBox.Show("Save olundu", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox1.Text = "(------------)";
            dateTimePicker1.Value = DateTime.Now;
            male.Checked = false;
            female.Checked = false;
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            string? fileName = $"{loadBox.Text}.json";
            if (File.Exists(fileName))
            {
                string[] s = File.ReadAllLines(fileName);
                Person? p = new();

                foreach (string s2 in s)
                    p = JsonSerializer.Deserialize<Person>(s2);

                if (p != null)
                {
                    textBox2.Text = p.Surname;
                    textBox3.Text = p.Name;
                    textBox4.Text = p.FatherName;
                    textBox5.Text = p.Country;
                    textBox6.Text = p.City;
                    textBox1.Text = p.Telephone;
                    dateTimePicker1.Value = p.BirthDate;

                    if (p.Gender)
                        male.Checked = true;
                    else
                        female.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Qaqa bele biri movjud degil ;-)", "Xeberdarlig edirem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


    }
}