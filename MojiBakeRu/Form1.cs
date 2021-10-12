using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojiBakeRu
{
    public partial class MojiBakeRuMainForm : Form
    {
        public MojiBakeRuMainForm()
        {
            InitializeComponent();

            EncodeTypeBox.Items.Add("Unicode");
            EncodeTypeBox.Items.Add("shift_jis");
        }

        private void MojiBakeRuMainForm_Load(object sender, EventArgs e)
        {
            InputBox.Text = "モジバケル";
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
            Environment.Exit(1);
        }

        string mojibake(string s,string encodetype)
        {
            byte[] data = Encoding.UTF8.GetBytes(s);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string text = "";

            if (EncodeTypeBox.Text.Length != 0)
            {
                try
                {
                    text = Encoding.GetEncoding(encodetype).GetString(data);
                }
                catch
                {

                }
            }

            return text;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            MojiBaketaBox.Text = mojibake(InputBox.Text,EncodeTypeBox.Text);
        }

        private void EncodeTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MojiBaketaBox.Text = mojibake(InputBox.Text, EncodeTypeBox.Text);
        }

        private void HowToUseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("文字を入れると文字化けができます。\nただそれだけ。","使い方");
        }
    }
}
