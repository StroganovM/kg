using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_LR
{
    public partial class Form1 : Form
    {

        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png; *.jpg; *.bmp|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilters();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true) image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

         private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            backgroundWorker1.CancelAsync();
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void полутонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void добавитьЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new AddBrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Files (.png)|.png|JPEG Files (.jpg)|.jpg|BMP Files (.bmp)|.bmp|All files (.)|.";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image.Save(saveDialog.FileName);
                    MessageBox.Show("Изображение сохранено.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void вертикальныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilterVertical();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void горизонтальныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilterHorizontal();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TurnFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void переносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TransferFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void щаррToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void прюиттToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PruitFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void зеркалоToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters filter = new MirrorFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
    
}
