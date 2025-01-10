// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED
{
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint ExtendedHeaderData;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L21260_C5")]
    public _Anonymous_e__Struct Anonymous;
    public uint ExtendedEpilogCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.ExtendedEpilogCount; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.ExtendedEpilogCount = value; }
    }
    public uint ExtendedCodeWords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.ExtendedCodeWords; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.ExtendedCodeWords = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 16")]
        public uint ExtendedEpilogCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0xFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu); }
        }

        [NativeTypeName("DWORD : 8")]
        public uint ExtendedCodeWords
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 16) & 0xFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFFu << 16)) | ((value & 0xFFu) << 16); }
        }
    }
}
