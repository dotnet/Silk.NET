// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K"]/*'/>
public partial struct MIB_IPSTATS_W2K
{
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwForwarding"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwarding;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwDefaultTTL"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDefaultTTL;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInReceives"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInReceives;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInHdrErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInHdrErrors;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInAddrErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInAddrErrors;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwForwDatagrams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwDatagrams;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInUnknownProtos"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInUnknownProtos;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInDiscards;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwInDelivers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInDelivers;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwOutRequests"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutRequests;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwRoutingDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRoutingDiscards;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwOutDiscards"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutDiscards;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwOutNoRoutes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutNoRoutes;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwReasmTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmTimeout;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwReasmReqds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmReqds;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwReasmOks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmOks;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwReasmFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReasmFails;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwFragOks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragOks;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwFragFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragFails;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwFragCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFragCreates;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwNumIf"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumIf;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwNumAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumAddr;
    /// <include file='MIB_IPSTATS_W2K.xml' path='doc/member[@name="MIB_IPSTATS_W2K.dwNumRoutes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumRoutes;
}