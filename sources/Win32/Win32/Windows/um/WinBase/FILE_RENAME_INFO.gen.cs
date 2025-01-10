// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_RENAME_INFO
{
    [NativeTypeName("__AnonymousRecord_winbase_L9111_C5")]
    public _Anonymous_e__Union Anonymous;
    public HANDLE RootDirectory;

    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    [UnscopedRef]
    public ref byte ReplaceIfExists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ReplaceIfExists; }
    }

    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Flags; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte ReplaceIfExists;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;
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
