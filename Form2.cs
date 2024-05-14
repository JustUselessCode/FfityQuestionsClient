using FiftyQuestionsClient.Entities;
using Grpc.Net.Client;
using QuestionService;
using System.Text;

namespace FiftyQuestionsClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TestAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Buzzer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            var req = new BuzzerRequest
            {
                PlayerID = p.Id.ToString(),
                PlayerName = p.Name,
                RoomID = gameRoomResponse.RoomID
            };
            
            var response = await client.BuzzerAsync(req);
            var responseStringBuilder = new StringBuilder();
            responseStringBuilder.AppendLine($"Name: {response.PlayerName}");
            responseStringBuilder.AppendLine($"Success: {response.SuccessStatus}");

            if (response.SuccessStatus is true)
            {
                QuestionReply.BackColor = Color.Green;
            }

            QuestionReply.Text = responseStringBuilder.ToString();
            */
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
