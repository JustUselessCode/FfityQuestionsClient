using Grpc.Net.Client;
using QuestionService;

namespace FiftyQuestionsClient.Entities
{
    internal class ClientFactory
    {
        public static QuestionHandler.QuestionHandlerClient CreateClient(Uri Address)
        {
            return new QuestionHandler.QuestionHandlerClient(GrpcChannel.ForAddress(Address));
        }
        public static QuestionHandler.QuestionHandlerClient CreateClient(string Address)
        {
            return new QuestionHandler.QuestionHandlerClient(GrpcChannel.ForAddress(Address));
        }

    }
}
