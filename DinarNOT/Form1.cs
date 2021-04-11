using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinarNOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int vize, final, gecme;

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox3.Text !="")
            {
                if(Convert.ToInt32(richTextBox3.Text)>=90)
                {
                    richTextBox4.Text = "AA";
                }
                else if(Convert.ToInt32(richTextBox3.Text)>=85)
                {
                    richTextBox4.Text = "BA";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 75)
                {
                    richTextBox4.Text = "BB";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 70)
                {
                    richTextBox4.Text = "CB";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 60)
                {
                    richTextBox4.Text = "CC";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 50)
                {
                    richTextBox4.Text = "DC";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 40)
                {
                    richTextBox4.Text = "DD";
                }
                else if (Convert.ToInt32(richTextBox3.Text) >= 30)
                {
                    richTextBox4.Text = "FD";
                }
                else
                {
                    richTextBox4.Text = "FF";
                }
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                saveFileDialog2.Filter = "Word dosyaları (*.docx)|*.docx|Tüm dosyalar (*.*)|*.*";
                saveFileDialog2.DefaultExt = ".docx";

                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog2.FileName);
                    sw.Write(label1.Text + richTextBox1.Text + "\n");
                    sw.Write(label2.Text + richTextBox2.Text + "\n");
                    sw.Write(label3.Text + richTextBox3.Text + "\n");
                    sw.Write(label4.Text + richTextBox4.Text + "\n");

                    MessageBox.Show("Dosya Kaydedildi", "Dosya Yolu : " + saveFileDialog2.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();

                }
       
               
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label1.ForeColor = Color.Red;
            }

         }

            OpenFileDialog file_open = new OpenFileDialog();

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
            saveFileDialog1.DefaultExt = ".txt";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
              
                writer.Write(label1.Text+richTextBox1.Text+"\n");
                writer.Write(label2.Text + richTextBox2.Text + "\n");
                writer.Write(label3.Text + richTextBox3.Text + "\n");
                writer.Write(label4.Text + richTextBox4.Text + "\n");
               
                MessageBox.Show("Dosya Kaydedildi", "Dosya Yolu : " + saveFileDialog1.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                writer.Close();
               
            }

        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            const string message ="Çıkmak istediğinizden emin misiniz?";
            const string caption = "Çıkış";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {  
                Application.Exit();
            }

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazırlayan : Eyüp Can Balaban\nProgram ücretsizdir ve her yere dağıtabilirsiniz\nProgram geliştirme devam edilecektir.", "Hakkında");
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                richTextBox1.Copy();

            }
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                richTextBox2.Paste();
                Clipboard.Clear();

            }
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                richTextBox1.Copy();

            }

            
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                richTextBox2.Paste();
                Clipboard.Clear();

            }
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında eklenecektir.");
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {

                richTextBox1.Cut();

            }
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {

                richTextBox1.Undo();
                richTextBox1.ClearUndo();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            label5.Text = saat;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris_form giris = new giris_form();
            giris.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox2.Text !="")
            {
                if(Convert.ToInt32(richTextBox2.Text)>100)
                {
                    MessageBox.Show("Hatalı Giriş");
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    richTextBox4.Clear();
                    richTextBox3.BackColor = Color.White;
                }
                else
                {
                    if(richTextBox1.Text !="")
                    {
                        vize = Convert.ToInt32(richTextBox1.Text);
                        final = Convert.ToInt32(richTextBox2.Text);
                        gecme = 2 * vize / 5 + 3 * final / 5;
                        richTextBox3.Text = gecme.ToString();

                        if(gecme>=60)
                        {
                            richTextBox3.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            richTextBox3.BackColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                richTextBox3.Clear();
                richTextBox4.Clear();
                richTextBox3.BackColor = Color.White;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text !="")
            { 
            if (Convert.ToInt32(richTextBox1.Text)>100)
            {
                MessageBox.Show("Hatalı Giriş");
                richTextBox2.Clear();
                richTextBox3.Clear();
                richTextBox4.Clear();
                richTextBox3.BackColor = Color.White;
            }
            else
            {
                if(richTextBox2.Text !="")
                {
                    vize = Convert.ToInt32(richTextBox1.Text);
                    final = Convert.ToInt32(richTextBox2.Text);
                    gecme = 2 * vize / 5 + 3 * final / 5;
                    richTextBox3.Text = gecme.ToString();
                    if(gecme >=60)
                    {
                        richTextBox3.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        richTextBox3.BackColor = Color.Red;
                    }
                }
               
}
            }
            else
            {
                richTextBox2.Clear();
                richTextBox3.Clear();
                richTextBox4.Clear();
            }
        }
     
    }
}
