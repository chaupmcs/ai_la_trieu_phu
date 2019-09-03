using System;
using System.Drawing;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class Form_Author : Form
    {
        public Form_Author()
        {
            InitializeComponent();
        }

        private void Form_Author_Load(object sender, EventArgs e)
        {
            
            richTextBox_author.AutoWordSelection = true;
            richTextBox_author.DetectUrls = true;
            richTextBox_author.ReadOnly = true;
           // richTextBox_author.Cursor = Cursors.Arrow;

            string[] author_words = { "Tác giả: ", "Catbuilts\n\n", "Mọi ý kiến đóng góp xin gửi về ", "catbuilts@gmail.com\n", "Xin cảm ơn." };

            foreach (string word in author_words)
            {
                if (word.Equals("Catbuilts.\n"))
                {
                    richTextBox_author.SelectionFont = new Font("Consolas", 10f, FontStyle.Bold);
                    richTextBox_author.AppendText(word + "\n");
                }
                else
                    if (word.Equals("catbuilts@gmail.com\n"))
                {
                    richTextBox_author.SelectionFont = new Font("Consolas", 10f, FontStyle.Bold);
                    richTextBox_author.AppendText(word + "\n");
                }
                else if (word.Equals("Tác giả: "))
                {
                    richTextBox_author.SelectionFont = new Font(richTextBox_author.SelectionFont, FontStyle.Underline);
                    richTextBox_author.AppendText(word);
                }
                else
                {
                    richTextBox_author.SelectionFont = new Font(richTextBox_author.SelectionFont, FontStyle.Regular);
                    richTextBox_author.AppendText(word);
                }

            }



        }


    }
}
