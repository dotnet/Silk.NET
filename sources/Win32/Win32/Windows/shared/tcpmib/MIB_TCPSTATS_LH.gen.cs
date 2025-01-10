// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_TCPSTATS_LH
{
    [NativeTypeName("__AnonymousRecord_tcpmib_L273_C5")]
    public _Anonymous_e__Union Anonymous;

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

    [NativeTypeName("DWORD")]
    public uint dwInSegs;

    [NativeTypeName("DWORD")]
    public uint dwOutSegs;

    [NativeTypeName("DWORD")]
    public uint dwRetransSegs;

    [NativeTypeName("DWORD")]
    public uint dwInErrs;

    [NativeTypeName("DWORD")]
    public uint dwOutRsts;

    [NativeTypeName("DWORD")]
    public uint dwNumConns;

    [UnscopedRef]
    public ref uint dwRtoAlgorithm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwRtoAlgorithm; }
    }

    [UnscopedRef]
    public ref TCP_RTO_ALGORITHM RtoAlgorithm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.RtoAlgorithm; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwRtoAlgorithm;

        [FieldOffset(0)]
        public TCP_RTO_ALGORITHM RtoAlgorithm;
    }
}
