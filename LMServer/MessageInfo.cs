namespace LMServer
{
    public class MessageInfo
    {
        private string message = string.Empty;
        private string username = string.Empty;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

    }
}
