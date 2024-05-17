namespace FiftyQuestionsClient
{
    partial class GameRoomGameMasterView
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
            ClearBuzzerButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ClearBuzzerButton
            // 
            ClearBuzzerButton.Location = new Point(12, 282);
            ClearBuzzerButton.Name = "ClearBuzzerButton";
            ClearBuzzerButton.Size = new Size(94, 28);
            ClearBuzzerButton.TabIndex = 0;
            ClearBuzzerButton.Text = "Clear Buzzers";
            ClearBuzzerButton.UseVisualStyleBackColor = true;
            ClearBuzzerButton.Click += ClearBuzzerButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 316);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 1;
            button1.Text = "Next Question";
            button1.UseVisualStyleBackColor = true;
            // 
            // GameRoomGameMasterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 371);
            Controls.Add(button1);
            Controls.Add(ClearBuzzerButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameRoomGameMasterView";
            Text = "GameRoomGameMasterView";
            ResumeLayout(false);
        }

        #endregion

        private Button ClearBuzzerButton;
        private Button button1;
    }
}