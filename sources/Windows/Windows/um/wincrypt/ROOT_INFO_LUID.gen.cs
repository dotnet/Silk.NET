// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ROOT_INFO_LUID.xml' path='doc/member[@name="ROOT_INFO_LUID"]/*' />
public partial struct ROOT_INFO_LUID
{
    /// <include file='ROOT_INFO_LUID.xml' path='doc/member[@name="ROOT_INFO_LUID.LowPart"]/*' />
    [NativeTypeName("DWORD")]
    public uint LowPart;

    /// <include file='ROOT_INFO_LUID.xml' path='doc/member[@name="ROOT_INFO_LUID.HighPart"]/*' />
    [NativeTypeName("LONG")]
    public int HighPart;
}
