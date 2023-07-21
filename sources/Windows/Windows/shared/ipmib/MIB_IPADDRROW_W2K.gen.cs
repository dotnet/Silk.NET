// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K"]/*' />
public partial struct MIB_IPADDRROW_W2K
{
    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.dwAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAddr;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.dwIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIndex;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.dwBCastAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBCastAddr;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.dwReasmSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReasmSize;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.unused1"]/*' />
    [NativeTypeName("unsigned short")]
    public ushort unused1;

    /// <include file='MIB_IPADDRROW_W2K.xml' path='doc/member[@name="MIB_IPADDRROW_W2K.unused2"]/*' />
    [NativeTypeName("unsigned short")]
    public ushort unused2;
}
