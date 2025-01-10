// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PACKET_DESCRIPTION
{
    [NativeTypeName("ULONG")]
    public uint cbPacketSize;

    [NativeTypeName("ULONG")]
    public uint cPacketProperties;
    public PACKET_PROPERTY* pPacketProperties;

    [NativeTypeName("ULONG")]
    public uint cButtons;
    public Guid* pguidButtons;
}
