// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ENCRYPTED_DATA_INFO
{
    [NativeTypeName("DWORDLONG")]
    public ulong StartingFileOffset;

    [NativeTypeName("DWORD")]
    public uint OutputBufferOffset;

    [NativeTypeName("DWORD")]
    public uint BytesWithinFileSize;

    [NativeTypeName("DWORD")]
    public uint BytesWithinValidDataLength;

    [NativeTypeName("WORD")]
    public ushort CompressionFormat;
    public byte DataUnitShift;
    public byte ChunkShift;
    public byte ClusterShift;
    public byte EncryptionFormat;

    [NativeTypeName("WORD")]
    public ushort NumberOfDataBlocks;

    [NativeTypeName("DWORD[1]")]
    public _DataBlockSize_e__FixedBuffer DataBlockSize;

    public partial struct _DataBlockSize_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
