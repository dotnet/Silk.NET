// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPFORWARDROW
{
    [NativeTypeName("DWORD")]
    public uint dwForwardDest;

    [NativeTypeName("DWORD")]
    public uint dwForwardMask;

    [NativeTypeName("DWORD")]
    public uint dwForwardPolicy;

    [NativeTypeName("DWORD")]
    public uint dwForwardNextHop;

    [NativeTypeName("IF_INDEX")]
    public uint dwForwardIfIndex;

    [NativeTypeName("__AnonymousRecord_ipmib_L112_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_ipmib_L116_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("DWORD")]
    public uint dwForwardAge;

    [NativeTypeName("DWORD")]
    public uint dwForwardNextHopAS;

    [NativeTypeName("DWORD")]
    public uint dwForwardMetric1;

    [NativeTypeName("DWORD")]
    public uint dwForwardMetric2;

    [NativeTypeName("DWORD")]
    public uint dwForwardMetric3;

    [NativeTypeName("DWORD")]
    public uint dwForwardMetric4;

    [NativeTypeName("DWORD")]
    public uint dwForwardMetric5;

    [UnscopedRef]
    public ref uint dwForwardType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.dwForwardType; }
    }

    [UnscopedRef]
    public ref MIB_IPFORWARD_TYPE ForwardType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.ForwardType; }
    }

    [UnscopedRef]
    public ref uint dwForwardProto
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.dwForwardProto; }
    }

    [UnscopedRef]
    public ref MIB_IPFORWARD_PROTO ForwardProto
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ForwardProto; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwForwardType;

        [FieldOffset(0)]
        public MIB_IPFORWARD_TYPE ForwardType;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwForwardProto;

        [FieldOffset(0)]
        public MIB_IPFORWARD_PROTO ForwardProto;
    }
}
