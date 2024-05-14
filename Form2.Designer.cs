namespace FiftyQuestionsClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            QuestionReply = new RichTextBox();
            Buzzer = new Button();
            QuestionLabel = new Label();
            SuspendLayout();
            // 
            // QuestionReply
            // 
            QuestionReply.Location = new Point(198, 88);
            QuestionReply.Name = "QuestionReply";
            QuestionReply.Size = new Size(404, 173);
            QuestionReply.TabIndex = 4;
            QuestionReply.Text = "";
            QuestionReply.TextChanged += TestAnswer1_TextChanged;
            // 
            // Buzzer
            // 
            Buzzer.Cursor = Cursors.Hand;
            Buzzer.Location = new Point(330, 301);
            Buzzer.Name = "Buzzer";
            Buzzer.Size = new Size(136, 61);
            Buzzer.TabIndex = 3;
            Buzzer.Text = "Buzzer!";
            Buzzer.UseVisualStyleBackColor = true;
            Buzzer.Click += Buzzer_Click;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Location = new Point(37, 22);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(61, 15);
            QuestionLabel.TabIndex = 5;
            QuestionLabel.Text = "Question: ";
            QuestionLabel.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(QuestionLabel);
            Controls.Add(QuestionReply);
            Controls.Add(Buzzer);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox QuestionReply;
        private Button Buzzer;
        private Label QuestionLabel;
    }
}