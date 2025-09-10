namespace WinFormsApp1
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
            numericUpDownSize = new NumericUpDown();
            numericUpDownMin = new NumericUpDown();
            numericUpDownMax = new NumericUpDown();
            comboBoxTask = new ComboBox();
            btnGenerate = new Button();
            btnLoadFile = new Button();
            btnParse = new Button();
            btnExecute = new Button();
            txtArray = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDownSize
            // 
            numericUpDownSize.Location = new Point(151, 29);
            numericUpDownSize.Name = "numericUpDownSize";
            numericUpDownSize.Size = new Size(72, 27);
            numericUpDownSize.TabIndex = 0;
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Location = new Point(56, 59);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(72, 27);
            numericUpDownMin.TabIndex = 1;
            numericUpDownMin.ValueChanged += numericUpDownMin_ValueChanged;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Location = new Point(56, 96);
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(72, 27);
            numericUpDownMax.TabIndex = 2;
            // 
            // comboBoxTask
            // 
            comboBoxTask.FormattingEnabled = true;
            comboBoxTask.Location = new Point(170, 26);
            comboBoxTask.Name = "comboBoxTask";
            comboBoxTask.Size = new Size(202, 28);
            comboBoxTask.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(407, 31);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(165, 31);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(605, 31);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(156, 31);
            btnLoadFile.TabIndex = 5;
            btnLoadFile.Text = "Загрузить из файла";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(496, 87);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(179, 31);
            btnParse.TabIndex = 6;
            btnParse.Text = "Разобрать текст";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(97, 63);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(189, 43);
            btnExecute.TabIndex = 7;
            btnExecute.Text = "Выполнить задание";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtArray
            // 
            txtArray.Location = new Point(15, 26);
            txtArray.Multiline = true;
            txtArray.Name = "txtArray";
            txtArray.ScrollBars = ScrollBars.Vertical;
            txtArray.Size = new Size(334, 241);
            txtArray.TabIndex = 8;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ButtonHighlight;
            txtResult.Location = new Point(18, 144);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(354, 123);
            txtResult.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 10;
            label1.Text = "Размер массива";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 11;
            label2.Text = "Мин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 12;
            label3.Text = "Макс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 29);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 13;
            label4.Text = "Выберите задание: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArray);
            groupBox1.Location = new Point(12, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 286);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Массив";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxTask);
            groupBox2.Controls.Add(txtResult);
            groupBox2.Controls.Add(btnExecute);
            groupBox2.Location = new Point(401, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 286);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задание и результат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 112);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLoadFile);
            groupBox3.Controls.Add(btnParse);
            groupBox3.Controls.Add(btnGenerate);
            groupBox3.Controls.Add(numericUpDownMax);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(numericUpDownMin);
            groupBox3.Controls.Add(numericUpDownSize);
            groupBox3.Location = new Point(12, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 133);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Параметры массива";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownSize;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownMax;
        private ComboBox comboBoxTask;
        private Button btnGenerate;
        private Button btnLoadFile;
        private Button btnParse;
        private Button btnExecute;
        private TextBox txtArray;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private GroupBox groupBox3;
    }
}
