namespace CS252_homework2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SquareLengthLabel1 = new System.Windows.Forms.Label();
            this.SquareWidthLabel2 = new System.Windows.Forms.Label();
            this.SquareLengthTextBox1 = new System.Windows.Forms.TextBox();
            this.SquareWidthTextBox2 = new System.Windows.Forms.TextBox();
            this.DrawSquareButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SquareLengthLabel1
            // 
            this.SquareLengthLabel1.AutoSize = true;
            this.SquareLengthLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SquareLengthLabel1.Location = new System.Drawing.Point(24, 25);
            this.SquareLengthLabel1.Name = "SquareLengthLabel1";
            this.SquareLengthLabel1.Size = new System.Drawing.Size(122, 20);
            this.SquareLengthLabel1.TabIndex = 0;
            this.SquareLengthLabel1.Text = "Sauqre_Length";
            // 
            // SquareWidthLabel2
            // 
            this.SquareWidthLabel2.AutoSize = true;
            this.SquareWidthLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SquareWidthLabel2.Location = new System.Drawing.Point(26, 64);
            this.SquareWidthLabel2.Name = "SquareWidthLabel2";
            this.SquareWidthLabel2.Size = new System.Drawing.Size(115, 20);
            this.SquareWidthLabel2.TabIndex = 1;
            this.SquareWidthLabel2.Text = "Square_Width";
            // 
            // SquareLengthTextBox1
            // 
            this.SquareLengthTextBox1.Location = new System.Drawing.Point(214, 25);
            this.SquareLengthTextBox1.Name = "SquareLengthTextBox1";
            this.SquareLengthTextBox1.Size = new System.Drawing.Size(100, 22);
            this.SquareLengthTextBox1.TabIndex = 2;
            // 
            // SquareWidthTextBox2
            // 
            this.SquareWidthTextBox2.Location = new System.Drawing.Point(214, 61);
            this.SquareWidthTextBox2.Name = "SquareWidthTextBox2";
            this.SquareWidthTextBox2.Size = new System.Drawing.Size(100, 22);
            this.SquareWidthTextBox2.TabIndex = 3;
            // 
            // DrawSquareButton1
            // 
            this.DrawSquareButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DrawSquareButton1.Location = new System.Drawing.Point(384, 21);
            this.DrawSquareButton1.Name = "DrawSquareButton1";
            this.DrawSquareButton1.Size = new System.Drawing.Size(137, 47);
            this.DrawSquareButton1.TabIndex = 4;
            this.DrawSquareButton1.Text = "StartDarwSqure";
            this.DrawSquareButton1.UseVisualStyleBackColor = true;
            this.DrawSquareButton1.Click += new System.EventHandler(this.DrawSquareButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 264);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DrawSquareButton1);
            this.Controls.Add(this.SquareWidthTextBox2);
            this.Controls.Add(this.SquareLengthTextBox1);
            this.Controls.Add(this.SquareWidthLabel2);
            this.Controls.Add(this.SquareLengthLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SquareLengthLabel1;
        private System.Windows.Forms.Label SquareWidthLabel2;
        private System.Windows.Forms.TextBox SquareLengthTextBox1;
        private System.Windows.Forms.TextBox SquareWidthTextBox2;
        private System.Windows.Forms.Button DrawSquareButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

