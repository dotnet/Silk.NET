// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RemSNB.xml' path='doc/member[@name="RemSNB"]/*' />
public unsafe partial struct RemSNB
{
    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.ulCntStr"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCntStr;

    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.ulCntChar"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCntChar;

    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.rgString"]/*' />
    [NativeTypeName("OLECHAR[1]")]
    public fixed ushort rgString[1];
}
