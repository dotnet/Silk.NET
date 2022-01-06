// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiOrigin")]
    public enum Origin : int
    {
        [NativeName("Name", "aiOrigin_SET")]
        OriginSet = 0x0,
        [NativeName("Name", "aiOrigin_CUR")]
        OriginCur = 0x1,
        [NativeName("Name", "aiOrigin_END")]
        OriginEnd = 0x2,
    }
}
