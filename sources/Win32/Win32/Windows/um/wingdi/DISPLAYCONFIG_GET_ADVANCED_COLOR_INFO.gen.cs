// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    [NativeTypeName("__AnonymousRecord_wingdi_L3170_C5")]
    public _Anonymous_e__Union Anonymous;
    public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

    [NativeTypeName("UINT32")]
    public uint bitsPerColorChannel;
    public uint advancedColorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.advancedColorSupported; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.advancedColorSupported = value; }
    }
    public uint advancedColorEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.advancedColorEnabled; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.advancedColorEnabled = value; }
    }
    public uint wideColorEnforced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.wideColorEnforced; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.wideColorEnforced = value; }
    }
    public uint advancedColorForceDisabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.advancedColorForceDisabled; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.advancedColorForceDisabled = value; }
    }
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.reserved = value; }
    }

    [UnscopedRef]
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L3172_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorSupported
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }

            [NativeTypeName("UINT32 : 1")]
            public uint wideColorEnforced
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 2) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
            }

            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorForceDisabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 3) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
            }

            [NativeTypeName("UINT32 : 28")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 4) & 0xFFFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFFFFFFFu << 4)) | ((value & 0xFFFFFFFu) << 4); }
            }
        }
    }
}
