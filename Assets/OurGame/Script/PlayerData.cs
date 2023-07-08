namespace OurGame.Scripts
{
    public static class PlayerData
    {
        public static int Points { get; set; }
        public static int lives = 3;

        public static void Reset()
        {
            Points = 0;
            lives = 3;
        }
    }
}