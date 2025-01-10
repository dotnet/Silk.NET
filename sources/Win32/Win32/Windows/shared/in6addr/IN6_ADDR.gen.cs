// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/in6addr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IN6_ADDR
{
    [NativeTypeName("__AnonymousRecord_in6addr_L26_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UCHAR[16]")]
        public _Byte_e__FixedBuffer Byte;

        [FieldOffset(0)]
        [NativeTypeName("USHORT[8]")]
        public _Word_e__FixedBuffer Word;

        [InlineArray(16)]
        public partial struct _Byte_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(8)]
        public partial struct _Word_e__FixedBuffer
        {
            public ushort e0;
        }
    }
}
