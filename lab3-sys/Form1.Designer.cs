namespace lab3_sys
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.evolutionStageLabel = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.initialFishCountTextBox = new System.Windows.Forms.TextBox();
            this.initialPredatorCountTextBox = new System.Windows.Forms.TextBox();
            this.ageToBreedTextBox = new System.Windows.Forms.TextBox();
            this.breedIntervalTextBox = new System.Windows.Forms.TextBox();
            this.predatorAgeToBreedTextBox = new System.Windows.Forms.TextBox();
            this.predatorBreedIntervalTextBox = new System.Windows.Forms.TextBox();
            this.predatorStarvationIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sizeX_TextBox = new System.Windows.Forms.TextBox();
            this.sizeY_TextBox = new System.Windows.Forms.TextBox();
            this.pixelSizeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(595, 261);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(595, 299);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evolution stage:";
            // 
            // evolutionStageLabel
            // 
            this.evolutionStageLabel.AutoSize = true;
            this.evolutionStageLabel.Location = new System.Drawing.Point(676, 325);
            this.evolutionStageLabel.Name = "evolutionStageLabel";
            this.evolutionStageLabel.Size = new System.Drawing.Size(13, 13);
            this.evolutionStageLabel.TabIndex = 4;
            this.evolutionStageLabel.Text = "0";
            // 
            // restartBtn
            // 
            this.restartBtn.Enabled = false;
            this.restartBtn.Location = new System.Drawing.Point(676, 279);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 5;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // initialFishCountTextBox
            // 
            this.initialFishCountTextBox.Location = new System.Drawing.Point(840, 77);
            this.initialFishCountTextBox.Name = "initialFishCountTextBox";
            this.initialFishCountTextBox.Size = new System.Drawing.Size(51, 20);
            this.initialFishCountTextBox.TabIndex = 6;
            this.initialFishCountTextBox.Text = "600";
            // 
            // initialPredatorCountTextBox
            // 
            this.initialPredatorCountTextBox.Location = new System.Drawing.Point(897, 77);
            this.initialPredatorCountTextBox.Name = "initialPredatorCountTextBox";
            this.initialPredatorCountTextBox.Size = new System.Drawing.Size(51, 20);
            this.initialPredatorCountTextBox.TabIndex = 7;
            this.initialPredatorCountTextBox.Text = "80";
            // 
            // ageToBreedTextBox
            // 
            this.ageToBreedTextBox.Location = new System.Drawing.Point(840, 103);
            this.ageToBreedTextBox.Name = "ageToBreedTextBox";
            this.ageToBreedTextBox.Size = new System.Drawing.Size(51, 20);
            this.ageToBreedTextBox.TabIndex = 8;
            this.ageToBreedTextBox.Text = "6";
            // 
            // breedIntervalTextBox
            // 
            this.breedIntervalTextBox.Location = new System.Drawing.Point(840, 129);
            this.breedIntervalTextBox.Name = "breedIntervalTextBox";
            this.breedIntervalTextBox.Size = new System.Drawing.Size(51, 20);
            this.breedIntervalTextBox.TabIndex = 9;
            this.breedIntervalTextBox.Text = "2";
            // 
            // predatorAgeToBreedTextBox
            // 
            this.predatorAgeToBreedTextBox.Location = new System.Drawing.Point(897, 103);
            this.predatorAgeToBreedTextBox.Name = "predatorAgeToBreedTextBox";
            this.predatorAgeToBreedTextBox.Size = new System.Drawing.Size(51, 20);
            this.predatorAgeToBreedTextBox.TabIndex = 10;
            this.predatorAgeToBreedTextBox.Text = "5";
            // 
            // predatorBreedIntervalTextBox
            // 
            this.predatorBreedIntervalTextBox.Location = new System.Drawing.Point(897, 129);
            this.predatorBreedIntervalTextBox.Name = "predatorBreedIntervalTextBox";
            this.predatorBreedIntervalTextBox.Size = new System.Drawing.Size(51, 20);
            this.predatorBreedIntervalTextBox.TabIndex = 11;
            this.predatorBreedIntervalTextBox.Text = "4";
            // 
            // predatorStarvationIntervalTextBox
            // 
            this.predatorStarvationIntervalTextBox.Location = new System.Drawing.Point(897, 155);
            this.predatorStarvationIntervalTextBox.Name = "predatorStarvationIntervalTextBox";
            this.predatorStarvationIntervalTextBox.Size = new System.Drawing.Size(51, 20);
            this.predatorStarvationIntervalTextBox.TabIndex = 12;
            this.predatorStarvationIntervalTextBox.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Predator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Age to breed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Breed interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Starvation interval";
            // 
            // sizeX_TextBox
            // 
            this.sizeX_TextBox.Location = new System.Drawing.Point(897, 216);
            this.sizeX_TextBox.Name = "sizeX_TextBox";
            this.sizeX_TextBox.Size = new System.Drawing.Size(51, 20);
            this.sizeX_TextBox.TabIndex = 19;
            this.sizeX_TextBox.Text = "80";
            // 
            // sizeY_TextBox
            // 
            this.sizeY_TextBox.Location = new System.Drawing.Point(897, 242);
            this.sizeY_TextBox.Name = "sizeY_TextBox";
            this.sizeY_TextBox.Size = new System.Drawing.Size(51, 20);
            this.sizeY_TextBox.TabIndex = 20;
            this.sizeY_TextBox.Text = "60";
            // 
            // pixelSizeTextBox
            // 
            this.pixelSizeTextBox.Location = new System.Drawing.Point(897, 268);
            this.pixelSizeTextBox.Name = "pixelSizeTextBox";
            this.pixelSizeTextBox.Size = new System.Drawing.Size(51, 20);
            this.pixelSizeTextBox.TabIndex = 21;
            this.pixelSizeTextBox.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(877, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(844, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fish size";
            // 
            // timerIntervalTextBox
            // 
            this.timerIntervalTextBox.Location = new System.Drawing.Point(897, 294);
            this.timerIntervalTextBox.Name = "timerIntervalTextBox";
            this.timerIntervalTextBox.Size = new System.Drawing.Size(51, 20);
            this.timerIntervalTextBox.TabIndex = 25;
            this.timerIntervalTextBox.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Delay in animation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timerIntervalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pixelSizeTextBox);
            this.Controls.Add(this.sizeY_TextBox);
            this.Controls.Add(this.sizeX_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.predatorStarvationIntervalTextBox);
            this.Controls.Add(this.predatorBreedIntervalTextBox);
            this.Controls.Add(this.predatorAgeToBreedTextBox);
            this.Controls.Add(this.breedIntervalTextBox);
            this.Controls.Add(this.ageToBreedTextBox);
            this.Controls.Add(this.initialPredatorCountTextBox);
            this.Controls.Add(this.initialFishCountTextBox);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.evolutionStageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label evolutionStageLabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.TextBox initialFishCountTextBox;
        private System.Windows.Forms.TextBox initialPredatorCountTextBox;
        private System.Windows.Forms.TextBox ageToBreedTextBox;
        private System.Windows.Forms.TextBox breedIntervalTextBox;
        private System.Windows.Forms.TextBox predatorAgeToBreedTextBox;
        private System.Windows.Forms.TextBox predatorBreedIntervalTextBox;
        private System.Windows.Forms.TextBox predatorStarvationIntervalTextBox;
        private System.Windows.Forms.TextBox sizeX_TextBox;
        private System.Windows.Forms.TextBox sizeY_TextBox;
        private System.Windows.Forms.TextBox pixelSizeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timerIntervalTextBox;
        private System.Windows.Forms.Label label11;
    }
}

