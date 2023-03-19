// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiOrigin")]
    public enum Origin : int
    {
        [Obsolete("Deprecated in favour of \"Set\"")]
        [NativeName("Name", "aiOrigin_SET")]
        OriginSet = 0x0,
        [Obsolete("Deprecated in favour of \"Cur\"")]
        [NativeName("Name", "aiOrigin_CUR")]
        OriginCur = 0x1,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "aiOrigin_END")]
        OriginEnd = 0x2,
        [NativeName("Name", "aiOrigin_SET")]
        Set = 0x0,
        [NativeName("Name", "aiOrigin_CUR")]
        Cur = 0x1,
        [NativeName("Name", "aiOrigin_END")]
        End = 0x2,
    }
}
