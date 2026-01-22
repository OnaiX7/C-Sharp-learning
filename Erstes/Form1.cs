namespace Erstes
{
    public partial class Form1 : Form
    {
        private Logic logic = new();
        public Form1()
        {

            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            textBox1.AllowDrop = true;
        }
        private void button1_Click(object sender, EventArgs e) 
            => this.logic.ExitApplication();

        private void universal_MouseDown(object sender, MouseEventArgs e) 
            => this.logic.DoMouseDown(e, sender);

        private void universal_DragEnter(object sender, DragEventArgs e) 
            => this.logic.DoDragEnter(e);

        private void universal_DragDrop(object sender, DragEventArgs e) 
            => this.logic.DoDragDrop(sender);

        private void universal_Click(object sender, EventArgs e) 
            => this.logic.DoClick(e);

        private void button2_Click(object sender, EventArgs e) 
            => this.logic.ResetPictureBoxes();

        public void textBox1_DragDrop(object sender, DragEventArgs e) 
            => this.logic.textDragDrop(sender, e);
        }
    }