// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PUBLICKEYSTRUC.xml' path='doc/member[@name="PUBLICKEYSTRUC"]/*' />
public partial struct PUBLICKEYSTRUC
{
    /// <include file='PUBLICKEYSTRUC.xml' path='doc/member[@name="PUBLICKEYSTRUC.bType"]/*' />
    public byte bType;

    /// <include file='PUBLICKEYSTRUC.xml' path='doc/member[@name="PUBLICKEYSTRUC.bVersion"]/*' />
    public byte bVersion;

    /// <include file='PUBLICKEYSTRUC.xml' path='doc/member[@name="PUBLICKEYSTRUC.reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort reserved;

    /// <include file='PUBLICKEYSTRUC.xml' path='doc/member[@name="PUBLICKEYSTRUC.aiKeyAlg"]/*' />
    [NativeTypeName("ALG_ID")]
    public uint aiKeyAlg;
}
