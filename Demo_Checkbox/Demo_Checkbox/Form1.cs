namespace Demo_Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("CC");
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("CTC");
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string gioitinh = checkGt.CheckState == CheckState.Checked ? "la" : checkGt.CheckState == CheckState.Unchecked ? "khong phai la" : "phai cung khong phai la";
            string s = string.Format("Chao {0}, ban {1} la nam ", name, gioitinh);
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}