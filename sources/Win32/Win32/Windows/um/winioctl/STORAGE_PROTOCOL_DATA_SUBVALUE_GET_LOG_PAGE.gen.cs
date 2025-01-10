// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winioctl_L2359_C5")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint AsUlong;
    public uint RetainAsynEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.RetainAsynEvent; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.RetainAsynEvent = value; }
    }
    public uint LogSpecificField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.LogSpecificField; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.LogSpecificField = value; }
    }
    public uint Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Reserved0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Reserved0 = value; }
    }
    public uint UUIDIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.UUIDIndex; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.UUIDIndex = value; }
    }
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Reserved = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint RetainAsynEvent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }

        [NativeTypeName("DWORD : 4")]
        public uint LogSpecificField
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 1) & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFu << 1)) | ((value & 0xFu) << 1); }
        }

        [NativeTypeName("DWORD : 3")]
        public uint Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 5) & 0x7u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5); }
        }

        [NativeTypeName("DWORD : 7")]
        public uint UUIDIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 8) & 0x7Fu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7Fu << 8)) | ((value & 0x7Fu) << 8); }
        }

        [NativeTypeName("DWORD : 17")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 15) & 0x1FFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1FFFFu << 15)) | ((value & 0x1FFFFu) << 15); }
        }
    }
}
