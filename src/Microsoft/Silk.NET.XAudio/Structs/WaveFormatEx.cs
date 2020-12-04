// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.XAudio
{
    public struct WaveFormatEx
    {
        public ushort WFormatTag;
        public ushort NChannels;
        public uint NSamplesPerSec;
        public uint NAvgBytesPerSec;
        public ushort NBlockAlign;
        public ushort WBitsPerSample;
        public ushort CbSize;
    }
}
