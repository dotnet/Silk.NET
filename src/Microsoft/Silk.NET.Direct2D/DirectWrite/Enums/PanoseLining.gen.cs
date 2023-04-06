// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_LINING")]
    public enum PanoseLining : int
    {
        [NativeName("Name", "DWRITE_PANOSE_LINING_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_LINING_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_LINING_NONE")]
        None = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_LINING_INLINE")]
        Inline = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_LINING_OUTLINE")]
        Outline = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_LINING_ENGRAVED")]
        Engraved = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_LINING_SHADOW")]
        Shadow = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_LINING_RELIEF")]
        Relief = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_LINING_BACKDROP")]
        Backdrop = 0x8,
    }
}
