// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct REPARSE_GUID_DATA_BUFFER
{
    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    [NativeTypeName("WORD")]
    public ushort ReparseDataLength;

    [NativeTypeName("WORD")]
    public ushort Reserved;
    public Guid ReparseGuid;

    [NativeTypeName("__AnonymousRecord_winnt_L15276_C5")]
    public _GenericReparseBuffer_e__Struct GenericReparseBuffer;

    public partial struct _GenericReparseBuffer_e__Struct
    {
        [NativeTypeName("BYTE[1]")]
        public _DataBuffer_e__FixedBuffer DataBuffer;

        public partial struct _DataBuffer_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
