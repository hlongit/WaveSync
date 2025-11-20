using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = System.IO.File;

namespace MusicPlayer {
    internal class AudioEngine {
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;

        public static event Action<TimeSpan, TimeSpan> PositionChanged; // current / total
        public static event Action PlaybackStopped;
        public static event Action PlaybackStarted;

        public static bool IsPlaying => outputDevice?.PlaybackState == PlaybackState.Playing;

        public static void PlaySong(string filePath) {
            Stop(); // stop current

            if (!File.Exists(filePath)) return;

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
            outputDevice.PlaybackStopped += (s, e) => PlaybackStopped?.Invoke();

            PlaybackStarted?.Invoke();
            StartTimer();
        }

        public static void Pause() => outputDevice?.Pause();
        public static void Resume() => outputDevice?.Play();
        public static void Stop() {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
        }

        public static void SetVolume(float volume) // 0.0f to 1.0f
        {
            if (audioFile != null) audioFile.Volume = volume;
        }

        public static void Seek(double seconds) {
            if (audioFile != null) audioFile.Position = (long)(seconds * audioFile.WaveFormat.SampleRate * audioFile.WaveFormat.BlockAlign);
        }

        public static TimeSpan CurrentTime => audioFile?.CurrentTime ?? TimeSpan.Zero;
        public static TimeSpan TotalTime => audioFile?.TotalTime ?? TimeSpan.Zero;

        private static System.Windows.Forms.Timer timer;
        private static void StartTimer() {
            timer?.Stop();
            timer = new System.Windows.Forms.Timer { Interval = 500 };
            timer.Tick += (s, e) => PositionChanged?.Invoke(CurrentTime, TotalTime);
            timer.Start();
        }
    }
}
