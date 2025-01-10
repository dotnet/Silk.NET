// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_LAYOUT_NAME_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint NextNameOffset;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;

    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    [NativeTypeName("DWORD")]
    public uint Reserved;

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
