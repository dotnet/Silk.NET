// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYSTEM_POOL_ZEROING_INFORMATION.xml' path='doc/member[@name="SYSTEM_POOL_ZEROING_INFORMATION"]/*' />
public partial struct SYSTEM_POOL_ZEROING_INFORMATION
{
    /// <include file='SYSTEM_POOL_ZEROING_INFORMATION.xml' path='doc/member[@name="SYSTEM_POOL_ZEROING_INFORMATION.PoolZeroingSupportPresent"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte PoolZeroingSupportPresent;
}
