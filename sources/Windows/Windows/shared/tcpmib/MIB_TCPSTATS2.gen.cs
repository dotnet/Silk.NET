// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2"]/*' />
[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct MIB_TCPSTATS2
{
    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.RtoAlgorithm"]/*' />
    public TCP_RTO_ALGORITHM RtoAlgorithm;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwRtoMin"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRtoMin;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwRtoMax"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRtoMax;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwMaxConn"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxConn;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwActiveOpens"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwActiveOpens;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwPassiveOpens"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPassiveOpens;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwAttemptFails"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAttemptFails;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwEstabResets"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEstabResets;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwCurrEstab"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrEstab;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dw64InSegs"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong dw64InSegs;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dw64OutSegs"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong dw64OutSegs;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwRetransSegs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRetransSegs;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwInErrs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInErrs;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwOutRsts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutRsts;

    /// <include file='MIB_TCPSTATS2.xml' path='doc/member[@name="MIB_TCPSTATS2.dwNumConns"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumConns;
}
