// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2"]/*'/>
[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct MIB_UDPSTATS2
{
    /// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2.dw64InDatagrams"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong dw64InDatagrams;
    /// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2.dwNoPorts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNoPorts;
    /// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2.dwInErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInErrors;
    /// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2.dw64OutDatagrams"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong dw64OutDatagrams;
    /// <include file='MIB_UDPSTATS2.xml' path='doc/member[@name="MIB_UDPSTATS2.dwNumAddrs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumAddrs;
}