// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_FEATURE_LEVEL")]
    public enum FeatureLevel : int
    {
        [NativeName("Name", "D2D1_FEATURE_LEVEL_DEFAULT")]
        LevelDefault = 0x0,
        [NativeName("Name", "D2D1_FEATURE_LEVEL_9")]
        Level9 = 0x9100,
        [NativeName("Name", "D2D1_FEATURE_LEVEL_10")]
        Level10 = 0xA000,
        [NativeName("Name", "D2D1_FEATURE_LEVEL_FORCE_DWORD")]
        LevelForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
