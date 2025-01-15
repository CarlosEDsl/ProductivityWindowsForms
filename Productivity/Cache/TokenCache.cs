namespace Productivity.Cache
{
    internal class TokenCache
    {
        private static string token;
        private static int userId;

        public static string GetToken()
        {
            return token;
        }

        public static void SetToken(string newToken)
        {
            token = newToken.Replace("Bearer ", string.Empty);
        }

        public static int GetUserId()
        {
            return userId;
        }

        public static void SetUserId(int id)
        {
            userId = id;
        }

        public static void ClearToken()
        {
            token = null;
        }

    }
}
