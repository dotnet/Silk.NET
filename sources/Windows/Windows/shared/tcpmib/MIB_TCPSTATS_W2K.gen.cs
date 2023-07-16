// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K"]/*'/>
public partial struct MIB_TCPSTATS_W2K
{
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwRtoAlgorithm"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRtoAlgorithm;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwRtoMin"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRtoMin;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwRtoMax"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRtoMax;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwMaxConn"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxConn;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwActiveOpens"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwActiveOpens;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwPassiveOpens"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPassiveOpens;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwAttemptFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttemptFails;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwEstabResets"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEstabResets;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwCurrEstab"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrEstab;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwInSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInSegs;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwOutSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutSegs;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwRetransSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRetransSegs;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwInErrs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInErrs;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwOutRsts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutRsts;
    /// <include file='MIB_TCPSTATS_W2K.xml' path='doc/member[@name="MIB_TCPSTATS_W2K.dwNumConns"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumConns;
}