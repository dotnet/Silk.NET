// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_IFNUMBER.xml' path='doc/member[@name="MIB_IFNUMBER"]/*' />
public partial struct MIB_IFNUMBER
{
    /// <include file='MIB_IFNUMBER.xml' path='doc/member[@name="MIB_IFNUMBER.dwValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwValue;
}
