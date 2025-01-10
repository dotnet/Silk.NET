// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENT_DATA_DESCRIPTOR
{
    [NativeTypeName("ULONGLONG")]
    public ulong Ptr;

    [NativeTypeName("ULONG")]
    public uint Size;

    [NativeTypeName("__AnonymousRecord_evntprov_L183_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved; }
    }

    [UnscopedRef]
    public ref byte Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Type; }
    }

    [UnscopedRef]
    public ref byte Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Reserved1; }
    }

    [UnscopedRef]
    public ref ushort Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Reserved2; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Reserved;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_evntprov_L185_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("UCHAR")]
            public byte Type;

            [NativeTypeName("UCHAR")]
            public byte Reserved1;
            public ushort Reserved2;
        }
    }
}
