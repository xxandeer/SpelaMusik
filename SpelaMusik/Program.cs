using NAudio.Vorbis;
using NAudio.Wave;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        string oggFilePath = @"99_bottles_of_beer.ogg";

        using (var reader = new VorbisWaveReader(oggFilePath))
        {
            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(reader);
                waveOut.Play();

                while (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        WriteLine("Tryck på valfri knapp för att avsluta");
        ReadKey();
    }
}
