using NAudio.Wave;
using System;
using System.Windows.Forms;
using File = System.IO.File;

namespace MusicPlayer {
    internal class AudioEngine {
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;

        // Events
        public static event Action<TimeSpan, TimeSpan> PositionChanged;
        public static event Action PlaybackStopped;
        public static event Action PlaybackStarted;

        public static bool IsPlaying => outputDevice?.PlaybackState == PlaybackState.Playing;

        // Named handler to prevent loops
        private static void OnDevicePlaybackStopped(object sender, StoppedEventArgs e) {
            PlaybackStopped?.Invoke();
        }

        // --- CENTRALIZED UI HANDLER ---
        public static void RegisterControls(Form host, TrackBar seekBar, Label timeLabel, Button playPauseBtn, Action onSongFinished) {
            // Handle Position Updates (Timer)
            PositionChanged += (current, total) => {
                if (host.IsDisposed) return;
                host.BeginInvoke((MethodInvoker)delegate {
                    // Only update if user is NOT dragging (checked via Tag)
                    if (seekBar.Tag?.ToString() != "dragging") {
                        seekBar.Maximum = (int)total.TotalSeconds;
                        seekBar.Value = Math.Min(seekBar.Maximum, (int)current.TotalSeconds);
                        timeLabel.Text = $"{current:mm\\:ss} / {total:mm\\:ss}";
                    }
                });
            };

            // Handle Start (Reset UI)
            PlaybackStarted += () => {
                if (host.IsDisposed) return;
                host.BeginInvoke((MethodInvoker)delegate {
                    playPauseBtn.Text = "Pause";
                    // Only reset if it's a new song, not just unpausing
                    // (Optional logic, but safe to keep simple)
                });
            };

            // Handle Stop (Loop/Next Logic)
            PlaybackStopped += () => {
                if (host.IsDisposed) return;
                host.BeginInvoke((MethodInvoker)delegate {
                    playPauseBtn.Text = "Play";

                    // Trigger the "What happens next?" logic passed from MainForm
                    onSongFinished?.Invoke();
                });
            };
        }
        // -----------------------------------

        public static void PlaySong(string filePath) {
            // Unsubscribe old event to prevent double-firing
            if (outputDevice != null) outputDevice.PlaybackStopped -= OnDevicePlaybackStopped;

            Stop();

            if (!File.Exists(filePath)) return;

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

            // Subscribe new event
            outputDevice.PlaybackStopped += OnDevicePlaybackStopped;

            outputDevice.Play();

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

        public static void SetVolume(float volume) {
            if (audioFile != null) audioFile.Volume = volume;
        }

        public static void Seek(double seconds) {
            if (audioFile != null)
                audioFile.Position = (long)(seconds * audioFile.WaveFormat.SampleRate * audioFile.WaveFormat.BlockAlign);
        }

        public static TimeSpan CurrentTime => audioFile?.CurrentTime ?? TimeSpan.Zero;
        public static TimeSpan TotalTime => audioFile?.TotalTime ?? TimeSpan.Zero;

        private static Timer timer;
        private static void StartTimer() {
            timer?.Stop();
            timer = new Timer { Interval = 500 };
            timer.Tick += (s, e) => PositionChanged?.Invoke(CurrentTime, TotalTime);
            timer.Start();
        }
    }
}