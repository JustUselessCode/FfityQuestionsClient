using FiftyQuestionsClient.Entities;
using Grpc.Net.Client;
using QuestionService;
using System.Text;

namespace FiftyQuestionsClient
{
    public partial class GameRoomPlayerView : Form
    {
        public GameRoomPlayerView()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void Buzzer_Click(object sender, EventArgs e)
        {
            var Client = ClientFactory.CreateClient(new Uri(Endpoints.DevEndpointUnsecure));
            var Response = await Client.BuzzerAsync(new BuzzerRequest
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
    }
}
