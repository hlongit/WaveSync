using NAudio.Wave; // NAudio library for audio playback
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // For Timer
using File = System.IO.File;

namespace MusicPlayer {
    internal class AudioEngine {
        private static WaveOutEvent outputDevice;     // Like your speakers/headphones
        private static AudioFileReader audioFile;     // Reads the .mp3 file


        // Events for position changes and playback state
        public static event Action<TimeSpan, TimeSpan> PositionChanged; // current / total
        public static event Action PlaybackStopped;
        public static event Action PlaybackStarted;

        // Playback state property
        public static bool IsPlaying => outputDevice?.PlaybackState == PlaybackState.Playing;

        public static void PlaySong(string filePath) {
            Stop(); // stop current

            if (!File.Exists(filePath)) return;

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();

            //When song ends, tell MainForm to update UI
            outputDevice.PlaybackStopped += (s, e) => PlaybackStopped?.Invoke();

            
            //Check PlaybackStarted event below.
            PlaybackStarted?.Invoke();
            StartTimer(); 
            //Also beware of timer.Start() because of name similarity, check detailed of StartTimer() method below
        }

        // Pause the music when Pause() is called, Resume when Resume() is called
        public static void Pause() => outputDevice?.Pause();
        public static void Resume() => outputDevice?.Play();

        // Stop and dispose resources when Stop() is called
        public static void Stop() {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
        }

        //Set from 0 to 1.0f
        public static void SetVolume(float volume) // 0.0f to 1.0f
        {
            if (audioFile != null) audioFile.Volume = volume;
        }

        //Used when user drags the seek bar, or when user clicks on a position in the seek bar
        //Change position of the audio file to the specified seconds

        public static void Seek(double seconds) {
            if (audioFile != null) audioFile.Position = (long)(seconds * audioFile.WaveFormat.SampleRate * audioFile.WaveFormat.BlockAlign);
        }

        // Properties to get current and total time
        public static TimeSpan CurrentTime => audioFile?.CurrentTime ?? TimeSpan.Zero;
        public static TimeSpan TotalTime => audioFile?.TotalTime ?? TimeSpan.Zero;

        // Timer to update position every 500ms
        private static System.Windows.Forms.Timer timer;
        private static void StartTimer() {
            timer?.Stop();
            timer = new System.Windows.Forms.Timer { Interval = 500 };
            //for every 500ms, raise PositionChanged event
            timer.Tick += (s, e) => PositionChanged?.Invoke(CurrentTime, TotalTime);
            timer.Start();
        }
    }
}
