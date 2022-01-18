namespace Courses
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.DirectionName = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btfromColor = new System.Windows.Forms.Button();
            this.bttoColor = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLife = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbParticles = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticles)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(464, 426);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(482, 78);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(169, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirection.Location = new System.Drawing.Point(654, 67);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 17);
            this.lblDirection.TabIndex = 2;
            // 
            // DirectionName
            // 
            this.DirectionName.AutoSize = true;
            this.DirectionName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectionName.Location = new System.Drawing.Point(482, 58);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(84, 17);
            this.DirectionName.TabIndex = 3;
            this.DirectionName.Text = "Направление";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(482, 138);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(169, 45);
            this.tbSpreading.TabIndex = 5;
            this.tbSpreading.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(482, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Разброс";
            // 
            // btfromColor
            // 
            this.btfromColor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btfromColor.Location = new System.Drawing.Point(513, 339);
            this.btfromColor.Name = "btfromColor";
            this.btfromColor.Size = new System.Drawing.Size(141, 45);
            this.btfromColor.TabIndex = 7;
            this.btfromColor.Text = "Начальный цвет";
            this.btfromColor.UseVisualStyleBackColor = true;
            this.btfromColor.Click += new System.EventHandler(this.btfromColor_Click);
            // 
            // bttoColor
            // 
            this.bttoColor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttoColor.Location = new System.Drawing.Point(513, 390);
            this.bttoColor.Name = "bttoColor";
            this.bttoColor.Size = new System.Drawing.Size(141, 48);
            this.bttoColor.TabIndex = 8;
            this.bttoColor.Text = "Конечный цвет";
            this.bttoColor.UseVisualStyleBackColor = true;
            this.bttoColor.Click += new System.EventHandler(this.bttoColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(560, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Меню";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(482, 189);
            this.tbSpeed.Maximum = 50;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(169, 45);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(482, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Скорость";
            // 
            // tbLife
            // 
            this.tbLife.Location = new System.Drawing.Point(482, 240);
            this.tbLife.Maximum = 200;
            this.tbLife.Minimum = 20;
            this.tbLife.Name = "tbLife";
            this.tbLife.Size = new System.Drawing.Size(169, 45);
            this.tbLife.TabIndex = 13;
            this.tbLife.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbLife.Value = 20;
            this.tbLife.Scroll += new System.EventHandler(this.tbLife_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(482, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Жизни";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(503, 24);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 15);
            this.lbCount.TabIndex = 15;
            // 
            // tbParticles
            // 
            this.tbParticles.Location = new System.Drawing.Point(482, 291);
            this.tbParticles.Maximum = 100;
            this.tbParticles.Minimum = 1;
            this.tbParticles.Name = "tbParticles";
            this.tbParticles.Size = new System.Drawing.Size(169, 45);
            this.tbParticles.TabIndex = 16;
            this.tbParticles.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbParticles.Value = 1;
            this.tbParticles.Scroll += new System.EventHandler(this.tbParticles_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(482, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Количество частиц в тик";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbParticles);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLife);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttoColor);
            this.Controls.Add(this.btfromColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.DirectionName);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label DirectionName;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btfromColor;
        private System.Windows.Forms.Button bttoColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbLife;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TrackBar tbParticles;
        private System.Windows.Forms.Label label5;
    }
}
