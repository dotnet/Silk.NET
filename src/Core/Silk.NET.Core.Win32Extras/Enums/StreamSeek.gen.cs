// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSTREAM_SEEK")]
    public enum StreamSeek : int
    {
        [Obsolete("Deprecated in favour of \"Set\"")]
        [NativeName("Name", "STREAM_SEEK_SET")]
        StreamSeekSet = 0x0,
        [Obsolete("Deprecated in favour of \"Cur\"")]
        [NativeName("Name", "STREAM_SEEK_CUR")]
        StreamSeekCur = 0x1,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "STREAM_SEEK_END")]
        StreamSeekEnd = 0x2,
        [NativeName("Name", "STREAM_SEEK_SET")]
        Set = 0x0,
        [NativeName("Name", "STREAM_SEEK_CUR")]
        Cur = 0x1,
        [NativeName("Name", "STREAM_SEEK_END")]
        End = 0x2,
    }
}
