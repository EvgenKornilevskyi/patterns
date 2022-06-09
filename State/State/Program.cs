namespace DesignPatterns.State
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mediaPlayer = new MediaPlayer(new LockedState());

            mediaPlayer.PlayMusic();

            mediaPlayer.StopMusic();
        }
    }
}