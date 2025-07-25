namespace Ruby_Cafe
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            moneyLabelBox = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            payButton = new Button();
            cardListBox = new ListBox();
            label4 = new Label();
            panel3 = new Panel();
            pizzaPictureBox = new PictureBox();
            pancakePictureBox = new PictureBox();
            hotdogPictureBox = new PictureBox();
            hamburgerPictureBox = new PictureBox();
            cupcakePictureBox = new PictureBox();
            cheesePictureBox = new PictureBox();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupcakePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(moneyLabelBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 277);
            panel1.TabIndex = 0;
            // 
            // moneyLabelBox
            // 
            moneyLabelBox.Dock = DockStyle.Bottom;
            moneyLabelBox.ForeColor = Color.FromArgb(255, 92, 83);
            moneyLabelBox.Location = new Point(0, 240);
            moneyLabelBox.Name = "moneyLabelBox";
            moneyLabelBox.Size = new Size(130, 37);
            moneyLabelBox.TabIndex = 3;
            moneyLabelBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.FromArgb(255, 92, 83);
            label2.Location = new Point(0, 62);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Ruby Cafe";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Resource.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(payButton);
            panel2.Controls.Add(cardListBox);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(512, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 277);
            panel2.TabIndex = 1;
            // 
            // payButton
            // 
            payButton.BackColor = SystemColors.ControlLight;
            payButton.Dock = DockStyle.Bottom;
            payButton.Location = new Point(0, 231);
            payButton.Name = "payButton";
            payButton.Size = new Size(130, 46);
            payButton.TabIndex = 2;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // cardListBox
            // 
            cardListBox.BackColor = SystemColors.Control;
            cardListBox.BorderStyle = BorderStyle.FixedSingle;
            cardListBox.Cursor = Cursors.Hand;
            cardListBox.Dock = DockStyle.Fill;
            cardListBox.FormattingEnabled = true;
            cardListBox.Location = new Point(0, 20);
            cardListBox.Name = "cardListBox";
            cardListBox.Size = new Size(130, 257);
            cardListBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Dock = DockStyle.Top;
            label4.ForeColor = Color.FromArgb(255, 92, 83);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 0;
            label4.Text = "Card";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(pizzaPictureBox);
            panel3.Controls.Add(pancakePictureBox);
            panel3.Controls.Add(hotdogPictureBox);
            panel3.Controls.Add(hamburgerPictureBox);
            panel3.Controls.Add(cupcakePictureBox);
            panel3.Controls.Add(cheesePictureBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(130, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 277);
            panel3.TabIndex = 2;
            // 
            // pizzaPictureBox
            // 
            pizzaPictureBox.BorderStyle = BorderStyle.FixedSingle;
            pizzaPictureBox.Cursor = Cursors.Hand;
            pizzaPictureBox.Image = Resource.pizza;
            pizzaPictureBox.Location = new Point(256, 118);
            pizzaPictureBox.Name = "pizzaPictureBox";
            pizzaPictureBox.Size = new Size(119, 109);
            pizzaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pizzaPictureBox.TabIndex = 5;
            pizzaPictureBox.TabStop = false;
            pizzaPictureBox.Click += pizzaPictureBox_Click;
            // 
            // pancakePictureBox
            // 
            pancakePictureBox.BorderStyle = BorderStyle.FixedSingle;
            pancakePictureBox.Cursor = Cursors.Hand;
            pancakePictureBox.Image = Resource.pancake;
            pancakePictureBox.Location = new Point(131, 118);
            pancakePictureBox.Name = "pancakePictureBox";
            pancakePictureBox.Size = new Size(119, 109);
            pancakePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pancakePictureBox.TabIndex = 4;
            pancakePictureBox.TabStop = false;
            pancakePictureBox.Click += pancakePictureBox_Click;
            // 
            // hotdogPictureBox
            // 
            hotdogPictureBox.BorderStyle = BorderStyle.FixedSingle;
            hotdogPictureBox.Cursor = Cursors.Hand;
            hotdogPictureBox.Image = Resource.hotdog;
            hotdogPictureBox.Location = new Point(6, 118);
            hotdogPictureBox.Name = "hotdogPictureBox";
            hotdogPictureBox.Size = new Size(119, 109);
            hotdogPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hotdogPictureBox.TabIndex = 3;
            hotdogPictureBox.TabStop = false;
            hotdogPictureBox.Click += hotdogPictureBox_Click;
            // 
            // hamburgerPictureBox
            // 
            hamburgerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            hamburgerPictureBox.Cursor = Cursors.Hand;
            hamburgerPictureBox.Image = Resource.hamburger;
            hamburgerPictureBox.Location = new Point(256, 3);
            hamburgerPictureBox.Name = "hamburgerPictureBox";
            hamburgerPictureBox.Size = new Size(119, 109);
            hamburgerPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hamburgerPictureBox.TabIndex = 2;
            hamburgerPictureBox.TabStop = false;
            hamburgerPictureBox.Click += hamburgerPictureBox_Click;
            // 
            // cupcakePictureBox
            // 
            cupcakePictureBox.BorderStyle = BorderStyle.FixedSingle;
            cupcakePictureBox.Cursor = Cursors.Hand;
            cupcakePictureBox.Image = Resource.cupcake;
            cupcakePictureBox.Location = new Point(131, 3);
            cupcakePictureBox.Name = "cupcakePictureBox";
            cupcakePictureBox.Size = new Size(119, 109);
            cupcakePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cupcakePictureBox.TabIndex = 1;
            cupcakePictureBox.TabStop = false;
            cupcakePictureBox.Click += cupcakePictureBox_Click;
            // 
            // cheesePictureBox
            // 
            cheesePictureBox.BorderStyle = BorderStyle.FixedSingle;
            cheesePictureBox.Cursor = Cursors.Hand;
            cheesePictureBox.Image = Resource.cheese;
            cheesePictureBox.Location = new Point(6, 3);
            cheesePictureBox.Name = "cheesePictureBox";
            cheesePictureBox.Size = new Size(119, 109);
            cheesePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cheesePictureBox.TabIndex = 0;
            cheesePictureBox.TabStop = false;
            cheesePictureBox.Click += cheesePictureBox_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Location = new Point(252, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 277);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ruby Cafe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupcakePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label moneyLabelBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private ListBox cardListBox;
        private PictureBox cheesePictureBox;
        private PictureBox pizzaPictureBox;
        private PictureBox pancakePictureBox;
        private PictureBox hotdogPictureBox;
        private PictureBox hamburgerPictureBox;
        private PictureBox cupcakePictureBox;
        private Button payButton;
        private Button btnClear;
    }
}
