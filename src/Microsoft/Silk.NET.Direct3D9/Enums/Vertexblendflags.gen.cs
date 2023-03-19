// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DVERTEXBLENDFLAGS")]
    public enum Vertexblendflags : int
    {
        [NativeName("Name", "D3DVBF_DISABLE")]
        VbfDisable = 0x0,
        [NativeName("Name", "D3DVBF_1WEIGHTS")]
        Vbf1Weights = 0x1,
        [NativeName("Name", "D3DVBF_2WEIGHTS")]
        Vbf2Weights = 0x2,
        [NativeName("Name", "D3DVBF_3WEIGHTS")]
        Vbf3Weights = 0x3,
        [NativeName("Name", "D3DVBF_TWEENING")]
        VbfTweening = 0xFF,
        [NativeName("Name", "D3DVBF_0WEIGHTS")]
        Vbf0Weights = 0x100,
        [NativeName("Name", "D3DVBF_FORCE_DWORD")]
        VbfForceDword = 0x7FFFFFFF,
    }
}
