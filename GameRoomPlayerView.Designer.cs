namespace FiftyQuestionsClient
{
    partial class GameRoomPlayerView
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
            ClientNextQuestionButton = new Button();
            SuspendLayout();
            // 
            // QuestionReply
            // 
            QuestionReply.Location = new Point(103, 107);
            QuestionReply.Name = "QuestionReply";
            QuestionReply.Size = new Size(381, 72);
            QuestionReply.TabIndex = 4;
            QuestionReply.Text = "";
            // 
            // Buzzer
            // 
            Buzzer.Cursor = Cursors.Hand;
            Buzzer.Location = new Point(227, 196);
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
            // ClientNextQuestionButton
            // 
            ClientNextQuestionButton.Cursor = Cursors.Hand;
            ClientNextQuestionButton.Location = new Point(46, 50);
            ClientNextQuestionButton.Name = "ClientNextQuestionButton";
            ClientNextQuestionButton.Size = new Size(38, 26);
            ClientNextQuestionButton.TabIndex = 6;
            ClientNextQuestionButton.Text = ">>";
            ClientNextQuestionButton.UseVisualStyleBackColor = true;
            ClientNextQuestionButton.Click += ClientNextQuestionButton_Click;
            // 
            // GameRoomPlayerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(589, 371);
            Controls.Add(ClientNextQuestionButton);
            Controls.Add(QuestionLabel);
            Controls.Add(QuestionReply);
            Controls.Add(Buzzer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameRoomPlayerView";
            Text = "6";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox QuestionReply;
        private Button Buzzer;
        private Label QuestionLabel;
        private Button ClientNextQuestionButton;
    }
}