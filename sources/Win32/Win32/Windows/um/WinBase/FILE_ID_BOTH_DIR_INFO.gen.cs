// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_ID_BOTH_DIR_INFO
{
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    [NativeTypeName("DWORD")]
    public uint FileIndex;
    public LARGE_INTEGER CreationTime;
    public LARGE_INTEGER LastAccessTime;
    public LARGE_INTEGER LastWriteTime;
    public LARGE_INTEGER ChangeTime;
    public LARGE_INTEGER EndOfFile;
    public LARGE_INTEGER AllocationSize;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    [NativeTypeName("DWORD")]
    public uint EaSize;

    [NativeTypeName("CCHAR")]
    public sbyte ShortNameLength;

    [NativeTypeName("WCHAR[12]")]
    public _ShortName_e__FixedBuffer ShortName;
    public LARGE_INTEGER FileId;

    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    [InlineArray(12)]
    public partial struct _ShortName_e__FixedBuffer
    {
        public ushort e0;
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
