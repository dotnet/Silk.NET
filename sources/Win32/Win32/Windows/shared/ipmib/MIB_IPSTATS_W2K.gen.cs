// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPSTATS_W2K
{
    [NativeTypeName("DWORD")]
    public uint dwForwarding;

    [NativeTypeName("DWORD")]
    public uint dwDefaultTTL;

    [NativeTypeName("DWORD")]
    public uint dwInReceives;

    [NativeTypeName("DWORD")]
    public uint dwInHdrErrors;

    [NativeTypeName("DWORD")]
    public uint dwInAddrErrors;

    [NativeTypeName("DWORD")]
    public uint dwForwDatagrams;

    [NativeTypeName("DWORD")]
    public uint dwInUnknownProtos;

    [NativeTypeName("DWORD")]
    public uint dwInDiscards;

    [NativeTypeName("DWORD")]
    public uint dwInDelivers;

    [NativeTypeName("DWORD")]
    public uint dwOutRequests;

    [NativeTypeName("DWORD")]
    public uint dwRoutingDiscards;

    [NativeTypeName("DWORD")]
    public uint dwOutDiscards;

    [NativeTypeName("DWORD")]
    public uint dwOutNoRoutes;

    [NativeTypeName("DWORD")]
    public uint dwReasmTimeout;

    [NativeTypeName("DWORD")]
    public uint dwReasmReqds;

    [NativeTypeName("DWORD")]
    public uint dwReasmOks;

    [NativeTypeName("DWORD")]
    public uint dwReasmFails;

    [NativeTypeName("DWORD")]
    public uint dwFragOks;

    [NativeTypeName("DWORD")]
    public uint dwFragFails;

    [NativeTypeName("DWORD")]
    public uint dwFragCreates;

    [NativeTypeName("DWORD")]
    public uint dwNumIf;

    [NativeTypeName("DWORD")]
    public uint dwNumAddr;

    [NativeTypeName("DWORD")]
    public uint dwNumRoutes;
}
