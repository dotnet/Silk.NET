// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFTOPOLOGY_HARDWARE_MODE.xml' path='doc/member[@name="MFTOPOLOGY_HARDWARE_MODE"]/*' />
public enum MFTOPOLOGY_HARDWARE_MODE
{
    /// <include file='MFTOPOLOGY_HARDWARE_MODE.xml' path='doc/member[@name="MFTOPOLOGY_HARDWARE_MODE.MFTOPOLOGY_HWMODE_SOFTWARE_ONLY"]/*' />
    MFTOPOLOGY_HWMODE_SOFTWARE_ONLY = 0,

    /// <include file='MFTOPOLOGY_HARDWARE_MODE.xml' path='doc/member[@name="MFTOPOLOGY_HARDWARE_MODE.MFTOPOLOGY_HWMODE_USE_HARDWARE"]/*' />
    MFTOPOLOGY_HWMODE_USE_HARDWARE = 1,

    /// <include file='MFTOPOLOGY_HARDWARE_MODE.xml' path='doc/member[@name="MFTOPOLOGY_HARDWARE_MODE.MFTOPOLOGY_HWMODE_USE_ONLY_HARDWARE"]/*' />
    MFTOPOLOGY_HWMODE_USE_ONLY_HARDWARE = 2,
}
