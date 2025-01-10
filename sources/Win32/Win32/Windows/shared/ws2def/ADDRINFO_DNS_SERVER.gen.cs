// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ADDRINFO_DNS_SERVER
{
    [NativeTypeName("unsigned int")]
    public uint ai_servertype;

    [NativeTypeName("unsigned long long")]
    public ulong ai_flags;

    [NativeTypeName("unsigned int")]
    public uint ai_addrlen;

    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;

    [NativeTypeName("__AnonymousRecord_ws2def_L1103_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ushort* ai_template
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ai_template; }
    }

    [UnscopedRef]
    public ref ushort* ai_hostname
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ai_hostname; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PWSTR")]
        public ushort* ai_template;

        [FieldOffset(0)]
        [NativeTypeName("PWSTR")]
        public ushort* ai_hostname;
    }
}
