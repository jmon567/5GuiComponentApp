namespace May5_GuiClassDemo
{
    public partial class Form_5GuiComponents : Form
    {
        public Form_5GuiComponents()
        {
            InitializeComponent();
        }

        private void button_clickme_Click(object sender, EventArgs e)
        {
            label_shorttext.Text = "Clicked! (:";
            richTextBox_paragraph.Visible = false;
            panel2.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 5)
            {

                button_correct.Visible = true;

            }
        }

        private void button_correct_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible=false;
            label_youwon.Visible = true;
            picture_trophy.Visible = true;
        }
    }
}
