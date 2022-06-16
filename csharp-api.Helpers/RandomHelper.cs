namespace csharp_api.Helpers
{
    public static class RandomHelper
    {
        public static string GetRandomString(int length)
        {
            // Declare all characters
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            // Pick characers randomly
            string str = "";
            Random random = new();
            for (var i = 0; i < length; i++)
            {
                str += chars[(int) Math.Floor((double) random.Next(0, chars.Length -1))];
            }
            return str;
        }


        public static int GetRandomInt(int min, int max)
        {
            return new Random().Next(min, max) + min;
        }

    }
}
