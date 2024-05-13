using OpenTK.Graphics;
using System.IO;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms.Design;
using System.Drawing.Imaging;
using OpenTK.Math;
using System;

namespace OpenTK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        bool loaded = false;
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 14);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1101, 519);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1021, 699);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(16, 555);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(915, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1033, 558);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quad";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1033, 582);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Texture";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1033, 606);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "QuadStrip";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выбор слоя";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(15, 617);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(915, 56);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.Location = new System.Drawing.Point(16, 676);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar3.Maximum = 225;
            this.trackBar3.Minimum = 10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(915, 56);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.Value = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цветовой диапазон";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1021, 657);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 743);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.glControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GLControl glControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        class Bin
        {
            public static int X, Y, Z;
            public static short[] array;
            public Bin() { }

            public static void readBIN(string path)
            {
                if (File.Exists(path))
                {
                    BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                    X=reader.ReadInt32();
                    Y=reader.ReadInt32();
                    Z=reader.ReadInt32();
                    int arraySize = X * Y * Z;
                    array = new short[arraySize];
                    for (int i = 0; i < arraySize; ++i)
                    {
                        array[i]=reader.ReadInt16();
                    }
                }
            }
        }
        class View
        {
             public static Bitmap textureImage;
            static int VBOtexture;
            
            public static  void SetupView(int width, int height)
            {
                GL.ShadeModel(ShadingModel.Smooth);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadIdentity();
                GL.Ortho(0, Bin.X,0, Bin.Y, -1,1);
                GL.Viewport(0,0,width,height);
            }
            public static int Clamp(int value, int min, int max)
            {
                if (value < min) return min;
                if (value > max) return max;
                return value;
            }
             static Color TransferFunction(short value, int min, int width)
            {
                int max = min + width;
                int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
                return Color.FromArgb(newVal, newVal, newVal);
            }
            

            public static void DrawQuads(int layerNumber, int min, int width)
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.Begin(BeginMode.Quads);
                for(int x_coord = 0; x_coord < Bin.X-1;x_coord++) 
                    for(int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                    {
                        short value;
                        value = Bin.array[x_coord+y_coord*Bin.X+layerNumber*Bin.X*Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord, y_coord);

                        value = Bin.array[x_coord + (y_coord+1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord, y_coord+1);

                        value = Bin.array[x_coord+1 + (y_coord+1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord+1, y_coord+1);

                        value = Bin.array[x_coord+1 + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord+1, y_coord);
                    }
                GL.End();
            }
            public static void DrawQuadStrip(int layerNumber, int min, int width)
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                {
                    GL.Begin(BeginMode.QuadStrip);
                    for (int x_coord = 0; x_coord < Bin.X; x_coord++)
                    {
                        short value;
                        //1 вершина
                        value = Bin.array[x_coord + y_coord * Bin.X
                                            + layerNumber * Bin.X * Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord, y_coord);
                        //2 вершина
                        value = Bin.array[x_coord + (y_coord + 1) * Bin.X
                                            + layerNumber * Bin.X * Bin.Y];
                        GL.Color3(TransferFunction(value, min, width));
                        GL.Vertex2(x_coord, y_coord + 1);
                    }
                    GL.End();
                }
            }

                public static void Load2DTexture()
            {
                GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
                BitmapData data = textureImage.LockBits(
                    new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
                    ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, 
                    data.Width, data.Height, 0, (Graphics.PixelFormat)OpenTK.Graphics.OpenGL.PixelFormat.Bgra, 
                    PixelType.UnsignedByte, data.Scan0);

                textureImage.UnlockBits(data);

                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMagFilter.Linear);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

                ErrorCode Er=GL.GetError();
                string str = Er.ToString();
            }

            public static void generateTextureImage (int layerNumber, int min, int width)
            {
                textureImage = new Bitmap(Bin.X, Bin.Y);
                for (int i = 0; i < Bin.X; ++i)
                    for (int j = 0; j < Bin.Y; ++j)
                    {
                        int pixelNumber =i + j * Bin.X + layerNumber * Bin.X*Bin.Y;
                        textureImage.SetPixel(i, j, TransferFunction(Bin.array[pixelNumber], min, width));
                    }
            }

            public static  void DrawTexture()
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.Enable(EnableCap.Texture2D);
                GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

                GL.Begin(BeginMode.Quads);
                GL.Color3(Color.White);

                GL.TexCoord2(0f,0f);
                GL.Vertex2(0,0);

                GL.TexCoord2(0f, 1f);
                GL.Vertex2(0, Bin.Y);

                GL.TexCoord2(1f, 1f);
                GL.Vertex2(Bin.X, Bin.Y);

                GL.TexCoord2(1f, 0f);
                GL.Vertex2(Bin.X, 0);

                GL.End();

                GL.Disable(EnableCap.Texture2D);
            }
            

        }



        private System.Windows.Forms.CheckBox checkBox1;
    }
    }

