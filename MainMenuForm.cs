using QuestionService;
using FiftyQuestionsClient.Entities;
using System.Text;

namespace FiftyQuestionsClient;

internal partial class MainMenuForm : Form
{
    public static Player? CurrentPlayer { get; set; }
    public static int CurrentRoomId { get; set; }
    public MainMenuForm()
    {
        InitializeComponent();
        PlayerRoleSelection.DataSource = Enum.GetValues(typeof(PlayerRole));
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void PlayerRoleSelection_SelectedIndexChanged(object sender, EventArgs e)
    {
        PlayerRoleSelection.Text = PlayerRoleSelection.SelectedItem.ToString();
    }

    private async void JoinGameButton_Click(object sender, EventArgs e)
    {
        Player currentPlayer = new(NameInput.Text, (PlayerRole) PlayerRoleSelection.SelectedValue);
        CurrentPlayer = currentPlayer;
        var Client = ClientFactory.CreateClient(new Uri("http://localhost:6969"));

        var Response = await Client.AddParticipantAsync(new ParticipationRequest
        {
            PlayerID = Guid.NewGuid().ToString(),
            PlayerName = currentPlayer.Name,
            Role = currentPlayer._Role,
            RoomID = int.Parse(RoomNumberInputLabel.Text)
        });

        if (!Response.SuccesStatus)
        {
            //TODO: Implement ErrorHandling perhaps using a ErrorHandling Winforms Element
        }

        switch (currentPlayer._Role)
        {
            case PlayerRole.Player:
                var PlayerForm = new GameRoomPlayerView();
                PlayerForm.ShowDialog();
                break;

            case PlayerRole.GameMaster:
                var GameMasterForm = new GameRoomGameMasterView();
                GameMasterForm.Show();
                break;

            case PlayerRole.Spectator:
                throw new NotImplementedException("Spectator capability has not been implemented yet!");

            default:
                throw new NotSupportedException();
        }
    }

    private async void RequestRoomCreationButton_Click(object sender, EventArgs e)
    {
        var Client = ClientFactory.CreateClient(new Uri("http://localhost:6969"));
        var Response = await Client.CreateGameRoomAsync(new());

        if (Response is not null)
        {
            CreateRoomResponseLabel.BackColor = Color.LightGreen;
            CreateRoomResponseLabel.Text = Response.RoomID.ToString();
            CreateRoomResponseLabel.SelectAll();
            CreateRoomResponseLabel.SelectionFont = new Font("Segoe UI", 20);
            CreateRoomResponseLabel.SelectionAlignment = HorizontalAlignment.Center;
            CurrentRoomId = Response.RoomID;
        }

        else
        {
            CreateRoomResponseLabel.BackColor = Color.Red;
            CreateRoomResponseLabel.Text = "Error";
            CreateRoomResponseLabel.SelectAll();
            CreateRoomResponseLabel.SelectionFont = new Font("Segoe UI", 20);
            CreateRoomResponseLabel.SelectionAlignment = HorizontalAlignment.Center;
        }
    }

}