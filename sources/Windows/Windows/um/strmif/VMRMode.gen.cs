// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VMRMode.xml' path='doc/member[@name="VMRMode"]/*' />
public enum VMRMode
{
    /// <include file='VMRMode.xml' path='doc/member[@name="VMRMode.VMRMode_Windowed"]/*' />
    VMRMode_Windowed = 0x1,

    /// <include file='VMRMode.xml' path='doc/member[@name="VMRMode.VMRMode_Windowless"]/*' />
    VMRMode_Windowless = 0x2,

    /// <include file='VMRMode.xml' path='doc/member[@name="VMRMode.VMRMode_Renderless"]/*' />
    VMRMode_Renderless = 0x4,

    /// <include file='VMRMode.xml' path='doc/member[@name="VMRMode.VMRMode_Mask"]/*' />
    VMRMode_Mask = 0x7,
}
