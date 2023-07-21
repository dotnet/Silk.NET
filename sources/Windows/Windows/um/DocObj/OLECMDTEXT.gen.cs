// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT"]/*' />
public unsafe partial struct OLECMDTEXT
{
    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cmdtextf"]/*' />
    [NativeTypeName("DWORD")]
    public uint cmdtextf;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cwActual"]/*' />
    [NativeTypeName("ULONG")]
    public uint cwActual;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cwBuf"]/*' />
    [NativeTypeName("ULONG")]
    public uint cwBuf;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.rgwz"]/*' />
    [NativeTypeName("wchar_t[1]")]
    public fixed ushort rgwz[1];
}
