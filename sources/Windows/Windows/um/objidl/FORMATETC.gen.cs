// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC"]/*' />
public unsafe partial struct FORMATETC
{
    /// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC.cfFormat"]/*' />
    [NativeTypeName("CLIPFORMAT")]
    public ushort cfFormat;

    /// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC.ptd"]/*' />
    public DVTARGETDEVICE* ptd;

    /// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC.dwAspect"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAspect;

    /// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC.lindex"]/*' />
    [NativeTypeName("LONG")]
    public int lindex;

    /// <include file='FORMATETC.xml' path='doc/member[@name="FORMATETC.tymed"]/*' />
    [NativeTypeName("DWORD")]
    public uint tymed;
}
