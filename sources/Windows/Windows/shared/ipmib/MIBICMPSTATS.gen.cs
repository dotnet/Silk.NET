// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS"]/*'/>
public partial struct MIBICMPSTATS
{
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwMsgs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgs;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwErrors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwErrors;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwDestUnreachs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDestUnreachs;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwTimeExcds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimeExcds;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwParmProbs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwParmProbs;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwSrcQuenchs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSrcQuenchs;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwRedirects"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRedirects;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwEchos"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEchos;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwEchoReps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEchoReps;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwTimestamps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimestamps;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwTimestampReps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimestampReps;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwAddrMasks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAddrMasks;
    /// <include file='MIBICMPSTATS.xml' path='doc/member[@name="MIBICMPSTATS.dwAddrMaskReps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAddrMaskReps;
}