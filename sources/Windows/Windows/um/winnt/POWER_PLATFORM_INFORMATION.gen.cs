// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_PLATFORM_INFORMATION.xml' path='doc/member[@name="POWER_PLATFORM_INFORMATION"]/*' />
public partial struct POWER_PLATFORM_INFORMATION
{
    /// <include file='POWER_PLATFORM_INFORMATION.xml' path='doc/member[@name="POWER_PLATFORM_INFORMATION.AoAc"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte AoAc;
}
