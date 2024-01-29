using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MusicPlayer music_player = new MusicPlayer();
                music_player.Input();
                music_player.PlaySound();
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
