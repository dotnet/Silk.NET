// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH"]/*'/>
public partial struct MIB_IPSTATS_LH
{
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ipmib_L202_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwDefaultTTL"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDefaultTTL;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInReceives"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInReceives;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInHdrErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInHdrErrors;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInAddrErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInAddrErrors;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwForwDatagrams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwDatagrams;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInUnknownProtos"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInUnknownProtos;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInDiscards;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwInDelivers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInDelivers;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwOutRequests"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutRequests;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwRoutingDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRoutingDiscards;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwOutDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutDiscards;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwOutNoRoutes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutNoRoutes;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwReasmTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmTimeout;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwReasmReqds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmReqds;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwReasmOks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmOks;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwReasmFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmFails;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwFragOks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragOks;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwFragFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragFails;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwFragCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragCreates;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwNumIf"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumIf;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwNumAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumAddr;
    /// <include file='MIB_IPSTATS_LH.xml' path='doc/member[@name="MIB_IPSTATS_LH.dwNumRoutes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumRoutes;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwForwarding"]/*'/>
    [UnscopedRef]
    public ref uint dwForwarding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwForwarding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Forwarding"]/*'/>
    [UnscopedRef]
    public ref MIB_IPSTATS_FORWARDING Forwarding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Forwarding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwForwarding"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwForwarding;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Forwarding"]/*'/>
        [FieldOffset(0)]
        public MIB_IPSTATS_FORWARDING Forwarding;
    }
}