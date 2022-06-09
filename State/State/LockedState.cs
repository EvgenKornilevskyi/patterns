using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class LockedState : State
    {
        public override void GetCurrentTrack()
        {
            throw new NotImplementedException();
        }

        public override void GetTracks()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void SetCurrentTrack()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void VolumenDown()
        {
            throw new NotImplementedException();
        }

        public override void VolumeUp()
        {
            throw new NotImplementedException();
        }
    }
}
