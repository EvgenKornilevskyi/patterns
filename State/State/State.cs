namespace DesignPatterns.State
{
    public abstract class State
    {
        protected MediaPlayer _mediaPlayer;
        public void SetMediaPlayer(MediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }
        public abstract void GetCurrentTrack();
        public abstract void SetCurrentTrack();
        public abstract void GetTracks();
        public abstract void Play();
        public abstract void Stop();
        public abstract void VolumeUp();
        public abstract void VolumenDown();
    }
}
