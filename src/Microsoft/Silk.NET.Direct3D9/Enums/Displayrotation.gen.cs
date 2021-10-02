// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "D3DDISPLAYROTATION")]
    public enum Displayrotation : int
    {
        [NativeName("Name", "D3DDISPLAYROTATION_IDENTITY")]
        DisplayrotationIdentity = 0x1,
        [NativeName("Name", "D3DDISPLAYROTATION_90")]
        Displayrotation90 = 0x2,
        [NativeName("Name", "D3DDISPLAYROTATION_180")]
        Displayrotation180 = 0x3,
        [NativeName("Name", "D3DDISPLAYROTATION_270")]
        Displayrotation270 = 0x4,
    }
}
