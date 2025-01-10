// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KERNEL_CET_CONTEXT
{
    [NativeTypeName("DWORD64")]
    public ulong Ssp;

    [NativeTypeName("DWORD64")]
    public ulong Rip;

    [NativeTypeName("WORD")]
    public ushort SegCs;

    [NativeTypeName("__AnonymousRecord_winnt_L2794_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("WORD[2]")]
    public _Fill_e__FixedBuffer Fill;

    [UnscopedRef]
    public ref ushort AllFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.AllFlags; }
    }
    public ushort UseWrss
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.UseWrss; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.UseWrss = value; }
    }
    public ushort PopShadowStackOne
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.PopShadowStackOne; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.PopShadowStackOne = value; }
    }
    public ushort Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Unused; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Unused = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort AllFlags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L2796_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public ushort _bitfield;

            [NativeTypeName("WORD : 1")]
            public ushort UseWrss
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (ushort)(_bitfield & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u)); }
            }

            [NativeTypeName("WORD : 1")]
            public ushort PopShadowStackOne
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (ushort)((_bitfield >> 1) & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
            }

            [NativeTypeName("WORD : 14")]
            public ushort Unused
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

    [InlineArray(2)]
    public partial struct _Fill_e__FixedBuffer
    {
        public ushort e0;
    }
}
