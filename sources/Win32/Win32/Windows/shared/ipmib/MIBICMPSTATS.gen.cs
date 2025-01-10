// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIBICMPSTATS
{
    [NativeTypeName("DWORD")]
    public uint dwMsgs;

    [NativeTypeName("DWORD")]
    public uint dwErrors;

    [NativeTypeName("DWORD")]
    public uint dwDestUnreachs;

    [NativeTypeName("DWORD")]
    public uint dwTimeExcds;

    [NativeTypeName("DWORD")]
    public uint dwParmProbs;

    [NativeTypeName("DWORD")]
    public uint dwSrcQuenchs;

    [NativeTypeName("DWORD")]
    public uint dwRedirects;

    [NativeTypeName("DWORD")]
    public uint dwEchos;

    [NativeTypeName("DWORD")]
    public uint dwEchoReps;

    [NativeTypeName("DWORD")]
    public uint dwTimestamps;

    [NativeTypeName("DWORD")]
    public uint dwTimestampReps;

    [NativeTypeName("DWORD")]
    public uint dwAddrMasks;

    [NativeTypeName("DWORD")]
    public uint dwAddrMaskReps;
}
