// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/inaddr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IN_ADDR
{
    [NativeTypeName("__AnonymousRecord_inaddr_L26_C9")]
    public _S_un_e__Union S_un;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _S_un_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_inaddr_L27_C17")]
        public _S_un_b_e__Struct S_un_b;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_inaddr_L28_C17")]
        public _S_un_w_e__Struct S_un_w;

        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint S_addr;

        public partial struct _S_un_b_e__Struct
        {
            [NativeTypeName("UCHAR")]
            public byte s_b1;

            [NativeTypeName("UCHAR")]
            public byte s_b2;

            [NativeTypeName("UCHAR")]
            public byte s_b3;

            [NativeTypeName("UCHAR")]
            public byte s_b4;
        }

        public partial struct _S_un_w_e__Struct
        {
            public ushort s_w1;
            public ushort s_w2;
        }
    }
}
