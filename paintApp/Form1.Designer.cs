namespace paintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redoBtn = new System.Windows.Forms.PictureBox();
            this.undoBtn = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorBack2 = new System.Windows.Forms.Button();
            this.widthImg = new System.Windows.Forms.PictureBox();
            this.squareImg = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillImg = new System.Windows.Forms.PictureBox();
            this.polygon = new System.Windows.Forms.PictureBox();
            this.circleImg = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.colorBtn1 = new System.Windows.Forms.ColorDialog();
            this.colorBtn2 = new System.Windows.Forms.ColorDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBack1 = new System.Windows.Forms.Button();
            this.brushImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.redoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.undoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.widthImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.squareImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.fillImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.polygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.circleImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.brushImg)).BeginInit();
            this.SuspendLayout();
            // 
            // redoBtn
            // 
            this.redoBtn.Image = ((System.Drawing.Image) (resources.GetObject("redoBtn.Image")));
            this.redoBtn.Location = new System.Drawing.Point(810, 14);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(24, 24);
            this.redoBtn.TabIndex = 15;
            this.redoBtn.TabStop = false;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Image = ((System.Drawing.Image) (resources.GetObject("undoBtn.Image")));
            this.undoBtn.Location = new System.Drawing.Point(771, 14);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(24, 24);
            this.undoBtn.TabIndex = 14;
            this.undoBtn.TabStop = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBox2.Location = new System.Drawing.Point(707, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 28);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // colorBack2
            // 
            this.colorBack2.BackColor = System.Drawing.Color.White;
            this.colorBack2.Location = new System.Drawing.Point(598, 10);
            this.colorBack2.Name = "colorBack2";
            this.colorBack2.Size = new System.Drawing.Size(32, 27);
            this.colorBack2.TabIndex = 12;
            this.colorBack2.UseVisualStyleBackColor = false;
            this.colorBack2.Click += new System.EventHandler(this.colorBack2_Click);
            // 
            // widthImg
            // 
            this.widthImg.BackColor = System.Drawing.Color.Transparent;
            this.widthImg.Image = ((System.Drawing.Image) (resources.GetObject("widthImg.Image")));
            this.widthImg.Location = new System.Drawing.Point(660, 10);
            this.widthImg.Name = "widthImg";
            this.widthImg.Size = new System.Drawing.Size(32, 32);
            this.widthImg.TabIndex = 8;
            this.widthImg.TabStop = false;
            // 
            // squareImg
            // 
            this.squareImg.BackColor = System.Drawing.Color.Transparent;
            this.squareImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.squareImg.ErrorImage = ((System.Drawing.Image) (resources.GetObject("squareImg.ErrorImage")));
            this.squareImg.Image = ((System.Drawing.Image) (resources.GetObject("squareImg.Image")));
            this.squareImg.InitialImage = ((System.Drawing.Image) (resources.GetObject("squareImg.InitialImage")));
            this.squareImg.Location = new System.Drawing.Point(239, 10);
            this.squareImg.Margin = new System.Windows.Forms.Padding(0);
            this.squareImg.Name = "squareImg";
            this.squareImg.Size = new System.Drawing.Size(32, 26);
            this.squareImg.TabIndex = 3;
            this.squareImg.TabStop = false;
            this.squareImg.Click += new System.EventHandler(this.squareImg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(145, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fillImg
            // 
            this.fillImg.BackColor = System.Drawing.Color.Transparent;
            this.fillImg.Image = ((System.Drawing.Image) (resources.GetObject("fillImg.Image")));
            this.fillImg.Location = new System.Drawing.Point(551, 10);
            this.fillImg.Name = "fillImg";
            this.fillImg.Size = new System.Drawing.Size(37, 34);
            this.fillImg.TabIndex = 4;
            this.fillImg.TabStop = false;
            // 
            // polygon
            // 
            this.polygon.BackColor = System.Drawing.Color.Transparent;
            this.polygon.Image = ((System.Drawing.Image) (resources.GetObject("polygon.Image")));
            this.polygon.Location = new System.Drawing.Point(333, 10);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(32, 26);
            this.polygon.TabIndex = 3;
            this.polygon.TabStop = false;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // circleImg
            // 
            this.circleImg.BackColor = System.Drawing.Color.Transparent;
            this.circleImg.Image = ((System.Drawing.Image) (resources.GetObject("circleImg.Image")));
            this.circleImg.Location = new System.Drawing.Point(286, 10);
            this.circleImg.Name = "circleImg";
            this.circleImg.Size = new System.Drawing.Size(32, 26);
            this.circleImg.TabIndex = 3;
            this.circleImg.TabStop = false;
            this.circleImg.Click += new System.EventHandler(this.circleImg_Click);
            // 
            // paper
            // 
            this.paper.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.InitialImage = ((System.Drawing.Image) (resources.GetObject("paper.InitialImage")));
            this.paper.Location = new System.Drawing.Point(0, 70);
            this.paper.Margin = new System.Windows.Forms.Padding(0);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(1088, 546);
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            this.paper.Paint += new System.Windows.Forms.PaintEventHandler(this.paper_Paint);
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // colorBtn1
            // 
            this.colorBtn1.FullOpen = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(381, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.redoBtn);
            this.panel3.Controls.Add(this.undoBtn);
            this.panel3.Controls.Add(this.colorBack1);
            this.panel3.Controls.Add(this.brushImg);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.widthImg);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.colorBack2);
            this.panel3.Controls.Add(this.squareImg);
            this.panel3.Controls.Add(this.circleImg);
            this.panel3.Controls.Add(this.polygon);
            this.panel3.Controls.Add(this.fillImg);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 70);
            this.panel3.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 22);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = " Название фигуры";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(950, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 14);
            this.label13.TabIndex = 34;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(957, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBox1.Location = new System.Drawing.Point(1007, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 28);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(761, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 14);
            this.label11.TabIndex = 30;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(652, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 14);
            this.label10.TabIndex = 29;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(543, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 14);
            this.label9.TabIndex = 28;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(435, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 14);
            this.label8.TabIndex = 27;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(239, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(941, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 70);
            this.label6.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(754, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 70);
            this.label5.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(645, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 70);
            this.label4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(536, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 70);
            this.label3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(428, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 70);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 70);
            this.label1.TabIndex = 20;
            // 
            // colorBack1
            // 
            this.colorBack1.BackColor = System.Drawing.Color.White;
            this.colorBack1.Location = new System.Drawing.Point(489, 10);
            this.colorBack1.Name = "colorBack1";
            this.colorBack1.Size = new System.Drawing.Size(32, 27);
            this.colorBack1.TabIndex = 11;
            this.colorBack1.UseVisualStyleBackColor = false;
            this.colorBack1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brushImg
            // 
            this.brushImg.BackColor = System.Drawing.Color.Transparent;
            this.brushImg.Image = ((System.Drawing.Image) (resources.GetObject("brushImg.Image")));
            this.brushImg.Location = new System.Drawing.Point(442, 10);
            this.brushImg.Name = "brushImg";
            this.brushImg.Size = new System.Drawing.Size(36, 32);
            this.brushImg.TabIndex = 5;
            this.brushImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paper);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.redoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.undoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.widthImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.squareImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.fillImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.polygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.circleImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.brushImg)).EndInit();
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox brushImg;
        private System.Windows.Forms.Button colorBack1;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox redoBtn;

        private System.Windows.Forms.PictureBox undoBtn;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button colorBack2;
        private System.Windows.Forms.ColorDialog colorBtn2;

        private System.Windows.Forms.ColorDialog colorBtn1;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.PictureBox widthImg;

        private System.Windows.Forms.PictureBox fillImg;

        private System.Windows.Forms.PictureBox polygon;

        private System.Windows.Forms.PictureBox squareImg;

        private System.Windows.Forms.PictureBox circleImg;

        private System.Windows.Forms.PictureBox paper;

        #endregion
    }
}