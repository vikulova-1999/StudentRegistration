using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Person
        {
            public String F;
            public String I;
            public String O;
            public String S;
            public String G;
            public String Fack;
            public String N;
        }
        int res = 0;


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Person> persons = new List<Person>();

            Person p;
            p.I = textBox1.Text;
            p.F = textBox2.Text;
            p.O = textBox3.Text;
            p.S = textBox4.Text;
            p.G = textBox5.Text;
            p.Fack = textBox6.Text;
            p.N = textBox7.Text;
            persons.Add(p);

            ListViewItem a = new ListViewItem();
            a.Text = p.I;
            ListViewItem.ListViewSubItem b = new ListViewItem.ListViewSubItem();
            b.Text = p.F;
            ListViewItem.ListViewSubItem c = new ListViewItem.ListViewSubItem();
            c.Text = p.O;
            ListViewItem.ListViewSubItem d = new ListViewItem.ListViewSubItem();
            d.Text = p.S;
            ListViewItem.ListViewSubItem g = new ListViewItem.ListViewSubItem();
            g.Text = p.G;
            ListViewItem.ListViewSubItem f = new ListViewItem.ListViewSubItem();
            f.Text = p.Fack;
            ListViewItem.ListViewSubItem n = new ListViewItem.ListViewSubItem();
            n.Text = p.N;

            a.SubItems.Add(b);
            a.SubItems.Add(c);
            a.SubItems.Add(d);
            a.SubItems.Add(g);
            a.SubItems.Add(f);
            a.SubItems.Add(n);
            listView1.Items.Add(a);
            res++;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            listView1.SelectedItems[0].Remove();
            res--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(res.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == textBox2.Text)
                {
                    MessageBox.Show("Имя: " + listView1.Items[i].Text
                     + "\nФамилия: " + listView1.Items[i].SubItems[1].Text
                     + "\nОтчество: " + listView1.Items[i].SubItems[2].Text
                     + "\nШифр: " + listView1.Items[i].SubItems[3].Text
                     + "\nГруппа: " + listView1.Items[i].SubItems[4].Text
                     + "\nФакультет: " + listView1.Items[i].SubItems[5].Text
                     + "\nНаправление: " + listView1.Items[i].SubItems[6].Text);                  
                }
            }
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[5].Text == textBox6.Text)
                {
                    MessageBox.Show("Имя: " + listView1.Items[i].Text
                     + "\nФамилия: " + listView1.Items[i].SubItems[1].Text
                     + "\nОтчество: " + listView1.Items[i].SubItems[2].Text
                     + "\nШифр: " + listView1.Items[i].SubItems[3].Text
                     + "\nГруппа: " + listView1.Items[i].SubItems[4].Text
                     + "\nФакультет: " + listView1.Items[i].SubItems[5].Text
                     + "\nНаправление: " + listView1.Items[i].SubItems[6].Text);
                }
            }
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[4].Text == textBox5.Text)
                {
                    MessageBox.Show("Имя: " + listView1.Items[i].Text
                     + "\nФамилия: " + listView1.Items[i].SubItems[1].Text
                     + "\nОтчество: " + listView1.Items[i].SubItems[2].Text
                     + "\nШифр: " + listView1.Items[i].SubItems[3].Text
                     + "\nГруппа: " + listView1.Items[i].SubItems[4].Text
                     + "\nФакультет: " + listView1.Items[i].SubItems[5].Text
                     + "\nНаправление: " + listView1.Items[i].SubItems[6].Text);
                }               
            }
            textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if ((listView1.Items[i].SubItems[6].Text == textBox7.Text) 
                    && (listView1.Items[i].SubItems[5].Text != textBox6.Text))
                {
                    MessageBox.Show("Имя: " + listView1.Items[i].Text
                     + "\nФамилия: " + listView1.Items[i].SubItems[1].Text
                     + "\nОтчество: " + listView1.Items[i].SubItems[2].Text
                     + "\nШифр: " + listView1.Items[i].SubItems[3].Text
                     + "\nГруппа: " + listView1.Items[i].SubItems[4].Text
                     + "\nФакультет: " + listView1.Items[i].SubItems[5].Text
                     + "\nНаправление: " + listView1.Items[i].SubItems[6].Text);
                }
            }
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
