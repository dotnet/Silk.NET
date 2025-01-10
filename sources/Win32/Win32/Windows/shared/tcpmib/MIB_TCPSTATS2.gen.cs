// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct MIB_TCPSTATS2
{
    public TCP_RTO_ALGORITHM RtoAlgorithm;

    [NativeTypeName("DWORD")]
    public uint dwRtoMin;

    [NativeTypeName("DWORD")]
    public uint dwRtoMax;

    [NativeTypeName("DWORD")]
    public uint dwMaxConn;

    [NativeTypeName("DWORD")]
    public uint dwActiveOpens;

    [NativeTypeName("DWORD")]
    public uint dwPassiveOpens;

    [NativeTypeName("DWORD")]
    public uint dwAttemptFails;

    [NativeTypeName("DWORD")]
    public uint dwEstabResets;

    [NativeTypeName("DWORD")]
    public uint dwCurrEstab;

    [NativeTypeName("DWORD64")]
    public ulong dw64InSegs;

    [NativeTypeName("DWORD64")]
    public ulong dw64OutSegs;

    [NativeTypeName("DWORD")]
    public uint dwRetransSegs;

    [NativeTypeName("DWORD")]
    public uint dwInErrs;

    [NativeTypeName("DWORD")]
    public uint dwOutRsts;

    [NativeTypeName("DWORD")]
    public uint dwNumConns;
}
