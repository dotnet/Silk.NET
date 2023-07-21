// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.COINITBASE;

namespace Silk.NET.Windows;

/// <include file='COINIT.xml' path='doc/member[@name="COINIT"]/*' />
public enum COINIT
{
    /// <include file='COINIT.xml' path='doc/member[@name="COINIT.COINIT_APARTMENTTHREADED"]/*' />
    COINIT_APARTMENTTHREADED = 0x2,

    /// <include file='COINIT.xml' path='doc/member[@name="COINIT.COINIT_MULTITHREADED"]/*' />
    COINIT_MULTITHREADED = COINITBASE_MULTITHREADED,

    /// <include file='COINIT.xml' path='doc/member[@name="COINIT.COINIT_DISABLE_OLE1DDE"]/*' />
    COINIT_DISABLE_OLE1DDE = 0x4,

    /// <include file='COINIT.xml' path='doc/member[@name="COINIT.COINIT_SPEED_OVER_MEMORY"]/*' />
    COINIT_SPEED_OVER_MEMORY = 0x8,
}
