// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DSAMPLER_TEXTURE_TYPE")]
    public enum SamplerTextureType : int
    {
        [NativeName("Name", "D3DSTT_UNKNOWN")]
        SttUnknown = 0x0,
        [NativeName("Name", "D3DSTT_2D")]
        Stt2D = 0x10000000,
        [NativeName("Name", "D3DSTT_CUBE")]
        SttCube = 0x18000000,
        [NativeName("Name", "D3DSTT_VOLUME")]
        SttVolume = 0x20000000,
        [NativeName("Name", "D3DSTT_FORCE_DWORD")]
        SttForceDword = 0x7FFFFFFF,
    }
}
