using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BadNews.Hubs
{
    public class CommentsHub : Hub
    {
        public const string Path = "/commentsHub";
        public const string ReceiveCommentMethod = "ReceiveComment";

        public async Task SendComment(string user, string message)
        {
            await Clients.All.SendAsync(ReceiveCommentMethod, user, message).ConfigureAwait(false);
        }
    }
}
