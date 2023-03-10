// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiBlendMode")]
    public enum BlendMode : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "aiBlendMode_Default")]
        BlendModeDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Additive\"")]
        [NativeName("Name", "aiBlendMode_Additive")]
        BlendModeAdditive = 0x1,
        [NativeName("Name", "aiBlendMode_Default")]
        Default = 0x0,
        [NativeName("Name", "aiBlendMode_Additive")]
        Additive = 0x1,
    }
}
