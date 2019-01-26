﻿using System.Collections.Generic;
using Lockstep.Core.Data;
using Lockstep.Core.Interfaces;

namespace Lockstep.Client
{                
    public class FrameBuffer : IFrameBuffer
    {                                   
        private readonly Dictionary<uint, Frame> _frames = new Dictionary<uint, Frame>(); 

        public uint Count { get; private set; }

        public uint ItemIndex { get; private set; }

        public uint Remaining => Count - ItemIndex;

        public void Insert(Frame item)
        {
            lock (_frames)
            {
                _frames[Count++] = item;
            }              
        }

        public Frame GetNext()
        {
            Frame nextFrame;
            lock (_frames)
            {
                nextFrame = _frames[ItemIndex++];
            }
            return nextFrame;
        }
    }
}
