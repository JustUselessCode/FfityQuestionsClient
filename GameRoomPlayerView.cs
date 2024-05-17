using QuestionService;
using FiftyQuestionsClient.Entities;

namespace FiftyQuestionsClient;

public partial class GameRoomPlayerView : Form
{
    private QuestionHandler.QuestionHandlerClient CLIENT { get; set; }

    public GameRoomPlayerView()
    {
        InitializeComponent();
        CLIENT = ClientFactory.CreateClient(Endpoints.DevEndpointUnsecure);
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private async void LoadAndDisplayCurrentQuestion()
    {
        var question = "";
    }

    private async void Buzzer_Click(object sender, EventArgs e)
    {
        //var Client = ClientFactory.CreateClient(new Uri(Endpoints.DevEndpointUnsecure));
        var Response = await CLIENT.BuzzerAsync(new BuzzerRequest
        {
            PlayerID = MainMenuForm.CurrentPlayer.Id.ToString(),
            PlayerName = MainMenuForm.CurrentPlayer.Name,
            RoomID = MainMenuForm.CurrentRoomId
        });

        if (Response is not null)
        {
            QuestionReply.Text = Response.PlayerName;
            QuestionReply.BackColor = Response.SuccessStatus ? Color.LightGreen : Color.Red;
            QuestionReply.SelectAll();
            QuestionReply.SelectionAlignment = HorizontalAlignment.Center;
        }
    }

    private void Form2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space)
        {
            Buzzer_Click(sender, e);
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private async void ClientNextQuestionButton_Click(object sender, EventArgs e)
    {
        var Response = await CLIENT.AskForCurrentQuestionAsync(new());

        if (Response is not null)
        {
            QuestionLabel.Text = Response.Question;
        }

    }
}
