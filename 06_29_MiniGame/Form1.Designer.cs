namespace _06_29_MiniGame
{
    partial class FormTitle
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            labelGameover = new Label();
            labelTime = new Label();
            buttonStart = new Button();
            labelRecord = new Label();
            buttonTitle = new Button();
            labelScore = new Label();
            labelCopyright = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("游明朝", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(292, 75);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(196, 56);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "よけとる";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("游明朝", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(251, 169);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(294, 56);
            labelGameover.TabIndex = 7;
            labelGameover.Text = "GAME OVER";
            labelGameover.TextAlign = ContentAlignment.MiddleCenter;
            labelGameover.Click += labelGameover_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("游明朝", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(12, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(158, 28);
            labelTime.TabIndex = 8;
            labelTime.Text = "残り時間：200";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            labelTime.Click += labelTime_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(330, 299);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(120, 40);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new Font("游明朝", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelRecord.Location = new Point(318, 250);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(144, 28);
            labelRecord.TabIndex = 10;
            labelRecord.Text = "最高分：なし";
            labelRecord.TextAlign = ContentAlignment.MiddleCenter;
            labelRecord.Click += labelRecord_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(330, 299);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(120, 40);
            buttonTitle.TabIndex = 11;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("游明朝", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(324, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(126, 28);
            labelScore.TabIndex = 12;
            labelScore.Text = "得点：0000";
            labelScore.TextAlign = ContentAlignment.MiddleCenter;
            labelScore.Click += labelScore_Click;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("游明朝", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopyright.Location = new Point(302, 420);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(176, 21);
            labelCopyright.TabIndex = 13;
            labelCopyright.Text = "(C) 2023 テイ　キタク";
            labelCopyright.TextAlign = ContentAlignment.MiddleCenter;
            labelCopyright.Click += labelCopyright_Click;
            // 
            // FormTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCopyright);
            Controls.Add(labelScore);
            Controls.Add(buttonTitle);
            Controls.Add(labelRecord);
            Controls.Add(buttonStart);
            Controls.Add(labelTime);
            Controls.Add(labelGameover);
            Controls.Add(labelTitle);
            Name = "FormTitle";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label labelTitle;
        private Label labelGameover;
        private Label labelTime;
        private Button buttonStart;
        private Label labelRecord;
        private Button buttonTitle;
        private Label labelScore;
        private Label labelCopyright;
    }
}