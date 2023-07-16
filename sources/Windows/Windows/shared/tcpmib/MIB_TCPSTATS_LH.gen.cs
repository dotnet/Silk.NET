// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH"]/*'/>
public partial struct MIB_TCPSTATS_LH
{
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_tcpmib_L273_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwRtoMin"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRtoMin;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwRtoMax"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRtoMax;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwMaxConn"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxConn;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwActiveOpens"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwActiveOpens;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwPassiveOpens"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPassiveOpens;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwAttemptFails"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttemptFails;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwEstabResets"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEstabResets;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwCurrEstab"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrEstab;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwInSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInSegs;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwOutSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutSegs;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwRetransSegs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRetransSegs;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwInErrs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInErrs;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwOutRsts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutRsts;
    /// <include file='MIB_TCPSTATS_LH.xml' path='doc/member[@name="MIB_TCPSTATS_LH.dwNumConns"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumConns;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwRtoAlgorithm"]/*'/>
    [UnscopedRef]
    public ref uint dwRtoAlgorithm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwRtoAlgorithm;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RtoAlgorithm"]/*'/>
    [UnscopedRef]
    public ref TCP_RTO_ALGORITHM RtoAlgorithm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RtoAlgorithm;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwRtoAlgorithm"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRtoAlgorithm;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RtoAlgorithm"]/*'/>
        [FieldOffset(0)]
        public TCP_RTO_ALGORITHM RtoAlgorithm;
    }
}