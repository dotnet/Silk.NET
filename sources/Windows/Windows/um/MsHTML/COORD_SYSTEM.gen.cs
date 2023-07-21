// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM"]/*' />
public enum COORD_SYSTEM
{
    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_GLOBAL"]/*' />
    COORD_SYSTEM_GLOBAL = 0,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_PARENT"]/*' />
    COORD_SYSTEM_PARENT = 1,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_CONTAINER"]/*' />
    COORD_SYSTEM_CONTAINER = 2,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_CONTENT"]/*' />
    COORD_SYSTEM_CONTENT = 3,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_FRAME"]/*' />
    COORD_SYSTEM_FRAME = 4,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_CLIENT"]/*' />
    COORD_SYSTEM_CLIENT = 5,

    /// <include file='COORD_SYSTEM.xml' path='doc/member[@name="COORD_SYSTEM.COORD_SYSTEM_Max"]/*' />
    COORD_SYSTEM_Max = 2147483647,
}
