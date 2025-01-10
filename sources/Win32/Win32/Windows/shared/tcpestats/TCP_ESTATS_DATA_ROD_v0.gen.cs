// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_DATA_ROD_v0
{
    [NativeTypeName("ULONG64")]
    public ulong DataBytesOut;

    [NativeTypeName("ULONG64")]
    public ulong DataSegsOut;

    [NativeTypeName("ULONG64")]
    public ulong DataBytesIn;

    [NativeTypeName("ULONG64")]
    public ulong DataSegsIn;

    [NativeTypeName("ULONG64")]
    public ulong SegsOut;

    [NativeTypeName("ULONG64")]
    public ulong SegsIn;

    [NativeTypeName("ULONG")]
    public uint SoftErrors;

    [NativeTypeName("ULONG")]
    public uint SoftErrorReason;

    [NativeTypeName("ULONG")]
    public uint SndUna;

    [NativeTypeName("ULONG")]
    public uint SndNxt;

    [NativeTypeName("ULONG")]
    public uint SndMax;

    [NativeTypeName("ULONG64")]
    public ulong ThruBytesAcked;

    [NativeTypeName("ULONG")]
    public uint RcvNxt;

    [NativeTypeName("ULONG64")]
    public ulong ThruBytesReceived;
}
