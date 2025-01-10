// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IP_ADAPTER_WINS_SERVER_ADDRESS_LH
{
    [NativeTypeName("__AnonymousRecord_IPTypes_L218_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("struct _IP_ADAPTER_WINS_SERVER_ADDRESS_LH *")]
    public IP_ADAPTER_WINS_SERVER_ADDRESS_LH* Next;
    public SOCKET_ADDRESS Address;

    [UnscopedRef]
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Alignment; }
    }

    [UnscopedRef]
    public ref uint Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Length; }
    }

    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Reserved; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_IPTypes_L220_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint Length;

            [NativeTypeName("DWORD")]
            public uint Reserved;
        }
    }
}
