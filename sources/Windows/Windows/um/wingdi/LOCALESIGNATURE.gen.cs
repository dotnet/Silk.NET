// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE"]/*' />
public unsafe partial struct LOCALESIGNATURE
{
    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsUsb"]/*' />
    [NativeTypeName("DWORD[4]")]
    public fixed uint lsUsb[4];

    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsCsbDefault"]/*' />
    [NativeTypeName("DWORD[2]")]
    public fixed uint lsCsbDefault[2];

    /// <include file='LOCALESIGNATURE.xml' path='doc/member[@name="LOCALESIGNATURE.lsCsbSupported"]/*' />
    [NativeTypeName("DWORD[2]")]
    public fixed uint lsCsbSupported[2];
}
