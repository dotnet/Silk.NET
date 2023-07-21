// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL"]/*' />
public unsafe partial struct SOCKADDR_DL
{
    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_family"]/*' />
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sdl_family;

    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_data"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public fixed byte sdl_data[8];

    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_zero"]/*' />
    [NativeTypeName("UCHAR[4]")]
    public fixed byte sdl_zero[4];
}
