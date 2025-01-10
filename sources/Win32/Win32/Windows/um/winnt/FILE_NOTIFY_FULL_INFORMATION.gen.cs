// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_NOTIFY_FULL_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    [NativeTypeName("DWORD")]
    public uint Action;
    public LARGE_INTEGER CreationTime;
    public LARGE_INTEGER LastModificationTime;
    public LARGE_INTEGER LastChangeTime;
    public LARGE_INTEGER LastAccessTime;
    public LARGE_INTEGER AllocatedLength;
    public LARGE_INTEGER FileSize;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("__AnonymousRecord_winnt_L15051_C5")]
    public _Anonymous_e__Union Anonymous;
    public LARGE_INTEGER FileId;
    public LARGE_INTEGER ParentFileId;

    [NativeTypeName("WORD")]
    public ushort FileNameLength;
    public byte FileNameFlags;
    public byte Reserved;

    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    [UnscopedRef]
    public ref uint ReparsePointTag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ReparsePointTag; }
    }

    [UnscopedRef]
    public ref uint EaSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.EaSize; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ReparsePointTag;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EaSize;
    }

    public partial struct _FileName_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
