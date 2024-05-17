using FiftyQuestionsClient.Entities;

namespace FiftyQuestionsClient;

public partial class GameRoomGameMasterView : Form
{
    public GameRoomGameMasterView()
    {
        InitializeComponent();
    }

    private async void ClearBuzzerButton_Click(object sender, EventArgs e)
    {
        var Client = ClientFactory.CreateClient(Endpoints.DevEndpointUnsecure);
        bool Response = false;
        int Retry = 3;

        while (Response == false)
        {
            var res = await Client.ClearBuzzersAsync(new());
            Response = res.Cleared;
        }

        if (Response == false)
        {
           //TODO: Handle Error during BuzzerClearing
        }

        else
        {

        }
    }
}
