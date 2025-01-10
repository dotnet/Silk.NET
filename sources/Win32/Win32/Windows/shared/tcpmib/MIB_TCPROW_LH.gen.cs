// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_TCPROW_LH
{
    [NativeTypeName("__AnonymousRecord_tcpmib_L69_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("DWORD")]
    public uint dwRemoteAddr;

    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    [UnscopedRef]
    public ref uint dwState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwState; }
    }

    [UnscopedRef]
    public ref MIB_TCP_STATE State
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.State; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwState;

        [FieldOffset(0)]
        public MIB_TCP_STATE State;
    }
}
