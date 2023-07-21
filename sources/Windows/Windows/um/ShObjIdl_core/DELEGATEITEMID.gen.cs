// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DELEGATEITEMID
{
    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.cbSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort cbSize;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.wOuter"]/*' />
    [NativeTypeName("WORD")]
    public ushort wOuter;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.cbInner"]/*' />
    [NativeTypeName("WORD")]
    public ushort cbInner;

    /// <include file='DELEGATEITEMID.xml' path='doc/member[@name="DELEGATEITEMID.rgb"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte rgb[1];
}
