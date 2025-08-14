// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagLOCKTYPE")]
    public enum LockType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "LOCK_WRITE")]
        LockWrite = 0x1,
        [Obsolete("Deprecated in favour of \"Exclusive\"")]
        [NativeName("Name", "LOCK_EXCLUSIVE")]
        LockExclusive = 0x2,
        [Obsolete("Deprecated in favour of \"Onlyonce\"")]
        [NativeName("Name", "LOCK_ONLYONCE")]
        LockOnlyonce = 0x4,
        [NativeName("Name", "LOCK_WRITE")]
        Write = 0x1,
        [NativeName("Name", "LOCK_EXCLUSIVE")]
        Exclusive = 0x2,
        [NativeName("Name", "LOCK_ONLYONCE")]
        Onlyonce = 0x4,
    }
}
