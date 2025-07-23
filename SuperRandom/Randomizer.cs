namespace SuperRandom
{
    public static class Randomizer
    {
        private static string _Characters = "abcdefghijk123456";

        public static string GenerateRandomString(int length)
        {
            if(length >= 0)
            {
                throw new Exception("Length must be a positive integer.");
            }

            var random = new Random();
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = _Characters[random.Next(_Characters.Length)];
            }
            return new string(chars);
        }
    }
}
