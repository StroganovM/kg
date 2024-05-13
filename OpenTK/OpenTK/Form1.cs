using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTK
{
    public partial class Form1 : Form
    {
        private Bin bin;
        private View view;
        enum Mode { Quads, Texture2D, QuadStrip};
        private Mode mode = Mode.Quads;
        int currentLayer=1;
        private int min;
        private int width;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                Bin.readBIN(str);
                View.SetupView(glControl1.Width, glControl1.Height);
                loaded= true;
                glControl1.Invalidate();
                trackBar1.Maximum = Bin.Z - 1;
            }
        }
        bool needReloaded = false;
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                switch (mode)
                {
                    case Mode.Quads:
                        View.DrawQuads(currentLayer, min, width);
                        glControl1.SwapBuffers();
                        break;
                    case Mode.Texture2D:
                        if (needReloaded)
                        {
                            View.generateTextureImage(currentLayer, min, width);
                            View.Load2DTexture();
                            needReloaded = false;
                        }
                        View.DrawTexture();
                        glControl1.SwapBuffers();
                        break;
                    case Mode.QuadStrip:
                        View.DrawQuadStrip(currentLayer, min, width);
                        glControl1.SwapBuffers();
                        break;

                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
             currentLayer = trackBar1.Value;
            
             needReloaded = true;
            
            
        }

        void Application_Idle(object slender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }
       

        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if(DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           Application.Idle += Application_Idle;
           currentLayer = 1;
           min = trackBar2.Value;
           width = trackBar3.Value;
           radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.Texture2D;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.Quads;
        }

        

        private void glControl1_Resize(object sender, EventArgs e)
        {
            View.SetupView(glControl1.Width, glControl1.Height);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.QuadStrip;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            min = trackBar2.Value;
            needReloaded = true;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            width = trackBar3.Value;
            needReloaded = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

                
        }

        
    }
}
