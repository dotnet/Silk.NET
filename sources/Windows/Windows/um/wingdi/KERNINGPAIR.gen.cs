// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERNINGPAIR.xml' path='doc/member[@name="KERNINGPAIR"]/*' />
public partial struct KERNINGPAIR
{
    /// <include file='KERNINGPAIR.xml' path='doc/member[@name="KERNINGPAIR.wFirst"]/*' />
    [NativeTypeName("WORD")]
    public ushort wFirst;

    /// <include file='KERNINGPAIR.xml' path='doc/member[@name="KERNINGPAIR.wSecond"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSecond;

    /// <include file='KERNINGPAIR.xml' path='doc/member[@name="KERNINGPAIR.iKernAmount"]/*' />
    public int iKernAmount;
}
