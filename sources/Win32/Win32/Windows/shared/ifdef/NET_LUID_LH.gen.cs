// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct NET_LUID_LH
{
    [FieldOffset(0)]
    [NativeTypeName("ULONG64")]
    public ulong Value;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_ifdef_L121_C5")]
    public _Info_e__Struct Info;

    public partial struct _Info_e__Struct
    {
        public ulong _bitfield;

        [NativeTypeName("ULONG64 : 24")]
        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0xFFFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0xFFFFFFUL) | (value & 0xFFFFFFUL); }
        }

        [NativeTypeName("ULONG64 : 24")]
        public ulong NetLuidIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 24) & 0xFFFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFFFFFFUL << 24)) | ((value & 0xFFFFFFUL) << 24); }
        }

        [NativeTypeName("ULONG64 : 16")]
        public ulong IfType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 48) & 0xFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFFFFUL << 48)) | ((value & 0xFFFFUL) << 48); }
        }
    }
}
