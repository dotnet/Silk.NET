// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EPILOG_SCOPE
{
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint EpilogScopeData;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L21268_C5")]
    public _Anonymous_e__Struct Anonymous;
    public uint EpilogStartOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.EpilogStartOffset; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.EpilogStartOffset = value; }
    }
    public uint Res0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Res0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Res0 = value; }
    }
    public uint EpilogStartIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.EpilogStartIndex; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.EpilogStartIndex = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 18")]
        public uint EpilogStartOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x3FFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x3FFFFu) | (value & 0x3FFFFu); }
        }

        [NativeTypeName("DWORD : 4")]
        public uint Res0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 18) & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFu << 18)) | ((value & 0xFu) << 18); }
        }

        [NativeTypeName("DWORD : 10")]
        public uint EpilogStartIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 22) & 0x3FFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22); }
        }
    }
}
