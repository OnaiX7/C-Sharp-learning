using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Erstes
{
    internal class Logic
    {
        private Image transportImage;
        public void ExitApplication()
        {

            if (MessageBox.Show("Möchtest du das Programm wirklich verlassen?", "Programmende", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void DoDragEnter(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public void DoDragDrop(object sender)
        {
            PictureBox universal_pictureBox = (PictureBox)sender;
            universal_pictureBox.Image = this.transportImage;
        }

        public void DoMouseDown(MouseEventArgs e, object sender)
        {
            PictureBox universal_pictureBox = (PictureBox)sender;
            if (e.Button is not MouseButtons.Left || universal_pictureBox.Image is null) return;

            this.transportImage = universal_pictureBox.Image;
            universal_pictureBox.DoDragDrop(this.transportImage, DragDropEffects.Copy);
        }

        public void DoClick(object sender)
        {
            PictureBox universal_pictureBox = (PictureBox)sender;
        }

        public void ResetPictureBoxes()
        {
           
        }

        public void textDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            TextBox textloeser = (TextBox)sender;

            if (files != null && files.Length > 0)
            {
                string filePath = files[0];
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                {
                    textloeser.Text = File.ReadAllText(filePath);
                }

                else
                {
                    MessageBox.Show("Bitte nur .txt-Dateien einfügen!");
                }
            }
        }
    }
}