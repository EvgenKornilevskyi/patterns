namespace DesignPatterns.State
{
    public class MediaPlayer
    {
        private State _state;

        public MediaPlayer(State state)
        {
            TransitionTo(state);
        }
        public void TransitionTo(State state)
        {
            Console.WriteLine($"MediaPlayer: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetMediaPlayer(this);
        }
        public void PlayMusic()
        {
            _state.Play();
        }
        public void StopMusic()
        {
            _state.Stop();
        }
    }
}
