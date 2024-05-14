using Grpc.Core;
using System.Text;
using Grpc.Net.Client;
using QuestionService;
using FiftyQuestionsClient.Entities;

namespace FiftyQuestionsClient;

public partial class MainMenuForm : Form
{
    private static readonly string Address = "http://loclahost:6969";

    public MainMenuForm()
    {
        InitializeComponent();
        PlayerRoleSelection.DataSource = Enum.GetValues(typeof(PlayerRole));
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        PlayerRoleSelection.Text = PlayerRoleSelection.SelectedItem.ToString();
    }

    private void JoinGameButton_Click(object sender, EventArgs e)
    {
        Player Player = new(NameInput.Text, (PlayerRole)PlayerRoleSelection.SelectedValue);
        var Client = ClientFactory.CreateClient(Address);


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