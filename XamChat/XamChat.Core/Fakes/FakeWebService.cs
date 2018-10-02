using System;
using System.Threading.Tasks;

namespace XamChat.Core
{
    public class FakeWebService : IWebService
    {
        public int SleepDuration { get; set; }

        public FakeWebService()
        {
            SleepDuration = 1000;
        }

        private Task Sleep()
        {
#if NUNIT
            return Task.FromResult(true);
#else
            return Task.Delay(SleepDuration);
#endif
        }

        public async Task<User> Login(string username, string password)
        {
            await Sleep();

            return new User { Id = 1, Username = username };
        }

        public async Task<User> Register(User user)
        {
            await Sleep();

            return user;
        }

        public async Task<User[]> GetFriends(int userId)
        {
            await Sleep();

            return new[]
            {
                new User { Id = 2, Username = "bobama" },
                new User { Id = 3, Username = "bobloblaw" },
                new User { Id = 4, Username = "gmichael" },
                new User { Id = 5, Username = "scooper" },
            };
        }

        public async Task<User> AddFriend(int userId, string username)
        {
            await Sleep();

            return new User { Id = 6, Username = username };
        }

        public async Task<Conversation[]> GetConversations(int userId)
        {
            await Sleep();

            return new[]
            {
                new Conversation { Id = 1, UserId = 2, Username = "bobama" },
                new Conversation { Id = 2, UserId = 3, Username = "bobloblaw" },
                new Conversation { Id = 3, UserId = 4, Username = "gmichael" },
            };
        }

        public async Task<Message[]> GetMessages(int conversationId)
        {
            await Sleep();

            return new[]
            {
                new Message { Id = 1, ConversationId = conversationId, UserId = 2, Username = "bobama", Text = "Hey" },
                new Message { Id = 2, ConversationId = conversationId, UserId = 1, Username = "testuser", Text = "What's up?" },
                new Message { Id = 1, ConversationId = conversationId, UserId = 2, Username = "bobama", Text = "Have you seen that new movie?" },
                new Message { Id = 2, ConversationId = conversationId, UserId = 1, Username = "testuser", Text = "It's great!" },
            };
        }

        public async Task<Message> SendMessage(Message message)
        {
            await Sleep();

            return message;
        }
    }
}

