// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IP_MCAST_COUNTER_INFO
{
    [NativeTypeName("ULONG64")]
    public ulong InMcastOctets;

    [NativeTypeName("ULONG64")]
    public ulong OutMcastOctets;

    [NativeTypeName("ULONG64")]
    public ulong InMcastPkts;

    [NativeTypeName("ULONG64")]
    public ulong OutMcastPkts;
}
