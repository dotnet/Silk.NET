// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_REC_ROD_v0
{
    [NativeTypeName("ULONG")]
    public uint CurRwinSent;

    [NativeTypeName("ULONG")]
    public uint MaxRwinSent;

    [NativeTypeName("ULONG")]
    public uint MinRwinSent;

    [NativeTypeName("ULONG")]
    public uint LimRwin;

    [NativeTypeName("ULONG")]
    public uint DupAckEpisodes;

    [NativeTypeName("ULONG")]
    public uint DupAcksOut;

    [NativeTypeName("ULONG")]
    public uint CeRcvd;

    [NativeTypeName("ULONG")]
    public uint EcnSent;

    [NativeTypeName("ULONG")]
    public uint EcnNoncesRcvd;

    [NativeTypeName("ULONG")]
    public uint CurReasmQueue;

    [NativeTypeName("ULONG")]
    public uint MaxReasmQueue;

    [NativeTypeName("SIZE_T")]
    public nuint CurAppRQueue;

    [NativeTypeName("SIZE_T")]
    public nuint MaxAppRQueue;

    [NativeTypeName("UCHAR")]
    public byte WinScaleSent;
}
