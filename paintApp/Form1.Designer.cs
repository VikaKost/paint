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
            this.panel1 = new System.Windows.Forms.Panel();
            this.polygon = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.polyline = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.paper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.polygon);
            this.panel1.Controls.Add(this.circle);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.polyline);
            this.panel1.Controls.Add(this.line);
            this.panel1.Location = new System.Drawing.Point(528, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 453);
            this.panel1.TabIndex = 0;
            // 
            // polygon
            // 
            this.polygon.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.polygon.BackColor = System.Drawing.Color.MediumPurple;
            this.polygon.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.polygon.ForeColor = System.Drawing.Color.White;
            this.polygon.Location = new System.Drawing.Point(27, 290);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(220, 60);
            this.polygon.TabIndex = 4;
            this.polygon.Text = "polygon";
            this.polygon.UseVisualStyleBackColor = false;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // circle
            // 
            this.circle.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.circle.BackColor = System.Drawing.Color.MediumPurple;
            this.circle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.circle.ForeColor = System.Drawing.Color.White;
            this.circle.Location = new System.Drawing.Point(27, 224);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(220, 60);
            this.circle.TabIndex = 3;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangle.BackColor = System.Drawing.Color.MediumPurple;
            this.rectangle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rectangle.ForeColor = System.Drawing.Color.White;
            this.rectangle.Location = new System.Drawing.Point(27, 158);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(220, 60);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // polyline
            // 
            this.polyline.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.polyline.BackColor = System.Drawing.Color.MediumPurple;
            this.polyline.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.polyline.ForeColor = System.Drawing.Color.White;
            this.polyline.Location = new System.Drawing.Point(27, 92);
            this.polyline.Name = "polyline";
            this.polyline.Size = new System.Drawing.Size(220, 60);
            this.polyline.TabIndex = 1;
            this.polyline.Text = "polyline";
            this.polyline.UseVisualStyleBackColor = false;
            this.polyline.Click += new System.EventHandler(this.polyline_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.MediumPurple;
            this.line.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(27, 26);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(220, 60);
            this.line.TabIndex = 0;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // paper
            // 
            this.paper.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.Location = new System.Drawing.Point(1, 1);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(529, 446);
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.paper)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button polygon;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button polyline;
        private System.Windows.Forms.Button rectangle;

        private System.Windows.Forms.Button line;

        private System.Windows.Forms.PictureBox paper;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}