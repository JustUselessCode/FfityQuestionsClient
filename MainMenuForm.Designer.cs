namespace FiftyQuestionsClient
{
    partial class MainMenuForm
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
            NameInput = new TextBox();
            PlayerNameInputLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            RoomNumberInputLabel = new TextBox();
            PlayerRoleSelection = new ComboBox();
            JoinGameButton = new Button();
            tabControl1 = new TabControl();
            CreateRoom = new TabPage();
            label3 = new Label();
            CreateRoomResponseLabel = new RichTextBox();
            RequestRoomCreationButton = new Button();
            JoinRoom = new TabPage();
            tabControl1.SuspendLayout();
            CreateRoom.SuspendLayout();
            JoinRoom.SuspendLayout();
            SuspendLayout();
            // 
            // NameInput
            // 
            NameInput.Cursor = Cursors.IBeam;
            NameInput.Location = new Point(253, 74);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(100, 23);
            NameInput.TabIndex = 0;
            // 
            // PlayerNameInputLabel
            // 
            PlayerNameInputLabel.AutoSize = true;
            PlayerNameInputLabel.Location = new Point(152, 74);
            PlayerNameInputLabel.Name = "PlayerNameInputLabel";
            PlayerNameInputLabel.Size = new Size(74, 15);
            PlayerNameInputLabel.TabIndex = 1;
            PlayerNameInputLabel.Text = "Player Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 119);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Player Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 163);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "Room Nr";
            // 
            // RoomNumberInputLabel
            // 
            RoomNumberInputLabel.Cursor = Cursors.IBeam;
            RoomNumberInputLabel.Location = new Point(253, 160);
            RoomNumberInputLabel.Name = "RoomNumberInputLabel";
            RoomNumberInputLabel.Size = new Size(100, 23);
            RoomNumberInputLabel.TabIndex = 6;
            // 
            // PlayerRoleSelection
            // 
            PlayerRoleSelection.FormattingEnabled = true;
            PlayerRoleSelection.Location = new Point(253, 116);
            PlayerRoleSelection.Name = "PlayerRoleSelection";
            PlayerRoleSelection.Size = new Size(100, 23);
            PlayerRoleSelection.TabIndex = 8;
            PlayerRoleSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // JoinGameButton
            // 
            JoinGameButton.Cursor = Cursors.Hand;
            JoinGameButton.Location = new Point(219, 203);
            JoinGameButton.Name = "JoinGameButton";
            JoinGameButton.Size = new Size(64, 39);
            JoinGameButton.TabIndex = 9;
            JoinGameButton.Text = "Join";
            JoinGameButton.UseVisualStyleBackColor = true;
            JoinGameButton.Click += JoinGameButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CreateRoom);
            tabControl1.Controls.Add(JoinRoom);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(585, 367);
            tabControl1.TabIndex = 11;
            // 
            // CreateRoom
            // 
            CreateRoom.Controls.Add(label3);
            CreateRoom.Controls.Add(CreateRoomResponseLabel);
            CreateRoom.Controls.Add(RequestRoomCreationButton);
            CreateRoom.Location = new Point(4, 24);
            CreateRoom.Name = "CreateRoom";
            CreateRoom.Padding = new Padding(3);
            CreateRoom.Size = new Size(577, 339);
            CreateRoom.TabIndex = 0;
            CreateRoom.Text = "Create Room";
            CreateRoom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 87);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 13;
            label3.Text = "Room ID";
            // 
            // CreateRoomResponseLabel
            // 
            CreateRoomResponseLabel.Location = new Point(189, 105);
            CreateRoomResponseLabel.Name = "CreateRoomResponseLabel";
            CreateRoomResponseLabel.Size = new Size(164, 45);
            CreateRoomResponseLabel.TabIndex = 12;
            CreateRoomResponseLabel.Text = "";
            // 
            // RequestRoomCreationButton
            // 
            RequestRoomCreationButton.Cursor = Cursors.Hand;
            RequestRoomCreationButton.Location = new Point(209, 170);
            RequestRoomCreationButton.Name = "RequestRoomCreationButton";
            RequestRoomCreationButton.Size = new Size(123, 50);
            RequestRoomCreationButton.TabIndex = 11;
            RequestRoomCreationButton.Text = " Request Room";
            RequestRoomCreationButton.UseVisualStyleBackColor = true;
            RequestRoomCreationButton.Click += RequestRoomCreationButton_Click;
            // 
            // JoinRoom
            // 
            JoinRoom.Controls.Add(PlayerNameInputLabel);
            JoinRoom.Controls.Add(NameInput);
            JoinRoom.Controls.Add(JoinGameButton);
            JoinRoom.Controls.Add(label2);
            JoinRoom.Controls.Add(PlayerRoleSelection);
            JoinRoom.Controls.Add(RoomNumberInputLabel);
            JoinRoom.Controls.Add(label1);
            JoinRoom.Location = new Point(4, 24);
            JoinRoom.Name = "JoinRoom";
            JoinRoom.Padding = new Padding(3);
            JoinRoom.Size = new Size(577, 339);
            JoinRoom.TabIndex = 1;
            JoinRoom.Text = "Join Room";
            JoinRoom.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 370);
            Controls.Add(tabControl1);
            Name = "MainMenuForm";
            Text = "Main Menu";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            CreateRoom.ResumeLayout(false);
            CreateRoom.PerformLayout();
            JoinRoom.ResumeLayout(false);
            JoinRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameInput;
        private Label PlayerNameInputLabel;
        private Label label2;
        private Label label1;
        private TextBox RoomNumberInputLabel;
        private ComboBox PlayerRoleSelection;
        private Button JoinGameButton;
        private TabControl tabControl1;
        private TabPage CreateRoom;
        private Button RequestRoomCreationButton;
        private TabPage JoinRoom;
        private RichTextBox CreateRoomResponseLabel;
        private Label label3;
    }
}
