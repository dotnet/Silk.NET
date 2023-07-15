// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW"]/*'/>
public partial struct MIB_IPFORWARDROW
{
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardDest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardDest;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMask;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardPolicy"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardPolicy;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardNextHop"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardNextHop;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardIfIndex"]/*'/>
    [NativeTypeName("IF_INDEX")]
    public uint dwForwardIfIndex;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_ipmib_L112_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_ipmib_L116_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardAge"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardAge;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardNextHopAS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardNextHopAS;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMetric1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMetric1;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMetric2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMetric2;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMetric3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMetric3;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMetric4"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMetric4;
    /// <include file='MIB_IPFORWARDROW.xml' path='doc/member[@name="MIB_IPFORWARDROW.dwForwardMetric5"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardMetric5;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwForwardType"]/*'/>
    [UnscopedRef]
    public ref uint dwForwardType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.dwForwardType;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ForwardType"]/*'/>
    [UnscopedRef]
    public ref MIB_IPFORWARD_TYPE ForwardType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.ForwardType;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwForwardProto"]/*'/>
    [UnscopedRef]
    public ref uint dwForwardProto
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.dwForwardProto;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ForwardProto"]/*'/>
    [UnscopedRef]
    public ref MIB_IPFORWARD_PROTO ForwardProto
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.ForwardProto;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.dwForwardType"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwForwardType;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ForwardType"]/*'/>
        [FieldOffset(0)]
        public MIB_IPFORWARD_TYPE ForwardType;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dwForwardProto"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwForwardProto;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ForwardProto"]/*'/>
        [FieldOffset(0)]
        public MIB_IPFORWARD_PROTO ForwardProto;
    }
}