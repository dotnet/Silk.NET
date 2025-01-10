// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct FILE_FULL_DIR_INFO
{
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;

    [NativeTypeName("ULONG")]
    public uint FileIndex;
    public LARGE_INTEGER CreationTime;
    public LARGE_INTEGER LastAccessTime;
    public LARGE_INTEGER LastWriteTime;
    public LARGE_INTEGER ChangeTime;
    public LARGE_INTEGER EndOfFile;
    public LARGE_INTEGER AllocationSize;

    [NativeTypeName("ULONG")]
    public uint FileAttributes;

    [NativeTypeName("ULONG")]
    public uint FileNameLength;

    [NativeTypeName("ULONG")]
    public uint EaSize;

    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

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
