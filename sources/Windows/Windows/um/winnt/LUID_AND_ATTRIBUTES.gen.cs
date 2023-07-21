// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LUID_AND_ATTRIBUTES.xml' path='doc/member[@name="LUID_AND_ATTRIBUTES"]/*' />
public partial struct LUID_AND_ATTRIBUTES
{
    /// <include file='LUID_AND_ATTRIBUTES.xml' path='doc/member[@name="LUID_AND_ATTRIBUTES.Luid"]/*' />
    public LUID Luid;

    /// <include file='LUID_AND_ATTRIBUTES.xml' path='doc/member[@name="LUID_AND_ATTRIBUTES.Attributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint Attributes;
}
