// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA
{
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint HeaderData;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L21248_C5")]
    public _Anonymous_e__Struct Anonymous;
    public uint FunctionLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.FunctionLength; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.FunctionLength = value; }
    }
    public uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Version; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Version = value; }
    }
    public uint ExceptionDataPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.ExceptionDataPresent; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.ExceptionDataPresent = value; }
    }
    public uint EpilogInHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.EpilogInHeader; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.EpilogInHeader = value; }
    }
    public uint EpilogCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.EpilogCount; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.EpilogCount = value; }
    }
    public uint CodeWords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.CodeWords; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.CodeWords = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 18")]
        public uint FunctionLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x3FFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x3FFFFu) | (value & 0x3FFFFu); }
        }

        [NativeTypeName("DWORD : 2")]
        public uint Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 18) & 0x3u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x3u << 18)) | ((value & 0x3u) << 18); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint ExceptionDataPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 20) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint EpilogInHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 21) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21); }
        }

        [NativeTypeName("DWORD : 5")]
        public uint EpilogCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 22) & 0x1Fu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1Fu << 22)) | ((value & 0x1Fu) << 22); }
        }

        [NativeTypeName("DWORD : 5")]
        public uint CodeWords
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 27) & 0x1Fu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1Fu << 27)) | ((value & 0x1Fu) << 27); }
        }
    }
}
