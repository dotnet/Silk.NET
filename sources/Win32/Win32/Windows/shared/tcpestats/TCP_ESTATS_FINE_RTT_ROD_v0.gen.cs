// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_FINE_RTT_ROD_v0
{
    [NativeTypeName("ULONG")]
    public uint RttVar;

    [NativeTypeName("ULONG")]
    public uint MaxRtt;

    [NativeTypeName("ULONG")]
    public uint MinRtt;

    [NativeTypeName("ULONG")]
    public uint SumRtt;
}
