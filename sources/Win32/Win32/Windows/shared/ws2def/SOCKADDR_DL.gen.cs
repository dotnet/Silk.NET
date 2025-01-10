// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKADDR_DL
{
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sdl_family;

    [NativeTypeName("UCHAR[8]")]
    public _sdl_data_e__FixedBuffer sdl_data;

    [NativeTypeName("UCHAR[4]")]
    public _sdl_zero_e__FixedBuffer sdl_zero;

    [InlineArray(8)]
    public partial struct _sdl_data_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(4)]
    public partial struct _sdl_zero_e__FixedBuffer
    {
        public byte e0;
    }
}
