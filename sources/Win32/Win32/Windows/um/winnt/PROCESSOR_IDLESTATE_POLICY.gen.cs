// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESSOR_IDLESTATE_POLICY
{
    [NativeTypeName("WORD")]
    public ushort Revision;

    [NativeTypeName("__AnonymousRecord_winnt_L18935_C5")]
    public _Flags_e__Union Flags;

    [NativeTypeName("DWORD")]
    public uint PolicyCount;

    [NativeTypeName("PROCESSOR_IDLESTATE_INFO[3]")]
    public _Policy_e__FixedBuffer Policy;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort AsWORD;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L18937_C9")]
        public _Anonymous_e__Struct Anonymous;
        public ushort AllowScaling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.AllowScaling; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.AllowScaling = value; }
        }
        public ushort Disabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.Disabled; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.Disabled = value; }
        }
        public ushort Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.Reserved; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.Reserved = value; }
        }

        public partial struct _Anonymous_e__Struct
        {
            public ushort _bitfield;

            [NativeTypeName("WORD : 1")]
            public ushort AllowScaling
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (ushort)(_bitfield & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u)); }
            }

            [NativeTypeName("WORD : 1")]
            public ushort Disabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (ushort)((_bitfield >> 1) & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
            }

            [NativeTypeName("WORD : 14")]
            public ushort Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (ushort)((_bitfield >> 2) & 0x3FFFu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x3FFFu << 2)) | ((value & 0x3FFFu) << 2));
                }
            }
        }
    }

    [InlineArray(3)]
    public partial struct _Policy_e__FixedBuffer
    {
        public PROCESSOR_IDLESTATE_INFO e0;
    }
}
