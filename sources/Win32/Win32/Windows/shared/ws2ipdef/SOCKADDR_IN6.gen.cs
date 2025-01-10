// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKADDR_IN6
{
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sin6_family;
    public ushort sin6_port;

    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;
    public IN6_ADDR sin6_addr;

    [NativeTypeName("__AnonymousRecord_ws2ipdef_L196_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint sin6_scope_id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.sin6_scope_id; }
    }

    [UnscopedRef]
    public ref SCOPE_ID sin6_scope_struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.sin6_scope_struct; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint sin6_scope_id;

        [FieldOffset(0)]
        public SCOPE_ID sin6_scope_struct;
    }
}
