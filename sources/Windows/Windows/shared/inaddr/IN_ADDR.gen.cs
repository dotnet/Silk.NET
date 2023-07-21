// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/inaddr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IN_ADDR.xml' path='doc/member[@name="IN_ADDR"]/*' />
public partial struct IN_ADDR
{
    /// <include file='IN_ADDR.xml' path='doc/member[@name="IN_ADDR.S_un"]/*' />
    [NativeTypeName("__AnonymousRecord_inaddr_L26_C9")]
    public _S_un_e__Union S_un;

    /// <include file='_S_un_e__Union.xml' path='doc/member[@name="_S_un_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _S_un_e__Union
    {
        /// <include file='_S_un_e__Union.xml' path='doc/member[@name="_S_un_e__Union.S_un_b"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_inaddr_L27_C17")]
        public _S_un_b_e__Struct S_un_b;

        /// <include file='_S_un_e__Union.xml' path='doc/member[@name="_S_un_e__Union.S_un_w"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_inaddr_L28_C17")]
        public _S_un_w_e__Struct S_un_w;

        /// <include file='_S_un_e__Union.xml' path='doc/member[@name="_S_un_e__Union.S_addr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint S_addr;

        /// <include file='_S_un_b_e__Struct.xml' path='doc/member[@name="_S_un_b_e__Struct"]/*' />
        public partial struct _S_un_b_e__Struct
        {
            /// <include file='_S_un_b_e__Struct.xml' path='doc/member[@name="_S_un_b_e__Struct.s_b1"]/*' />
            [NativeTypeName("UCHAR")]
            public byte s_b1;

            /// <include file='_S_un_b_e__Struct.xml' path='doc/member[@name="_S_un_b_e__Struct.s_b2"]/*' />
            [NativeTypeName("UCHAR")]
            public byte s_b2;

            /// <include file='_S_un_b_e__Struct.xml' path='doc/member[@name="_S_un_b_e__Struct.s_b3"]/*' />
            [NativeTypeName("UCHAR")]
            public byte s_b3;

            /// <include file='_S_un_b_e__Struct.xml' path='doc/member[@name="_S_un_b_e__Struct.s_b4"]/*' />
            [NativeTypeName("UCHAR")]
            public byte s_b4;
        }

        /// <include file='_S_un_w_e__Struct.xml' path='doc/member[@name="_S_un_w_e__Struct"]/*' />
        public partial struct _S_un_w_e__Struct
        {
            /// <include file='_S_un_w_e__Struct.xml' path='doc/member[@name="_S_un_w_e__Struct.s_w1"]/*' />
            public ushort s_w1;

            /// <include file='_S_un_w_e__Struct.xml' path='doc/member[@name="_S_un_w_e__Struct.s_w2"]/*' />
            public ushort s_w2;
        }
    }
}
