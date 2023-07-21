// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_BEST_IF.xml' path='doc/member[@name="MIB_BEST_IF"]/*' />
public partial struct MIB_BEST_IF
{
    /// <include file='MIB_BEST_IF.xml' path='doc/member[@name="MIB_BEST_IF.dwDestAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDestAddr;

    /// <include file='MIB_BEST_IF.xml' path='doc/member[@name="MIB_BEST_IF.dwIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
}
