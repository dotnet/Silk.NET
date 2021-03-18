// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
