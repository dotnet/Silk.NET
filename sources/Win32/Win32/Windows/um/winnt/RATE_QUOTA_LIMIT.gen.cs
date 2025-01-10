// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct RATE_QUOTA_LIMIT
{
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint RateData;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L12958_C5")]
    public _Anonymous_e__Struct Anonymous;
    public uint RatePercent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.RatePercent; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.RatePercent = value; }
    }
    public uint Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Reserved0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Reserved0 = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 7")]
        public uint RatePercent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x7Fu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x7Fu) | (value & 0x7Fu); }
        }

        [NativeTypeName("DWORD : 25")]
        public uint Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 7) & 0x1FFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7); }
        }
    }
}
